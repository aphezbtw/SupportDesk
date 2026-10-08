using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class UsersForm : Form
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
        public UsersForm()
        {
            InitializeComponent();
        }

        private async void UsersForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            comboBoxDepart.SelectedItem = "Все пользователи";
            LoadingDeparts();
        }
        #region Загрузка БД
        private async void FullList()
        {
            dataGridViewUsers.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_users.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[11]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_users.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_users.family}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_users.name}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Table_users.father}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Table_users.number}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Table_users.email}"]}");
                    data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Table_users.depart}"]}");
                    data[data.Count - 1][7] = Convert.ToString($"{sqlReader[$"{Table_users.position}"]}");
                    data[data.Count - 1][8] = Convert.ToString($"{sqlReader[$"{Table_users.login}"]}");
                    data[data.Count - 1][9] = Convert.ToString($"{sqlReader[$"{Table_users.pass}"]}");
                    data[data.Count - 1][10] = Convert.ToString($"{sqlReader[$"{Table_users.groupUser}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewUsers.Rows.Add(s);
                }
                dataGridViewUsers.ClearSelection();
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
        private async void FullListDepart()
        {
            dataGridViewUsers.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_users.main}] WHERE {Table_users.depart} = @depart", DB);
            _ = command.Parameters.AddWithValue("depart", comboBoxDepart.Text);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[11]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_users.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_users.family}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_users.name}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Table_users.father}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Table_users.number}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Table_users.email}"]}");
                    data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Table_users.depart}"]}");
                    data[data.Count - 1][7] = Convert.ToString($"{sqlReader[$"{Table_users.position}"]}");
                    data[data.Count - 1][8] = Convert.ToString($"{sqlReader[$"{Table_users.login}"]}");
                    data[data.Count - 1][9] = Convert.ToString($"{sqlReader[$"{Table_users.pass}"]}");
                    data[data.Count - 1][10] = Convert.ToString($"{sqlReader[$"{Table_users.groupUser}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewUsers.Rows.Add(s);
                }
                dataGridViewUsers.ClearSelection();
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

        private async void LoadingDeparts()
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_depart.main}]", DB);
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string depart = Convert.ToString($"{sqlReader[$"{Table_depart.depart}"]}");
                    _ = comboBoxDepart.Items.Add(depart);
                }
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
        #region Выход
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
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        #endregion
        #region Обновить
        private void ExpUIButtonRefresh_Click(object sender, EventArgs e)
        {
            if (comboBoxDepart.Text == "Все пользователи")
            {
                FullList();
                comboBoxDepart.SelectedItem = "Все пользователи";
            }
            else
            {
                FullListDepart();
            }
        }
        #endregion
        #region Сохранить
        private async void ExpUIButtonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewUsers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewUsers.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ColumnKod"].Value);
                string family = Convert.ToString(selectedRow.Cells["ColumnFamily"].Value);
                string name = Convert.ToString(selectedRow.Cells["ColumnName"].Value);
                string father = Convert.ToString(selectedRow.Cells["ColumnFather"].Value);
                string groupUser = Convert.ToString(selectedRow.Cells["ColumnGroup"].Value);
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_users.main} SET [{Table_users.groupUser}]=@groupUser WHERE [{Table_users.id}] = @id", DB);
                _ = commandUpdate.Parameters.AddWithValue("id", id);
                _ = commandUpdate.Parameters.AddWithValue("groupUser", groupUser);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Сохранение прошло успешно!", "Редактирование пользователя", "Accept");
                File.AppendAllText(Logs.file, $"[Пользователи]Отредактирован пользователь {family} {name} {father} ({DataUsers.Initials}) ({thisDay:dd.MM.yyyy HH:mm})");
                File.AppendAllText(Logs.file, Environment.NewLine);
            }
        }
        #endregion
        #region Добавить
        [Obsolete]
        private void ExpUIButtonAdd_Click(object sender, EventArgs e)
        {
            Form fReg = new RegisterForm();
            fReg.Show();
        }
        #endregion
        #region Удалить
        private async void ExpUIButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewUsers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewUsers.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ColumnKod"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_users.main} WHERE [{Table_users.id}]=@id", DB);
                _ = commandDelete.Parameters.AddWithValue("id", id);
                _ = await commandDelete.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Удаление прошло успешно!", "Удаление пользователя", "Accept");
                File.AppendAllText(Logs.file, $"[Пользователи]Удален пользователь ({DataUsers.Initials}) ({thisDay:dd.MM.yyyy HH:mm})");
                File.AppendAllText(Logs.file, Environment.NewLine);
                comboBoxDepart.SelectedItem = "Все пользователи";
                FullList();
            }
        }
        #endregion
        #region Восстановление доступа
        private void ExpUIButtonMail_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewUsers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewUsers.Rows[selectedrowindex];
                string name = Convert.ToString(selectedRow.Cells["ColumnName"].Value);
                string father = Convert.ToString(selectedRow.Cells["ColumnFather"].Value);
                string emailUser = Convert.ToString(selectedRow.Cells["ColumnEmail"].Value);
                string login = Convert.ToString(selectedRow.Cells["ColumnLogin"].Value);
                string pass = Convert.ToString(selectedRow.Cells["ColumnPass"].Value);
                Email.CheckEmail(emailUser, name, father, login, pass);
                MessageBoxUI.Show("Отправлено письмо о восстановлении доступа к программе!", "Восстановление доступа", "Accept");
                File.AppendAllText(Logs.file, $"[Пользователи]Отправлено письмо доступа {name} {father} (ЗАБЫЛИ ПАРОЛЬ)");
                File.AppendAllText(Logs.file, Environment.NewLine);
            }
        }
        #endregion
        #region Фильтр
        private void ComboBoxDepart_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxDepart.Text == "Все пользователи")
            {
                FullList();
            }
            else
            {
                FullListDepart();
            }
        }
        #endregion
        #region Карточка сотрудника
        [Obsolete]
        private async void DataGridViewUsers_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dataGridViewUsers.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridViewUsers.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewUsers.Rows[selectedrowindex];
                    string id = Convert.ToString(selectedRow.Cells["ColumnKod"].Value);
                    SQLiteDataReader sqlReader = null;
                    SQLiteCommand commandInsert = new SQLiteCommand($"SELECT * FROM [{Table_users.main}] WHERE [{Table_users.id}] = @id", DB);
                    _ = commandInsert.Parameters.AddWithValue("id", id);
                    try
                    {
                        sqlReader = (SQLiteDataReader)await commandInsert.ExecuteReaderAsync();
                        while (await sqlReader.ReadAsync())
                        {
                            DataSpecificUser.Family = Convert.ToString($"{sqlReader[$"{Table_users.family}"]}");
                            DataSpecificUser.Name = Convert.ToString($"{sqlReader[$"{Table_users.name}"]}");
                            DataSpecificUser.Father = Convert.ToString($"{sqlReader[$"{Table_users.father}"]}");
                            DataSpecificUser.Number = Convert.ToString($"{sqlReader[$"{Table_users.number}"]}");
                            DataSpecificUser.Email = Convert.ToString($"{sqlReader[$"{Table_users.email}"]}");
                            DataSpecificUser.Depart = Convert.ToString($"{sqlReader[$"{Table_users.depart}"]}");
                            DataSpecificUser.Position = Convert.ToString($"{sqlReader[$"{Table_users.position}"]}");
                            DataSpecificUser.Login = Convert.ToString($"{sqlReader[$"{Table_users.login}"]}");
                            DataSpecificUser.Pass = Convert.ToString($"{sqlReader[$"{Table_users.pass}"]}");
                            DataSpecificUser.Image = Convert.ToString($"{sqlReader[$"{Table_users.image}"]}");
                            DataSpecificUser.CheckLocked = Convert.ToString($"{sqlReader[$"{Table_users.typeAccess}"]}");
                            DataSpecificUser.Gender = Convert.ToString($"{sqlReader[$"{Table_users.gender}"]}");
                            DataSpecificUser.GroupUser = Convert.ToString($"{sqlReader[$"{Table_users.groupUser}"]}");
                            Form fDataSpecificUser = new DataSpecificUserForm();
                            fDataSpecificUser.Show();
                        }
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
            }
        }
        #endregion
    }
}