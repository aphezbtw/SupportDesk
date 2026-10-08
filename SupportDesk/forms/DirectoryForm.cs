using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class DirectoryForm : Form
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
        #endregion
        [Obsolete]
        public DirectoryForm()
        {
            InitializeComponent();
        }

        private async void DirectoryForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            FullListCabinets();
            FullListTypeJob();
            FullListDepart();
            FullListPosition();
            FullListStatus();
            FullListExecutor();
        }
        #region Управление формой
        [Obsolete]
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Form fMain = new MainAdminForm();
            fMain.Show();
            fMain.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        private void FormControl(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        #endregion
        #region Подгрузка БД
        private async void FullListCabinets()
        {
            dataGridViewLicenses.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_cabinets.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_cabinets.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_cabinets.cabinet}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewLicenses.Rows.Add(s);
                }
                dataGridViewLicenses.ClearSelection();
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
        private async void FullListTypeJob()
        {
            dataGridViewTypeJob.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_typeJob.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_typeJob.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_typeJob.typeJob}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewTypeJob.Rows.Add(s);
                }
                dataGridViewTypeJob.ClearSelection();
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
            dataGridViewDepart.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_depart.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_depart.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_depart.depart}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewDepart.Rows.Add(s);
                }
                dataGridViewDepart.ClearSelection();
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
        private async void FullListPosition()
        {
            dataGridViewPosition.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_postiton.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_postiton.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_postiton.position}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewPosition.Rows.Add(s);
                }
                dataGridViewPosition.ClearSelection();
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
        private async void FullListStatus()
        {
            dataGridViewStatus.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_status.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_status.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_status.status}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewStatus.Rows.Add(s);
                }
                dataGridViewStatus.ClearSelection();
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
        private async void FullListExecutor()
        {
            dataGridViewExecutor.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_executor.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_executor.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_executor.initials}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewExecutor.Rows.Add(s);
                }
                dataGridViewExecutor.ClearSelection();
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
        #region Кабинет
        private async void Button24_Click(object sender, EventArgs e)
        {
            SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_cabinets.main}", DB);
            _ = await commandDelete.ExecuteNonQueryAsync();
            TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу кабинетов");
            FullListCabinets();
        }
        private void ButtonRefreshData_Click(object sender, EventArgs e)
        {
            FullListCabinets();
        }
        private async void ButtonEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewLicenses.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewLicenses.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewLicenses.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ColumnKod"].Value);
                string cabinet = Convert.ToString(selectedRow.Cells["ColumnCabinet"].Value);
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_cabinets.main} SET [{Table_cabinets.cabinet}]=@cabinet WHERE [{Table_cabinets.id}] = @id", DB);
                _ = commandUpdate.Parameters.AddWithValue("id", id);
                _ = commandUpdate.Parameters.AddWithValue("cabinet", cabinet);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                FullListCabinets();
            }
        }
        private async void Button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text == "")
            {
                return;
            }
            else
            {
                SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_cabinets.main} ({Table_cabinets.cabinet}) VALUES (@cabinet)", DB);
                _ = commandInsert.Parameters.AddWithValue("cabinet", text);
                _ = await commandInsert.ExecuteNonQueryAsync();
                FullListCabinets();
                textBox1.Text = "";
            }
        }
        private async void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewLicenses.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewLicenses.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewLicenses.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ColumnKod"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_cabinets.main} WHERE [{Table_cabinets.id}]=@id", DB);
                _ = commandDelete.Parameters.AddWithValue("id", id);
                _ = await commandDelete.ExecuteNonQueryAsync();
                FullListCabinets();
            }
        }
        #endregion
        #region Тип проблемы
        private async void Button25_Click(object sender, EventArgs e)
        {
            SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_typeJob.main}", DB);
            _ = await commandDelete.ExecuteNonQueryAsync();
            TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу типов работы");
            FullListTypeJob();
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            FullListTypeJob();
        }
        private async void Button6_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypeJob.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewTypeJob.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewTypeJob.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn1"].Value);
                string typeJob = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn2"].Value);
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_typeJob.main} SET [{Table_typeJob.typeJob}]=@typeJob WHERE [{Table_typeJob.id}] = @id", DB);
                _ = commandUpdate.Parameters.AddWithValue("id", id);
                _ = commandUpdate.Parameters.AddWithValue("typeJob", typeJob);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                FullListTypeJob();
            }
        }
        private async void Button5_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (text == "")
            {
                return;
            }
            else
            {
                SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_typeJob.main} ({Table_typeJob.typeJob}) VALUES (@typeJob)", DB);
                _ = commandInsert.Parameters.AddWithValue("typeJob", text);
                _ = await commandInsert.ExecuteNonQueryAsync();
                FullListTypeJob();
                textBox2.Text = "";
            }
        }
        private async void Button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypeJob.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewTypeJob.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewTypeJob.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn1"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_typeJob.main} WHERE [{Table_typeJob.id}]=@id", DB);
                _ = commandDelete.Parameters.AddWithValue("id", id);
                _ = await commandDelete.ExecuteNonQueryAsync();
                FullListTypeJob();
            }
        }
        #endregion
        #region Отдел
        private async void Button26_Click(object sender, EventArgs e)
        {
            SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_depart.main}", DB);
            _ = await commandDelete.ExecuteNonQueryAsync();
            TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу отделов");
            FullListDepart();
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            FullListDepart();
        }
        private async void Button10_Click(object sender, EventArgs e)
        {
            if (dataGridViewDepart.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewDepart.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewDepart.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn3"].Value);
                string depart = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn4"].Value);
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_depart.main} SET [{Table_depart.depart}]=@depart WHERE [{Table_depart.id}] = @id", DB);
                _ = commandUpdate.Parameters.AddWithValue("id", id);
                _ = commandUpdate.Parameters.AddWithValue("depart", depart);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                FullListDepart();
            }
        }
        private async void Button9_Click(object sender, EventArgs e)
        {
            string text = textBox3.Text;
            if (text == "")
            {
                return;
            }
            else
            {
                SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_depart.main} ({Table_depart.depart}) VALUES (@depart)", DB);
                _ = commandInsert.Parameters.AddWithValue("depart", text);
                _ = await commandInsert.ExecuteNonQueryAsync();
                FullListDepart();
                textBox3.Text = "";
            }
        }
        private async void Button8_Click(object sender, EventArgs e)
        {
            if (dataGridViewDepart.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewDepart.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewDepart.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn3"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_depart.main} WHERE [{Table_depart.id}]=@id", DB);
                _ = commandDelete.Parameters.AddWithValue("id", id);
                _ = await commandDelete.ExecuteNonQueryAsync();
                FullListDepart();
            }
        }
        #endregion
        #region Должность
        private async void Button29_Click(object sender, EventArgs e)
        {
            SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_postiton.main}", DB);
            _ = await commandDelete.ExecuteNonQueryAsync();
            TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу должностей");
            FullListPosition();
        }
        private void Button15_Click(object sender, EventArgs e)
        {
            FullListPosition();
        }
        private async void Button14_Click(object sender, EventArgs e)
        {
            if (dataGridViewPosition.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewDepart.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewDepart.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn5"].Value);
                string position = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn6"].Value);
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_postiton.main} SET [{Table_postiton.position}]=@position WHERE [{Table_postiton.id}] = @id", DB);
                _ = commandUpdate.Parameters.AddWithValue("id", id);
                _ = commandUpdate.Parameters.AddWithValue("position", position);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                FullListPosition();
            }
        }
        private async void Button13_Click(object sender, EventArgs e)
        {
            string text = textBox4.Text;
            if (text == "")
            {
                return;
            }
            else
            {
                SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_postiton.main} ({Table_postiton.position}) VALUES (@position)", DB);
                _ = commandInsert.Parameters.AddWithValue("position", text);
                _ = await commandInsert.ExecuteNonQueryAsync();
                FullListPosition();
                textBox4.Text = "";
            }
        }
        private async void Button12_Click(object sender, EventArgs e)
        {
            if (dataGridViewPosition.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewPosition.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewPosition.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn5"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_postiton.main} WHERE [{Table_postiton.id}]=@id", DB);
                _ = commandDelete.Parameters.AddWithValue("id", id);
                _ = await commandDelete.ExecuteNonQueryAsync();
                FullListPosition();
            }
        }
        #endregion
        #region Статус
        private async void Button28_Click(object sender, EventArgs e)
        {
            SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_status.main}", DB);
            _ = await commandDelete.ExecuteNonQueryAsync();
            TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу статуса задач");
            FullListStatus();
        }
        private void Button19_Click(object sender, EventArgs e)
        {
            FullListStatus();
        }
        private async void Button18_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewDepart.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewDepart.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn7"].Value);
                string status = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn8"].Value);
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_status.main} SET [{Table_status.status}]=@status WHERE [{Table_status.id}] = @id", DB);
                _ = commandUpdate.Parameters.AddWithValue("id", id);
                _ = commandUpdate.Parameters.AddWithValue("status", status);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                FullListStatus();
            }
        }
        private async void Button17_Click(object sender, EventArgs e)
        {
            string text = textBox5.Text;
            if (text == "")
            {
                return;
            }
            else
            {
                SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_status.main} ({Table_status.status}) VALUES (@status)", DB);
                _ = commandInsert.Parameters.AddWithValue("status", text);
                _ = await commandInsert.ExecuteNonQueryAsync();
                FullListStatus();
                textBox5.Text = "";
            }
        }
        private async void Button16_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewStatus.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewStatus.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn7"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_status.main} WHERE [{Table_status.id}]=@id", DB);
                _ = commandDelete.Parameters.AddWithValue("id", id);
                _ = await commandDelete.ExecuteNonQueryAsync();
                FullListStatus();
            }
        }
        #endregion
        #region Исполнитель
        private async void Button27_Click(object sender, EventArgs e)
        {
            SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_executor.main}", DB);
            _ = await commandDelete.ExecuteNonQueryAsync();
            TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу исполнителей");
            FullListExecutor();
        }
        private void Button23_Click(object sender, EventArgs e)
        {
            FullListExecutor();
        }
        private async void Button22_Click(object sender, EventArgs e)
        {
            if (dataGridViewExecutor.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewDepart.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewDepart.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn9"].Value);
                string executor = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn10"].Value);
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_executor.main} SET [{Table_executor.initials}]=@executor WHERE [{Table_executor.id}] = @id", DB);
                _ = commandUpdate.Parameters.AddWithValue("id", id);
                _ = commandUpdate.Parameters.AddWithValue("executor", executor);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                FullListExecutor();
            }
        }
        private async void Button21_Click(object sender, EventArgs e)
        {
            string text = textBox6.Text;
            if (text == "")
            {
                return;
            }
            else
            {
                if (dataGridViewExecutor.Rows.Count >= Database.limitExecutors)
                {
                    MessageBoxUI.Show("Достигнуто максимальное количество исполнителей!", "Ошибка добавления", "Error");
                }
                else
                {
                    SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_executor.main} ({Table_executor.initials}) VALUES (@initials)", DB);
                    _ = commandInsert.Parameters.AddWithValue("initials", text);
                    _ = await commandInsert.ExecuteNonQueryAsync();
                    FullListExecutor();
                    textBox6.Text = "";
                }
            }
        }
        private async void Button20_Click(object sender, EventArgs e)
        {
            if (dataGridViewExecutor.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewExecutor.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewExecutor.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn9"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_executor.main} WHERE [{Table_executor.id}]=@id", DB);
                _ = commandDelete.Parameters.AddWithValue("id", id);
                _ = await commandDelete.ExecuteNonQueryAsync();
                FullListExecutor();
            }
        }
        #endregion
    }
}