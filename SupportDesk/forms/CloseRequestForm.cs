using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class CloseRequestForm : Form
    {
        #region Настройка формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        #region Локальный переменные
        private SQLiteConnection DB;
        private readonly DateTime thisDay = DateTime.Now;
        #endregion
        public CloseRequestForm()
        {
            InitializeComponent();
        }

        private async void CloseRequestForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            label11.Text = $"Описание задачи № {DataRequests.Kod}";
            labelMain.Text = $"Тема задачи: {DataRequests.Tema}\n\nДата создания: {DataRequests.TheDate}\n\nТип проблемы: {DataRequests.Type}\n\nПользователь: {DataRequests.User}\n\nНомер кабинета: {DataRequests.Kabinet}\n\nВремя ожидания специалиста: {DataRequests.Time}";
            textBox1.Text = DataRequests.Result;
            if (DataUsers.GroupUser == "ADMIN")
            {
                _ = comboBoxExecutors.Items.Add(DataRequests.Executor);
                comboBoxExecutors.SelectedItem = DataRequests.Executor;
            }
            CheckDocs();
        }
        #region Управление формой
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormControl(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        #region Загрузка БД
        private void CheckDocs()
        {
            if (DataRequests.PathTo == null || DataRequests.PathTo == "")
            {
                return;
            }
            else
            {
                string extension = Path.GetExtension(DataRequests.PathTo);
                expUIButtonFile.Visible = true;
                expUIButtonFile.Text = DataRequests.NameFile;
                expUIButtonFile.Image = Image.FromFile(FileImage.PathFile(extension));
            }
            if (DataRequests.PathResultTo == null || DataRequests.PathResultTo == "")
            {
                return;
            }
            else
            {
                string extension = Path.GetExtension(DataRequests.PathResultTo);
                expUIButtonFileResult.Visible = true;
                expUIButtonFileResult.Text = DataRequests.NameFileResult;
                expUIButtonFileResult.Image = Image.FromFile(FileImage.PathFile(extension));
            }
        }
        #endregion
        #region Принять задачу
        private async void ButtonAccept_Click(object sender, EventArgs e)
        {
            string status = "Выполнена";
            SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_requests.main} SET [{Table_requests.status}]=@status, [{Table_requests.executor}]=@executor WHERE [{Table_requests.theDate}]=@date AND [{Table_requests.user}]=@user AND [{Table_requests.kabinet}]=@cabinet", DB);
            _ = commandUpdate.Parameters.AddWithValue("status", status);
            _ = commandUpdate.Parameters.AddWithValue("executor", DataRequests.Executor);
            _ = commandUpdate.Parameters.AddWithValue("date", DataRequests.TheDate);
            _ = commandUpdate.Parameters.AddWithValue("user", DataRequests.User);
            _ = commandUpdate.Parameters.AddWithValue("cabinet", DataRequests.Kabinet);
            _ = await commandUpdate.ExecuteNonQueryAsync();
            MessageBoxUI.Show("Задача закрыта!", "Закрытие задачи", "Accept");
            TelegramForm.ConfirmRequest(DataUsers.Initials, DataRequests.User, DataRequests.Kabinet, DataRequests.Time, status, DataRequests.Executor, DataRequests.Discription);
            File.AppendAllText(Logs.file, $"[Задача]{DataUsers.Initials} подтвердил выполнение задачи {DataRequests.Discription} от {DataRequests.Executor} ({thisDay:dd.MM.yyyy HH:mm})");
            File.AppendAllText(Logs.file, Environment.NewLine);
            Close();
        }
        #endregion
        #region Открыть файл задачи
        private void ExpUIButtonFile_Click(object sender, EventArgs e)
        {
            _ = Process.Start(DataRequests.PathTo);
        }
        #endregion
        #region Открыть файл результата
        private void ExpUIButtonFileResult_Click(object sender, EventArgs e)
        {
            _ = Process.Start(DataRequests.PathResultTo);
        }
        #endregion
    }
}