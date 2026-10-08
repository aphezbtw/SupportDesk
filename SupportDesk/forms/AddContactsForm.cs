using System;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class AddContactsForm : Form
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
        public AddContactsForm()
        {
            InitializeComponent();
        }

        private async void AddContactsForm_Load(object sender, EventArgs e)
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
            string company = textBoxCompany.Text;
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            if (company == "" || name == "" || phone == "")
            {
                return;
            }
            else
            {
                SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_contacts.main} ({Table_contacts.company}, {Table_contacts.name}, {Table_contacts.phone}) VALUES (@company, @name, @phone)", DB);
                _ = commandInsert.Parameters.AddWithValue("company", company);
                _ = commandInsert.Parameters.AddWithValue("name", name);
                _ = commandInsert.Parameters.AddWithValue("phone", phone);
                _ = await commandInsert.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Контакт успешно добавлен!", "Новый контакт", "Accept");
                DateTime thisDay = DateTime.Now;
                File.AppendAllText(Logs.file, $"[Внешние контакты]Добавлено {company}: {name}-{phone} ({DataUsers.Initials}) ({thisDay:dd.MM.yyyy HH:mm})");
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
            buttonAdd.Enabled = textBoxCompany.Text != "" && textBoxName.Text != "" && textBoxPhone.Text != "";
        }
        #endregion
    }
}