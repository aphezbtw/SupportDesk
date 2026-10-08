using System;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class ChangePassForm : Form
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
        [Obsolete]
        public ChangePassForm()
        {
            InitializeComponent();
        }

        private async void ChangePassForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
        }
        #region Применить
        [Obsolete]
        private async void ButtonChangePass_Click(object sender, EventArgs e)
        {
            if (textBoxNewPass.Text == "" || textBoxNewPass2.Text == "" || textBoxOldPass.Text == "")
            {
                MessageBoxUI.Show("Все поля должны быть заполнены!", "Ошибка изменения пароля", "Error");
                return;
            }
            if (textBoxNewPass.Text != textBoxNewPass2.Text)
            {
                MessageBoxUI.Show("Пароли не совпадают!", "Ошибка изменения пароля", "Error");
                return;
            }
            if (textBoxOldPass.Text != DataUsers.Pass)
            {
                MessageBoxUI.Show("Старый пароль введен неверно!", "Ошибка изменения пароля", "Error");
                return;
            }
            if (textBoxNewPass.Text.Length < 8 || textBoxNewPass2.Text.Length < 8)
            {
                MessageBoxUI.Show("Пароль должен состоять минимум из 8 символов!", "Ошибка изменения пароля", "Error");
                return;
            }
            SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_users.main} SET [{Table_users.pass}]=@pass WHERE [{Table_users.login}]=@login", DB);
            _ = commandUpdate.Parameters.AddWithValue("pass", textBoxNewPass.Text);
            _ = commandUpdate.Parameters.AddWithValue("login", DataUsers.Login);
            _ = await commandUpdate.ExecuteNonQueryAsync();
            DataUsers.Pass = textBoxNewPass.Text;
            MessageBoxUI.Show("Пароль изменен!", "Смена пароля", "Accept");
            Form fDataUser = new UserDataForm();
            fDataUser.Show();
            fDataUser.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Hide();
        }
        #endregion
        #region Выход
        [Obsolete]
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Form fDataUser = new UserDataForm();
            fDataUser.Show();
            fDataUser.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Hide();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        #endregion
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
        #region Проверка ввода без русских букв
        private void TextBoxNewPass_TextChanged(object sender, EventArgs e)
        {
            textBoxNewPass.Text = Regex.Replace(textBoxNewPass.Text, "[^A-Za-z0-9]", "");
            if (textBoxNewPass.Text == "")
            {
                labelCheckPassword.Text = "";
                buttonChangePass.Enabled = true;

            }
            CheckValidatePassword(textBoxNewPass.Text.ToLower());
        }
        private void CheckValidatePassword(string checkPass)
        {
            foreach (string text in CertificateSecurity.noPasswords)
            {
                if (Regex.IsMatch(checkPass, $"\\b{text}\\b"))
                {
                    labelCheckPassword.Text = CertificateSecurity.textNoPassword;
                    buttonChangePass.Enabled = false;
                }
            }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            textBoxNewPass2.Text = Regex.Replace(textBoxNewPass2.Text, "[^A-Za-z0-9]", "");
            textBoxOldPass.Text = Regex.Replace(textBoxOldPass.Text, "[^A-Za-z0-9]", "");
        }
        #endregion
    }
}
