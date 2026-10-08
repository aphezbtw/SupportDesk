using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class CartridgesForm : Form
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
        public CartridgesForm()
        {
            InitializeComponent();
        }

        private async void CartridgesForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            FullList();
            dataGridViewCartridges.Sort(dataGridViewCartridges.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }
        #region Загрузка БД
        private async void FullList()
        {
            dataGridViewCartridges.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_cartrigde.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[13]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.cabinet}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.fio}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.namePrinter}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.cartridge}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.date1}"]}");
                    data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.date2}"]}");
                    data[data.Count - 1][7] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.date3}"]}");
                    data[data.Count - 1][8] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.date4}"]}");
                    data[data.Count - 1][9] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.date5}"]}");
                    data[data.Count - 1][10] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.date6}"]}");
                    data[data.Count - 1][11] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.date7}"]}");
                    data[data.Count - 1][12] = Convert.ToString($"{sqlReader[$"{Table_cartrigde.date8}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewCartridges.Rows.Add(s);
                }
                dataGridViewCartridges.ClearSelection();
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
            if (dataGridViewCartridges.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewCartridges.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewCartridges.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ColumnKod"].Value);
                string cabinet = Convert.ToString(selectedRow.Cells["ColumnCabinet"].Value);
                string fio = Convert.ToString(selectedRow.Cells["ColumnFio"].Value);
                string namePrinter = Convert.ToString(selectedRow.Cells["ColumnNamePrinter"].Value);
                string cartridge = Convert.ToString(selectedRow.Cells["ColumnCartridge"].Value);
                string date1 = Convert.ToString(selectedRow.Cells["ColumnDate1"].Value);
                string date2 = Convert.ToString(selectedRow.Cells["ColumnDate2"].Value);
                string date3 = Convert.ToString(selectedRow.Cells["ColumnDate3"].Value);
                string date4 = Convert.ToString(selectedRow.Cells["ColumnDate4"].Value);
                string date5 = Convert.ToString(selectedRow.Cells["ColumnDate5"].Value);
                string date6 = Convert.ToString(selectedRow.Cells["ColumnDate6"].Value);
                string date7 = Convert.ToString(selectedRow.Cells["ColumnDate7"].Value);
                string date8 = Convert.ToString(selectedRow.Cells["ColumnDate8"].Value);
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_cartrigde.main} SET [{Table_cartrigde.cabinet}]=@cabinet, [{Table_cartrigde.fio}]=@fio, [{Table_cartrigde.namePrinter}]=@namePrinter, [{Table_cartrigde.cartridge}]=@cartridge, [{Table_cartrigde.date1}]=@date1, [{Table_cartrigde.date2}]=@date2, [{Table_cartrigde.date3}]=@date3, [{Table_cartrigde.date4}]=@date4, [{Table_cartrigde.date5}]=@date5, [{Table_cartrigde.date6}]=@date6, [{Table_cartrigde.date7}]=@date7, [{Table_cartrigde.date8}]=@date8 WHERE [{Table_cartrigde.id}] = @id", DB);
                _ = commandUpdate.Parameters.AddWithValue("id", id);
                _ = commandUpdate.Parameters.AddWithValue("cabinet", cabinet);
                _ = commandUpdate.Parameters.AddWithValue("fio", fio);
                _ = commandUpdate.Parameters.AddWithValue("namePrinter", namePrinter);
                _ = commandUpdate.Parameters.AddWithValue("cartridge", cartridge);
                _ = commandUpdate.Parameters.AddWithValue("date1", date1); _ = commandUpdate.Parameters.AddWithValue("date6", date6);
                _ = commandUpdate.Parameters.AddWithValue("date2", date2); _ = commandUpdate.Parameters.AddWithValue("date7", date7);
                _ = commandUpdate.Parameters.AddWithValue("date3", date3); _ = commandUpdate.Parameters.AddWithValue("date8", date8);
                _ = commandUpdate.Parameters.AddWithValue("date4", date4);
                _ = commandUpdate.Parameters.AddWithValue("date5", date5);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Сохранение прошло успешно!", "Редактирование", "Accept");
                TelegramForm.ReplaceCartridge(DataUsers.Initials, cabinet, cartridge);
                File.AppendAllText(Logs.file, $"[Картриджи]Заменен картридж {cartridge} в кабинете: {cabinet} ({DataUsers.Initials}) ({thisDay:dd.MM.yyyy HH:mm})");
                File.AppendAllText(Logs.file, Environment.NewLine);
            }
        }
        #endregion
        #region Очистить строку
        private async void ExpUIButtonClear_Click(object sender, EventArgs e)
        {
            if (dataGridViewCartridges.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewCartridges.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewCartridges.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ColumnKod"].Value);
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_cartrigde.main} SET [{Table_cartrigde.date1}]=@date1, [{Table_cartrigde.date2}]=@date2, [{Table_cartrigde.date3}]=@date3, [{Table_cartrigde.date4}]=@date4, [{Table_cartrigde.date5}]=@date5, [{Table_cartrigde.date6}]=@date6, [{Table_cartrigde.date7}]=@date7, [{Table_cartrigde.date8}]=@date8 WHERE [{Table_cartrigde.id}] = @id", DB);
                _ = commandUpdate.Parameters.AddWithValue("id", id);
                _ = commandUpdate.Parameters.AddWithValue("date1", ""); _ = commandUpdate.Parameters.AddWithValue("date6", "");
                _ = commandUpdate.Parameters.AddWithValue("date2", ""); _ = commandUpdate.Parameters.AddWithValue("date7", "");
                _ = commandUpdate.Parameters.AddWithValue("date3", ""); _ = commandUpdate.Parameters.AddWithValue("date8", "");
                _ = commandUpdate.Parameters.AddWithValue("date4", "");
                _ = commandUpdate.Parameters.AddWithValue("date5", "");
                _ = await commandUpdate.ExecuteNonQueryAsync();
            }
            MessageBoxUI.Show("Очистка прошла успешно!", "Очистка", "Accept");
            File.AppendAllText(Logs.file, $"[Картриджи]Очистил строку ({DataUsers.Initials}) ({thisDay:dd.MM.yyyy HH:mm})");
            File.AppendAllText(Logs.file, Environment.NewLine);
            FullList();
        }
        #endregion
        #region Очистить все
        private async void ExpUIButtonClearAll_Click(object sender, EventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_cartrigde.main}]", DB);
            SQLiteDataReader sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
            while (await sqlReader.ReadAsync())
            {
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_cartrigde.main} SET {Table_cartrigde.date1}=@date1, {Table_cartrigde.date2}=@date2, {Table_cartrigde.date3}=@date3, {Table_cartrigde.date4}=@date4, {Table_cartrigde.date5}=@date5, {Table_cartrigde.date6}=@date6, {Table_cartrigde.date7}=@date7, {Table_cartrigde.date8}=@date8", DB);
                _ = commandUpdate.Parameters.AddWithValue("@date1", ""); _ = commandUpdate.Parameters.AddWithValue("@date6", "");
                _ = commandUpdate.Parameters.AddWithValue("@date2", ""); _ = commandUpdate.Parameters.AddWithValue("@date7", "");
                _ = commandUpdate.Parameters.AddWithValue("@date3", ""); _ = commandUpdate.Parameters.AddWithValue("@date8", "");
                _ = commandUpdate.Parameters.AddWithValue("@date4", "");
                _ = commandUpdate.Parameters.AddWithValue("@date5", "");
                _ = await commandUpdate.ExecuteNonQueryAsync();
            }
            MessageBoxUI.Show("Очистка прошла успешно!", "Очистка", "Accept");
            File.AppendAllText(Logs.file, $"[Картриджи]Очистил всю таблицу ({DataUsers.Initials}) ({thisDay:dd.MM.yyyy HH:mm})");
            File.AppendAllText(Logs.file, Environment.NewLine);
            FullList();
        }
        #endregion
        #region Добавить
        private void ExpUIButtonAdd_Click(object sender, EventArgs e)
        {
            Form faddPrinter = new AddPrinterForm();
            faddPrinter.Show();
        }
        #endregion
        #region Удалить
        private async void ExpUIButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCartridges.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewCartridges.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewCartridges.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ColumnKod"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_cartrigde.main} WHERE [{Table_cartrigde.id}]=@id", DB);
                _ = commandDelete.Parameters.AddWithValue("id", id);
                _ = await commandDelete.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Удаление прошло успешно!", "Удаление", "Accept");
                File.AppendAllText(Logs.file, $"[Картриджи]Удалил принтер ({DataUsers.Initials}) ({thisDay:dd.MM.yyyy HH:mm})");
                File.AppendAllText(Logs.file, Environment.NewLine);
                FullList();
            }
        }
        #endregion
    }
}