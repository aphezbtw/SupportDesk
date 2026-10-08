using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class PasswordsForm : Form
    {
        //Переделать
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
        private readonly DateTime thisDay = DateTime.Now;
        #endregion
        [Obsolete]
        public PasswordsForm()
        {
            InitializeComponent();
        }

        private async void PasswordsForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            FullList();
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
        #region Загрузка БД
        private async void FullList()
        {
            dataGridViewPasswords.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_passwords.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[3]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_passwords.site}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_passwords.login}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_passwords.pass}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewPasswords.Rows.Add(s);
                }
                dataGridViewPasswords.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxUI.Show($"{ex.Message}", $"{ex.Source}", "Error");
            }
            finally
            {
                sqlReader?.Close();
            }
        }
        #endregion
        #region Назад
        [Obsolete]
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (DataUsers.GroupUser == "ADMIN")
            {
                Form fMain = new MainAdminForm();
                fMain.Show();
                fMain.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                Hide();
            }
            else
            {
                Form fMain = new MainWorkerForm();
                fMain.Show();
                fMain.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                Hide();
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        #endregion
        #region Обновить
        private void ExpUIButtonRefresh_Click(object sender, EventArgs e)
        {
            FullList();
        }
        #endregion
        #region Сохранить
        private async void ExpUIButtonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewPasswords.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewPasswords.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewPasswords.Rows[selectedrowindex];
                string site = Convert.ToString(selectedRow.Cells["ColumnSite"].Value);
                string login = Convert.ToString(selectedRow.Cells["ColumnLogin"].Value);
                string pass = Convert.ToString(selectedRow.Cells["ColumnPass"].Value);
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_passwords.main} SET [{Table_passwords.login}]=@login, [{Table_passwords.pass}]=@pass WHERE [{Table_passwords.site}] = @site", DB);
                _ = commandUpdate.Parameters.AddWithValue("site", site);
                _ = commandUpdate.Parameters.AddWithValue("login", login);
                _ = commandUpdate.Parameters.AddWithValue("pass", pass);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Сохранение прошло успешно!", "Редактирование", "Accept");
                File.AppendAllText(Logs.file, $"[Пароли]{DataUsers.Initials} отредактировал пароль {site} {login}:{pass} ({thisDay:dd.MM.yyyy HH:mm})");
                File.AppendAllText(Logs.file, Environment.NewLine);
            }
        }
        #endregion
        #region Добавить
        private void ExpUIButtonAdd_Click(object sender, EventArgs e)
        {
            Form faddPass = new AddPasswordForm();
            faddPass.Show();
        }
        #endregion
        #region Удалить
        private async void ExpUIButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPasswords.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewPasswords.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewPasswords.Rows[selectedrowindex];
                string site = Convert.ToString(selectedRow.Cells["ColumnSite"].Value);
                string login = Convert.ToString(selectedRow.Cells["ColumnLogin"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_passwords.main} WHERE [{Table_passwords.site}]=@site AND [{Table_passwords.login}]=@login", DB);
                _ = commandDelete.Parameters.AddWithValue("site", site);
                _ = commandDelete.Parameters.AddWithValue("login", login);
                _ = await commandDelete.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Удаление прошло успешно!", "Удаление", "Accept");
                File.AppendAllText(Logs.file, $"[Пароли]{DataUsers.Initials} удалил пароль ({thisDay:dd.MM.yyyy HH:mm})");
                File.AppendAllText(Logs.file, Environment.NewLine);
                FullList();
            }
        }
        #endregion
    }
}