using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class ContactsForm : Form
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
        private readonly DateTime thisDay = DateTime.Now;
        #endregion
        [Obsolete]
        public ContactsForm()
        {
            InitializeComponent();
        }

        private async void ContactsForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            FullList();
        }
        #region Загрузка БД
        private async void FullList()
        {
            dataGridViewContacts.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_contacts.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[3]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_contacts.company}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_contacts.name}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_contacts.phone}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewContacts.Rows.Add(s);
                }
                dataGridViewContacts.ClearSelection();
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
            if (dataGridViewContacts.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewContacts.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewContacts.Rows[selectedrowindex];
                string company = Convert.ToString(selectedRow.Cells["ColumnCompany"].Value);
                string name = Convert.ToString(selectedRow.Cells["ColumnName"].Value);
                string phone = Convert.ToString(selectedRow.Cells["ColumnPhone"].Value);
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_contacts.main} SET [{Table_contacts.name}]=@name, [{Table_contacts.phone}]=@phone WHERE [{Table_contacts.company}] = @company", DB);
                _ = commandUpdate.Parameters.AddWithValue("company", company);
                _ = commandUpdate.Parameters.AddWithValue("name", name);
                _ = commandUpdate.Parameters.AddWithValue("phone", phone);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Сохранение прошло успешно!", "Редактирование", "Accept");
                File.AppendAllText(Logs.file, $"[Внешние контакты]{DataUsers.Initials} отредактировал внешней контакт {company} ({thisDay:dd.MM.yyyy HH:mm})");
                File.AppendAllText(Logs.file, Environment.NewLine);
            }
        }
        #endregion
        #region Добавить
        private void ExpUIButtonAdd_Click(object sender, EventArgs e)
        {
            Form fAddContact = new AddContactsForm();
            fAddContact.Show();
        }
        #endregion
        #region Удалить
        private async void ExpUIButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewContacts.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewContacts.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewContacts.Rows[selectedrowindex];
                string company = Convert.ToString(selectedRow.Cells["ColumnCompany"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_contacts.main} WHERE [{Table_contacts.company}]=@company", DB);
                _ = commandDelete.Parameters.AddWithValue("company", company);
                _ = await commandDelete.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Удаление прошло успешно!", "Удаление", "Accept");
                File.AppendAllText(Logs.file, $"[Внешние контакты]{DataUsers.Initials} удалил внешний контакт ({thisDay:dd.MM.yyyy HH:mm})");
                File.AppendAllText(Logs.file, Environment.NewLine);
                FullList();
            }
        }
        #endregion
    }
}