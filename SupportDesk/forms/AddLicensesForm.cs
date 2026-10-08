using System;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class AddLicensesForm : Form
    {
        #region Настройки формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        #region Локальные переменные
        private SQLiteConnection DB;
        #endregion
        public AddLicensesForm()
        {
            InitializeComponent();
        }

        private async void AddLicensesForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            comboBoxType.SelectedItem = "Выберите тип";
        }
        #region Управление формой
        private void FormControl(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        #region Добавить
        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            string cabinet = textBoxCabinet.Text;
            string software = textBoxSoftware.Text;
            string typeCheck = comboBoxType.Text;
            string link = textBoxPdf.Text;
            if (cabinet == "" || software == "" || typeCheck == "Выберите тип" || link == "")
            {
                return;
            }
            else
            {
                SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_licenses.main} ({Table_licenses.cabinet}, {Table_licenses.software}, [{Table_licenses.check}], {Table_licenses.pdf}) VALUES (@cabinet, @software, @typeCheck, @pdf)", DB);
                _ = commandInsert.Parameters.AddWithValue("cabinet", cabinet);
                _ = commandInsert.Parameters.AddWithValue("software", software);
                _ = commandInsert.Parameters.AddWithValue("typeCheck", typeCheck);
                _ = commandInsert.Parameters.AddWithValue("pdf", link);
                _ = await commandInsert.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Программа успешно добавлена!", "Новая программа", "Accept");
                DateTime thisDay = DateTime.Now;
                File.AppendAllText(Logs.file, $"[Лицензия]Добавлено {software} в {cabinet} ({DataUsers.Initials}) ({thisDay:dd.MM.yyyy HH:mm})");
                File.AppendAllText(Logs.file, Environment.NewLine);
                Close();
            }
        }
        #endregion
        #region Отмена
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region Проверка на заполненость всех данных
        private void CheckTextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = textBoxCabinet.Text != "" && textBoxPdf.Text != "" && textBoxSoftware.Text != "";
        }
        #endregion
    }
}