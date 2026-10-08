using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class InventoryForm : Form
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
        public InventoryForm()
        {
            InitializeComponent();
        }

        private async void InventoryForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            FullList();
            comboBoxRequest.SelectedItem = "Все кабинеты";
            LoadingCabinets();
        }
        #region Загрузка БД
        private async void FullList()
        {
            dataGridViewLicenses.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_inventory.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_inventory.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_inventory.name}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_inventory.purchaseDate}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Table_inventory.invNum}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Table_inventory.amount}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Table_inventory.location}"]}");
                    data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Table_inventory.factLocation}"]}");
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
        private async void LoadingCabinets()
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_cabinets.main}]", DB);
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string licenses = Convert.ToString($"{sqlReader[$"{Table_cabinets.cabinet}"]}");
                    _ = comboBoxRequest.Items.Add(licenses);
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
            comboBoxRequest.SelectedItem = "Все кабинеты";
            FullList();
        }
        #endregion
        #region Сохранить
        private async void ExpUIButtonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewLicenses.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewLicenses.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewLicenses.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ColumnKod"].Value);
                string name = Convert.ToString(selectedRow.Cells["ColumnName"].Value);
                string purchaseDate = Convert.ToString(selectedRow.Cells["ColumnDate"].Value);
                string invNum = Convert.ToString(selectedRow.Cells["ColumnInvNum"].Value);
                string amount = Convert.ToString(selectedRow.Cells["ColumnAmount"].Value);
                string location = Convert.ToString(selectedRow.Cells["ColumnLocation"].Value);
                string factLocation = Convert.ToString(selectedRow.Cells["ColumnFactLocation"].Value);
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_inventory.main} SET [{Table_inventory.name}]=@name, [{Table_inventory.purchaseDate}]=@purchaseDate, [{Table_inventory.invNum}]=@invNum, [{Table_inventory.amount}]=@amount, [{Table_inventory.location}]=@location, [{Table_inventory.factLocation}]=@factLocation WHERE [{Table_inventory.id}] = @id", DB);
                _ = commandUpdate.Parameters.AddWithValue("id", id); _ = commandUpdate.Parameters.AddWithValue("name", name);
                _ = commandUpdate.Parameters.AddWithValue("purchaseDate", purchaseDate); _ = commandUpdate.Parameters.AddWithValue("invNum", invNum);
                _ = commandUpdate.Parameters.AddWithValue("amount", amount); _ = commandUpdate.Parameters.AddWithValue("location", location);
                _ = commandUpdate.Parameters.AddWithValue("factLocation", factLocation);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Сохранение прошло успешно!", "Редактирование", "Accept");
                File.AppendAllText(Logs.file, $"[Инвентаризация] {DataUsers.Initials} отредактировал оборудование {name} {amount}шт. {location} ({thisDay:dd.MM.yyyy HH:mm})");
                File.AppendAllText(Logs.file, Environment.NewLine);
            }
        }
        #endregion
        #region Добавить
        private void ExpUIButtonAdd_Click(object sender, EventArgs e)
        {
            Form faddInv = new AddInvForm();
            faddInv.Show();
        }
        #endregion
        #region Удалить
        private async void ExpUIButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewLicenses.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewLicenses.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewLicenses.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ColumnKod"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_inventory.main} WHERE [{Table_inventory.id}]=@id", DB);
                _ = commandDelete.Parameters.AddWithValue("id", id);
                _ = await commandDelete.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Удаление прошло успешно!", "Удаление", "Accept");
                comboBoxRequest.SelectedItem = "Все кабинеты";
                FullList();
                File.AppendAllText(Logs.file, $"[Инвентаризация] {DataUsers.Initials} удалил оборудование ({thisDay:dd.MM.yyyy HH:mm})");
                File.AppendAllText(Logs.file, Environment.NewLine);
            }
        }
        #endregion
        #region Фильтр
        private async void ComboBoxRequest_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxRequest.Text == "Все кабинеты")
            {
                FullList();
            }
            else
            {
                string cabinet = comboBoxRequest.Text;
                dataGridViewLicenses.Rows.Clear();
                SQLiteDataReader sqlReader = null;
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_inventory.main}] WHERE {Table_inventory.location} = @cabinet", DB);
                _ = command.Parameters.AddWithValue("cabinet", cabinet);
                List<string[]> data = new List<string[]>();
                try
                {
                    sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                    while (await sqlReader.ReadAsync())
                    {
                        data.Add(new string[7]);

                        data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_inventory.id}"]}");
                        data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_inventory.name}"]}");
                        data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_inventory.purchaseDate}"]}");
                        data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Table_inventory.invNum}"]}");
                        data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Table_inventory.amount}"]}");
                        data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Table_inventory.location}"]}");
                        data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Table_inventory.factLocation}"]}");
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
        }
        #endregion
    }
}