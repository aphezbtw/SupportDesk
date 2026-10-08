using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class MainWorkerForm : Form
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
        private readonly DateTime thisDay = DateTime.Now;
        #endregion
        [Obsolete]
        public MainWorkerForm()
        {
            InitializeComponent();
        }

        private async void MainWorkerForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            labelName.Text = DataUsers.Name + " " + DataUsers.Father;
            comboBoxTypeJob.SelectedItem = "Все работы";
            comboBoxCabinets.SelectedItem = "Все кабинеты";
            LoadingImageAvatar();
            LoadingCabinets();
            LoadingStatus();
            comboBoxRequest.SelectedItem = "Новая";
            LoadingTypeJob();
            LoadingRequests();
        }
        #region Загрузка БД
        private void LoadingRequests()
        {
            SQLiteCommand command = new SQLiteCommand($"SELECT COUNT(*) FROM [{Table_requests.main}] WHERE {Table_requests.executor} = @executor", DB);
            _ = command.Parameters.AddWithValue("executor", DataUsers.Initials);
            object count = command.ExecuteScalar();
            labelAllRequests.Text = $"{count}";

            SQLiteCommand command2 = new SQLiteCommand($"SELECT COUNT(*) FROM [{Table_requests.main}] WHERE {Table_requests.executor} = @executor AND {Table_requests.status} = @status", DB);
            _ = command2.Parameters.AddWithValue("executor", DataUsers.Initials);
            _ = command2.Parameters.AddWithValue("status", "Выполнена");
            object count2 = command2.ExecuteScalar();
            labelRequestReady.Text = $"{count2}";

            SQLiteCommand command3 = new SQLiteCommand($"SELECT COUNT(*) FROM [{Table_requests.main}] WHERE {Table_requests.executor} = @executor AND {Table_requests.status} = @status", DB);
            _ = command3.Parameters.AddWithValue("executor", DataUsers.Initials);
            _ = command3.Parameters.AddWithValue("status", "Новая");
            object count3 = command3.ExecuteScalar();
            SQLiteCommand command4 = new SQLiteCommand($"SELECT COUNT(*) FROM [{Table_requests.main}] WHERE {Table_requests.executor} = @executor AND {Table_requests.status} = @status", DB);
            _ = command4.Parameters.AddWithValue("executor", DataUsers.Initials);
            _ = command4.Parameters.AddWithValue("status", "В работе");
            object count4 = command4.ExecuteScalar();
            labelRequestNew.Text = $"{count3}/{count4}";
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
                    string cabinet = Convert.ToString($"{sqlReader[$"{Table_cabinets.cabinet}"]}");
                    _ = comboBoxCabinets.Items.Add(cabinet);
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
        private async void LoadingStatus()
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_status.main}]", DB);
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string status = Convert.ToString($"{sqlReader[$"{Table_status.status}"]}");
                    _ = comboBoxRequest.Items.Add(status);
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
        private async void LoadingTypeJob()
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_typeJob.main}]", DB);
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string typeJob = Convert.ToString($"{sqlReader[$"{Table_typeJob.typeJob}"]}");
                    _ = comboBoxTypeJob.Items.Add(typeJob);
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
        private void LoadingImageAvatar()
        {
            string image = AvatarUsers.CheckImage(DataUsers.Gender, DataUsers.GroupUser, DataUsers.Image);
            if (image == "Error")
            {
                MessageBoxUI.Show("Изображение профиля изменено/удалено", "Изображение профиля", "Error");
            }
            else
            {
                pictureBox2.ImageLocation = image;
            }
        }
        private async void FullList()
        {
            dataGridViewRequests.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_requests.main}] WHERE {Table_requests.executor} = @executor OR {Table_requests.executor2} = @executor2", DB);
            _ = command.Parameters.AddWithValue("executor", DataUsers.Initials);
            _ = command.Parameters.AddWithValue("executor2", DataUsers.Initials);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[9]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_requests.theDate}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_requests.tema}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_requests.typeProblem}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Table_requests.user}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Table_requests.kabinet}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Table_requests.time}"]}");
                    data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Table_requests.status}"]}");
                    data[data.Count - 1][7] = Convert.ToString($"{sqlReader[$"{Table_requests.executor}"]}");
                    data[data.Count - 1][8] = Convert.ToString($"{sqlReader[$"{Table_requests.executor2}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewRequests.Rows.Add(s);
                }
                dataGridViewRequests.ClearSelection();

                for (int i = 0; i < dataGridViewRequests.RowCount; i++)
                {
                    if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Выполнена")
                    {
                        dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Lime;
                    }
                    else if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "На подтверждении")
                    {
                        dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Yellow;
                    }
                    else if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Отклонена" || dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Не выполнена")
                    {
                        dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridViewRequests["ColumnData", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.White;
                    }
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
        private async void FullListStatus()
        {
            dataGridViewRequests.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_requests.main}] WHERE {Table_requests.executor} = @executor AND {Table_requests.status} = @status OR {Table_requests.executor2} = @executor2 AND {Table_requests.status} = @status", DB);
            _ = command.Parameters.AddWithValue("status", comboBoxRequest.Text);
            _ = command.Parameters.AddWithValue("executor", DataUsers.Initials);
            _ = command.Parameters.AddWithValue("executor2", DataUsers.Initials);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[9]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_requests.theDate}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_requests.tema}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_requests.typeProblem}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Table_requests.user}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Table_requests.kabinet}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Table_requests.time}"]}");
                    data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Table_requests.status}"]}");
                    data[data.Count - 1][7] = Convert.ToString($"{sqlReader[$"{Table_requests.executor}"]}");
                    data[data.Count - 1][8] = Convert.ToString($"{sqlReader[$"{Table_requests.executor2}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewRequests.Rows.Add(s);
                }
                dataGridViewRequests.ClearSelection();
                for (int i = 0; i < dataGridViewRequests.RowCount; i++)
                {
                    if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Выполнена")
                    {
                        dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Lime;
                    }
                    else if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "На подтверждении")
                    {
                        dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Yellow;
                    }
                    else if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Отклонена" || dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Не выполнена")
                    {
                        dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridViewRequests["ColumnData", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.White;
                    }
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
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ExpUIButtonIconMaximaze_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }
        private void ButtonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
        #region Справка
        private void ExpUIButtonIconAbout_Click(object sender, EventArgs e)
        {
            if (DataRequests.IsOpen)
            {
                return;
            }

            Form fAbout = new AboutLicensesForm();
            fAbout.Show();
            DataRequests.IsOpen = true;
        }
        #endregion
        #region Личный кабинет
        [Obsolete]
        private void ExpUIButtonIconDataUser_Click(object sender, EventArgs e)
        {
            Form fDataArea = new UserDataForm();
            fDataArea.Show();
            fDataArea.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        #endregion
        #region Сменить пользователя
        [Obsolete]
        private void ExpUIButtonIconLogout_Click(object sender, EventArgs e)
        {
            DataUsers.GroupUser = "";
            Form fLogin = new LoginForm();
            fLogin.Show();
            fLogin.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        #endregion
        #region Обновить
        private void ExpUIButtonIconRefresh_Click(object sender, EventArgs e)
        {
            if (comboBoxRequest.Text == "Все задачи")
            {
                FullList();
            }
            else
            {
                FullListStatus();
            }

            LoadingRequests();
            comboBoxTypeJob.SelectedItem = "Все работы";
            comboBoxCabinets.SelectedItem = "Все кабинеты";
        }
        #endregion
        #region Фильтр по задачам
        private void ComboBoxRequest_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxRequest.Text == "Все задачи")
            {
                FullList();
            }
            else
            {
                FullListStatus();
            }
        }
        #endregion
        #region Фильтр по типу работы
        private async void ComboBoxTypeJob_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeJob.Text == "Все работы")
            {
                FullList();
            }
            else
            {
                dataGridViewRequests.Rows.Clear();
                SQLiteDataReader sqlReader = null;
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_requests.main}] WHERE {Table_requests.executor} = @executor AND {Table_requests.typeProblem} = @typeProblem", DB);
                _ = command.Parameters.AddWithValue("executor", DataUsers.Initials);
                _ = command.Parameters.AddWithValue("typeProblem", comboBoxTypeJob.Text);
                List<string[]> data = new List<string[]>();
                try
                {
                    sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                    while (await sqlReader.ReadAsync())
                    {
                        data.Add(new string[9]);

                        data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_requests.theDate}"]}");
                        data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_requests.tema}"]}");
                        data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_requests.typeProblem}"]}");
                        data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Table_requests.user}"]}");
                        data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Table_requests.kabinet}"]}");
                        data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Table_requests.time}"]}");
                        data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Table_requests.status}"]}");
                        data[data.Count - 1][7] = Convert.ToString($"{sqlReader[$"{Table_requests.executor}"]}");
                        data[data.Count - 1][8] = Convert.ToString($"{sqlReader[$"{Table_requests.executor2}"]}");
                    }

                    foreach (string[] s in data)
                    {
                        _ = dataGridViewRequests.Rows.Add(s);
                    }
                    dataGridViewRequests.ClearSelection();

                    for (int i = 0; i < dataGridViewRequests.RowCount; i++)
                    {
                        if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Выполнена")
                        {
                            dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Lime;
                        }
                        else if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "На подтверждении")
                        {
                            dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Yellow;
                        }
                        else if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Отклонена" || dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Не выполнена")
                        {
                            dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            dataGridViewRequests["ColumnData", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.White;
                        }
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
        #endregion
        #region Фильтр по кабинету
        private async void ComboBoxCabinets_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCabinets.Text == "Все кабинеты")
            {
                FullList();
            }
            else
            {
                dataGridViewRequests.Rows.Clear();
                SQLiteDataReader sqlReader = null;
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_requests.main}] WHERE {Table_requests.executor} = @executor AND {Table_requests.kabinet} = @cabinet", DB);
                _ = command.Parameters.AddWithValue("executor", DataUsers.Initials);
                _ = command.Parameters.AddWithValue("cabinet", comboBoxCabinets.Text);
                List<string[]> data = new List<string[]>();
                try
                {
                    sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                    while (await sqlReader.ReadAsync())
                    {
                        data.Add(new string[9]);

                        data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_requests.theDate}"]}");
                        data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_requests.tema}"]}");
                        data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_requests.typeProblem}"]}");
                        data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Table_requests.user}"]}");
                        data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Table_requests.kabinet}"]}");
                        data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Table_requests.time}"]}");
                        data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Table_requests.status}"]}");
                        data[data.Count - 1][7] = Convert.ToString($"{sqlReader[$"{Table_requests.executor}"]}");
                        data[data.Count - 1][8] = Convert.ToString($"{sqlReader[$"{Table_requests.executor2}"]}");
                    }

                    foreach (string[] s in data)
                    {
                        _ = dataGridViewRequests.Rows.Add(s);
                    }
                    dataGridViewRequests.ClearSelection();

                    for (int i = 0; i < dataGridViewRequests.RowCount; i++)
                    {
                        if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Выполнена")
                        {
                            dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Lime;
                            dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Lime;
                        }
                        else if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "На подтверждении")
                        {
                            dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Yellow;
                            dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Yellow;
                        }
                        else if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Отклонена" || dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Не выполнена")
                        {
                            dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Red;
                            dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            dataGridViewRequests["ColumnData", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.White;
                            dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.White;
                        }
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
        #endregion
        #region Виджет календаря
        private async void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            string date = monthCalendar.SelectionRange.Start.ToShortDateString();
            dataGridViewRequests.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_requests.main}] WHERE {Table_requests.time} LIKE @date AND {Table_requests.executor} = @executor OR {Table_requests.time} LIKE @date AND {Table_requests.executor2} = @executor2", DB);
            _ = command.Parameters.AddWithValue("executor", DataUsers.Initials);
            _ = command.Parameters.AddWithValue("executor2", DataUsers.Initials);
            _ = command.Parameters.AddWithValue("date", $"%{date}%");
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[9]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Table_requests.theDate}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Table_requests.tema}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Table_requests.typeProblem}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Table_requests.user}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Table_requests.kabinet}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Table_requests.time}"]}");
                    data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Table_requests.status}"]}");
                    data[data.Count - 1][7] = Convert.ToString($"{sqlReader[$"{Table_requests.executor}"]}");
                    data[data.Count - 1][8] = Convert.ToString($"{sqlReader[$"{Table_requests.executor2}"]}");
                }

                foreach (string[] s in data)
                {
                    _ = dataGridViewRequests.Rows.Add(s);
                }
                dataGridViewRequests.ClearSelection();

                for (int i = 0; i < dataGridViewRequests.RowCount; i++)
                {
                    if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Выполнена")
                    {
                        dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Lime;
                        dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Lime;
                    }
                    else if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "На подтверждении")
                    {
                        dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Yellow;
                        dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Yellow;
                    }
                    else if (dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Отклонена" || dataGridViewRequests["ColumnStatus", i].Value.ToString() == "Не выполнена")
                    {
                        dataGridViewRequests["ColumnData", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.Red;
                        dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridViewRequests["ColumnData", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnTema", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnTypeProblem", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnFio", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnKab", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnTime", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnStatus", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnExecutor", i].Style.BackColor = Color.White;
                        dataGridViewRequests["ColumnExecutor2", i].Style.BackColor = Color.White;
                    }
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
        #region Детальное описание задачи
        private async void DataGridViewRequests_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dataGridViewRequests.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridViewRequests.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewRequests.Rows[selectedrowindex];
                    string data = Convert.ToString(selectedRow.Cells["ColumnData"].Value);
                    string user = Convert.ToString(selectedRow.Cells["ColumnFio"].Value);
                    string cabinet = Convert.ToString(selectedRow.Cells["ColumnKab"].Value);
                    string tema = Convert.ToString(selectedRow.Cells["ColumnTema"].Value);
                    SQLiteDataReader sqlReader = null;
                    SQLiteCommand commandInsert = new SQLiteCommand($"SELECT * FROM [{Table_requests.main}] WHERE [{Table_requests.theDate}] = @theDate AND [{Table_requests.tema}]=@tema AND [{Table_requests.user}] = @user AND [{Table_requests.kabinet}] = @cabinet", DB);
                    _ = commandInsert.Parameters.AddWithValue("theDate", data);
                    _ = commandInsert.Parameters.AddWithValue("user", user);
                    _ = commandInsert.Parameters.AddWithValue("tema", tema);
                    _ = commandInsert.Parameters.AddWithValue("cabinet", cabinet);
                    try
                    {
                        sqlReader = (SQLiteDataReader)await commandInsert.ExecuteReaderAsync();
                        while (await sqlReader.ReadAsync())
                        {
                            DataRequests.Kod = Convert.ToString($"{sqlReader["id"]}");
                            DataRequests.Tema = Convert.ToString($"{sqlReader[$"{Table_requests.tema}"]}");
                            DataRequests.TheDate = Convert.ToString($"{sqlReader[$"{Table_requests.theDate}"]}");
                            DataRequests.Type = Convert.ToString($"{sqlReader[$"{Table_requests.typeProblem}"]}");
                            DataRequests.User = Convert.ToString($"{sqlReader[$"{Table_requests.user}"]}");
                            DataRequests.Kabinet = Convert.ToString($"{sqlReader[$"{Table_requests.kabinet}"]}");
                            DataRequests.Time = Convert.ToString($"{sqlReader[$"{Table_requests.time}"]}");
                            DataRequests.Discription = Convert.ToString($"{sqlReader[$"{Table_requests.discription}"]}");
                            DataRequests.Executor = Convert.ToString($"{sqlReader[$"{Table_requests.executor}"]}");
                            DataRequests.Executor2 = Convert.ToString($"{sqlReader[$"{Table_requests.executor2}"]}");
                            DataRequests.NameFile = Convert.ToString($"{sqlReader[$"{Table_requests.nameFile}"]}");
                            DataRequests.PathTo = Convert.ToString($"{sqlReader[$"{Table_requests.pathFile}"]}");
                            if (DataRequests.IsOpen)
                            {
                                return;
                            }

                            Form fDataTicket = new DataTicketForm();
                            fDataTicket.Show();
                            DataRequests.IsOpen = true;
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
        #region Работа с задачей
        private async void DataGridViewRequests_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewRequests.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewRequests.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewRequests.Rows[selectedrowindex];
                string statusCheck = Convert.ToString(selectedRow.Cells["ColumnStatus"].Value);
                string executor2Check = Convert.ToString(selectedRow.Cells["ColumnExecutor2"].Value);
                if (statusCheck == "Новая")
                {
                    if (DataUsers.Initials == executor2Check)
                    {
                        MessageBoxUI.Show("Вы уже являетесь дублером в данной задаче!", "Принять задачу", "Error");
                    }
                    else
                    {
                        selectedRow.Cells["ColumnExecutor"].Value = DataUsers.Initials;
                        selectedRow.Cells["ColumnStatus"].Value = "В работе";
                        string date = Convert.ToString(selectedRow.Cells["ColumnData"].Value);
                        string tema = Convert.ToString(selectedRow.Cells["ColumnTema"].Value);
                        string typeProblem = Convert.ToString(selectedRow.Cells["ColumnTypeProblem"].Value);
                        string user = Convert.ToString(selectedRow.Cells["ColumnFio"].Value);
                        string kab = Convert.ToString(selectedRow.Cells["ColumnKab"].Value);
                        string time = Convert.ToString(selectedRow.Cells["ColumnTime"].Value);
                        string status = Convert.ToString(selectedRow.Cells["ColumnStatus"].Value);
                        string executor = Convert.ToString(selectedRow.Cells["ColumnExecutor"].Value);
                        SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_requests.main} SET [{Table_requests.status}]=@status, [{Table_requests.executor}]=@executor WHERE [{Table_requests.theDate}]=@date AND [{Table_requests.tema}]=@tema AND [{Table_requests.user}]=@user AND [{Table_requests.kabinet}]=@kab", DB);
                        _ = commandUpdate.Parameters.AddWithValue("status", status);
                        _ = commandUpdate.Parameters.AddWithValue("executor", executor);
                        _ = commandUpdate.Parameters.AddWithValue("date", date);
                        _ = commandUpdate.Parameters.AddWithValue("tema", tema);
                        _ = commandUpdate.Parameters.AddWithValue("user", user);
                        _ = commandUpdate.Parameters.AddWithValue("kab", kab);
                        _ = await commandUpdate.ExecuteNonQueryAsync();
                        MessageBoxUI.Show("Задача принята!", "Принять задачу", "Accept");
                        TelegramForm.AcceptRequest(DataUsers.Initials, tema, typeProblem, user, kab, time, status);
                        File.AppendAllText(Logs.file, $"[Задача]{DataUsers.Initials} принял задачу {tema}({thisDay:dd.MM.yyyy HH:mm})");
                        File.AppendAllText(Logs.file, Environment.NewLine);
                        FullListStatus();
                    }
                }
                else if (statusCheck == "В работе")
                {
                    string data = Convert.ToString(selectedRow.Cells["ColumnData"].Value);
                    string tema = Convert.ToString(selectedRow.Cells["ColumnTema"].Value);
                    string type = Convert.ToString(selectedRow.Cells["ColumnTypeProblem"].Value);
                    string user = Convert.ToString(selectedRow.Cells["ColumnFio"].Value);
                    string cabinet = Convert.ToString(selectedRow.Cells["ColumnKab"].Value);
                    SQLiteDataReader sqlReader = null;
                    SQLiteCommand commandInsert = new SQLiteCommand($"SELECT * FROM [{Table_requests.main}] WHERE [{Table_requests.theDate}] = @theDate AND [{Table_requests.tema}] = @tema AND [{Table_requests.typeProblem}] = @type AND [{Table_requests.user}] = @user AND [{Table_requests.kabinet}] = @cabinet", DB);
                    _ = commandInsert.Parameters.AddWithValue("theDate", data);
                    _ = commandInsert.Parameters.AddWithValue("tema", tema);
                    _ = commandInsert.Parameters.AddWithValue("type", type);
                    _ = commandInsert.Parameters.AddWithValue("user", user);
                    _ = commandInsert.Parameters.AddWithValue("cabinet", cabinet);
                    try
                    {
                        sqlReader = (SQLiteDataReader)await commandInsert.ExecuteReaderAsync();
                        while (await sqlReader.ReadAsync())
                        {
                            DataRequests.Kod = Convert.ToString($"{sqlReader["id"]}");
                            DataRequests.Tema = Convert.ToString($"{sqlReader[$"{Table_requests.tema}"]}");
                            DataRequests.TheDate = Convert.ToString($"{sqlReader[$"{Table_requests.theDate}"]}");
                            DataRequests.Type = Convert.ToString($"{sqlReader[$"{Table_requests.typeProblem}"]}");
                            DataRequests.User = Convert.ToString($"{sqlReader[$"{Table_requests.user}"]}");
                            DataRequests.Kabinet = Convert.ToString($"{sqlReader[$"{Table_requests.kabinet}"]}");
                            DataRequests.Time = Convert.ToString($"{sqlReader[$"{Table_requests.time}"]}");
                            DataRequests.Discription = Convert.ToString($"{sqlReader[$"{Table_requests.discription}"]}");
                            DataRequests.Executor = Convert.ToString($"{sqlReader[$"{Table_requests.executor}"]}");
                            DataRequests.NameFile = Convert.ToString($"{sqlReader[$"{Table_requests.nameFile}"]}");
                            DataRequests.PathTo = Convert.ToString($"{sqlReader[$"{Table_requests.pathFile}"]}");
                            Form fSendResult = new ResultRequestForm();
                            fSendResult.Show();
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
        #region Картриджи
        [Obsolete]
        private void ExpUIButtonPrinters_Click(object sender, EventArgs e)
        {
            Form fCartridges = new CartridgesForm();
            fCartridges.Show();
            fCartridges.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        #endregion
        #region Лицензии
        [Obsolete]
        private void ExpUIButtonLicenses_Click(object sender, EventArgs e)
        {
            Form fLicenses = new LicensesForm();
            fLicenses.Show();
            fLicenses.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        #endregion
        #region Инвентаризация
        [Obsolete]
        private void ExpUIButtonInventory_Click(object sender, EventArgs e)
        {
            Form fInventory = new InventoryForm();
            fInventory.Show();
            fInventory.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        #endregion
        #region Пароли
        [Obsolete]
        private void ExpUIButtonPasswords_Click(object sender, EventArgs e)
        {
            Form fPasswords = new PasswordsForm();
            fPasswords.Show();
            fPasswords.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        #endregion
        #region Внешние контакты
        [Obsolete]
        private void ExpUIButtonContacts_Click(object sender, EventArgs e)
        {
            Form fContacts = new ContactsForm();
            fContacts.Show();
            fContacts.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        #endregion
        #region Календарь
        [Obsolete]
        private void ExpUIButtonIconCalendar_Click(object sender, EventArgs e)
        {
            Form fCalendar = new MonthCalendarForm();
            fCalendar.Show();
            fCalendar.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        #endregion
    }
}