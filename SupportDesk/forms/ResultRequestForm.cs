using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class ResultRequestForm : Form
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
        public ResultRequestForm()
        {
            InitializeComponent();
        }

        private async void ResultRequestForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            label11.Text = $"Описание задачи № {DataRequests.Kod}";
            labelMain.Text = $"Тема задачи: {DataRequests.Tema}\n\nДата создания: {DataRequests.TheDate}\n\nТип проблемы: {DataRequests.Type}\n\nПользователь: {DataRequests.User}\n\nНомер кабинета: {DataRequests.Kabinet}\n\nВремя ожидания специалиста: {DataRequests.Time}";
            CheckDocs();
        }
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
        }
        #endregion
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
        private void TextBoxDiscription_TextChanged(object sender, EventArgs e)
        {
            buttonSend.Enabled = textBoxDiscription.Text != "";
        }
        #endregion
        #region Отправить
        private async void ButtonSend_Click(object sender, EventArgs e)
        {
            string result = textBoxDiscription.Text;
            SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_requests.main} SET [{Table_requests.status}]=@status, [{Table_requests.executor}]=@executor, [result]=@result, [{Table_requests.nameFileResult}]=@nameFile, [{Table_requests.pathFileResult}]=@pathFile WHERE [{Table_requests.theDate}]=@date AND [{Table_requests.tema}]=@tema AND [{Table_requests.user}]=@user AND [{Table_requests.kabinet}]=@kab", DB);
            _ = commandUpdate.Parameters.AddWithValue("status", "На подтверждении");
            _ = commandUpdate.Parameters.AddWithValue("executor", DataRequests.Executor);
            _ = commandUpdate.Parameters.AddWithValue("date", DataRequests.TheDate);
            _ = commandUpdate.Parameters.AddWithValue("tema", DataRequests.Tema);
            _ = commandUpdate.Parameters.AddWithValue("user", DataRequests.User);
            _ = commandUpdate.Parameters.AddWithValue("kab", DataRequests.Kabinet);
            _ = commandUpdate.Parameters.AddWithValue("result", result);
            _ = commandUpdate.Parameters.AddWithValue("nameFile", DataRequests.NameFileResult);
            _ = commandUpdate.Parameters.AddWithValue("pathFile", DataRequests.PathResultTo);
            _ = await commandUpdate.ExecuteNonQueryAsync();
            MessageBoxUI.Show("Задача закрыта!", "Закрыть задачу", "Accept");
            TelegramForm.CloseRequest(DataUsers.Initials, DataRequests.Tema, DataRequests.Type, DataRequests.User, DataRequests.Kabinet, DataRequests.Time, "На подтверждении", result);
            File.AppendAllText(Logs.file, $"[Задача]{DataUsers.Initials} закрыл задачу {DataRequests.Tema}({thisDay:dd.MM.yyyy HH:mm})");
            File.AppendAllText(Logs.file, Environment.NewLine);
            Close();
        }
        #endregion
        #region Прикрепить документ
        private void ButtonDoc_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Word files (*.doc, *.docx)|*.doc;*.docx" +
            "|Excel files (*.xls, *.xlsx)|*.xls;*.xlsx" +
            "|PDF files (*.pdf)|*.pdf" +
            "|Photoshop files (*.psd)|*.psd" +
            "|Image files (*.png, *.jpg)|*.png;*.jpg" +
            "|Music files (*.mp3)|*.mp3" +
            "|Video files (*.mp4, *.mov, *.avi)|*.mp4;*.mov;*.avi";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string path = openFileDialog1.FileName;
            string pathTo = "docs\\" + Path.GetFileName(path);
            string nameFile = Path.GetFileNameWithoutExtension(path);
            string extension = Path.GetExtension(path);
            DataRequests.PathResultFile = path;
            DataRequests.NameFileResult = nameFile;
            DataRequests.PathResultTo = pathTo;
            expUIButtonFileResult.Visible = true;
            expUIButtonFileResult.Text = nameFile;
            expUIButtonFileResult.Image = Image.FromFile(FileImage.PathFile(extension));
            File.Copy(path, pathTo, true);
        }
        #endregion  
        #region Открыть файл
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