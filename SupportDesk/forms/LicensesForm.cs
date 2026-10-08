using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class LicensesForm : Form
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
        public LicensesForm()
        {
            InitializeComponent();
        }

        private async void LicensesForm_Load(object sender, EventArgs e)
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
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_licenses.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[3]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_licenses.cabinet}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_licenses.software}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_licenses.check}"]}");
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
        #region Добавить
        private void ExpUIButtonAdd_Click(object sender, EventArgs e)
        {
            Form faddLic = new AddLicensesForm();
            faddLic.Show();
        }
        #endregion
        #region Удалить
        private async void ExpUIButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewLicenses.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewLicenses.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewLicenses.Rows[selectedrowindex];
                string cabinet = Convert.ToString(selectedRow.Cells["ColumnCabinet"].Value);
                string software = Convert.ToString(selectedRow.Cells["ColumnSoftware"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_licenses.main} WHERE [{Table_licenses.cabinet}]=@cabinet AND [{Table_licenses.software}]=@software", DB);
                _ = commandDelete.Parameters.AddWithValue("cabinet", cabinet);
                _ = commandDelete.Parameters.AddWithValue("software", software);
                _ = await commandDelete.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Удаление прошло успешно!", "Удаление", "Accept");
                FullList();
                comboBoxRequest.SelectedItem = "Все кабинеты";
                File.AppendAllText(Logs.file, $"[Лицензии] {DataUsers.Initials} удалил лицензию ({thisDay:dd.MM.yyyy HH:mm})");
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
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_licenses.main}] WHERE {Table_licenses.cabinet} = @cabinet", DB);
                _ = command.Parameters.AddWithValue("cabinet", cabinet);
                List<string[]> data = new List<string[]>();
                try
                {
                    sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                    while (await sqlReader.ReadAsync())
                    {
                        data.Add(new string[3]);

                        data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_licenses.cabinet}"]}");
                        data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_licenses.software}"]}");
                        data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_licenses.check}"]}");
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
        #region Открыть файл лицензии
        private async void DataGridViewLicenses_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewLicenses.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewLicenses.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewLicenses.Rows[selectedrowindex];
                string cabinet = Convert.ToString(selectedRow.Cells["ColumnCabinet"].Value);
                string software = Convert.ToString(selectedRow.Cells["ColumnSoftware"].Value);
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_licenses.main}] WHERE {Table_licenses.cabinet} = @cabinet AND {Table_licenses.software} = @software", DB);
                _ = command.Parameters.AddWithValue("cabinet", cabinet);
                _ = command.Parameters.AddWithValue("software", software);
                SQLiteDataReader sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string pdf = (string)sqlReader[$"{Table_licenses.pdf}"];
                    _ = Process.Start($"{pdf}");
                }
            }
        }
        #endregion
    }
}