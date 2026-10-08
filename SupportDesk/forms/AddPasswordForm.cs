using System;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class AddPasswordForm : Form
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
        public AddPasswordForm()
        {
            InitializeComponent();
        }

        private async void AddPasswordForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
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
            string site = textBoxSite.Text;
            string login = textBoxLogin.Text;
            string pass = textBoxPassword.Text;
            if (site == "" || login == "" || pass == "")
            {
                return;
            }
            else
            {
                SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_passwords.main} ({Table_passwords.site}, {Table_passwords.login}, {Table_passwords.pass}) VALUES (@site, @login, @pass)", DB);
                _ = commandInsert.Parameters.AddWithValue("site", site);
                _ = commandInsert.Parameters.AddWithValue("login", login);
                _ = commandInsert.Parameters.AddWithValue("pass", pass);
                _ = await commandInsert.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Пароль успешно добавлен!", "Новый пароль", "Accept");
                DateTime thisDay = DateTime.Now;
                File.AppendAllText(Logs.file, $"[Пароль]Добавлен {site} {login}:{pass} ({DataUsers.Initials}) ({thisDay:dd.MM.yyyy HH:mm})");
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
            buttonAdd.Enabled = textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxSite.Text != "";
        }
        #endregion
    }
}