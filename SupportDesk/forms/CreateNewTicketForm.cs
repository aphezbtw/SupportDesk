using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class CreateNewTicketForm : Form
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
        public CreateNewTicketForm()
        {
            InitializeComponent();
        }

        private async void CreateNewTicketForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            LoadingCabinets();
            LoadingTypeJob();
            LoadingExecutors();
        }
        #region Загрузка БД
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
                    _ = comboBoxKab.Items.Add(cabinet);
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
                    _ = comboBoxType.Items.Add(typeJob);
                }
            }
            catch (Exception ex)
            {
                MessageBoxUI.Show($"{ex.Message}", $"{ex.Message}", "Error");
            }
            finally
            {
                sqlReader?.Close();
            }
        }
        private async void LoadingExecutors()
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_executor.main}]", DB);
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string executor = Convert.ToString($"{sqlReader[$"{Table_executor.initials}"]}");
                    _ = comboBoxExecutor.Items.Add(executor);
                    comboBoxExecutor.SelectedItem = "Не назначен";
                }
            }
            catch (Exception ex)
            {
                MessageBoxUI.Show($"{ex.Message}", $"{ex.Message}", "Error");
            }
            finally
            {
                sqlReader?.Close();
            }
        }
        #endregion
        #region Управление формой
        [Obsolete]
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (DataUsers.GroupUser == "ADMIN")
            {
                Form fMain = new MainAdminForm();
                fMain.Show();
                fMain.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
                Hide();
            }
            else
            {
                Form fMain = new MainUserForm();
                fMain.Show();
                fMain.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
                Hide();
            }
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
        private void CheckTextBox(object sender, EventArgs e)
        {
            if (textBoxTema.Text == "" || comboBoxType.Text == "" || comboBoxKab.Text == "" ||
            textBoxDiscription.Text == "" || textBoxTime1.Text == "" || textBoxTime2.Text == "" ||
            textBoxTime3.Text == "" || textBoxTime4.Text == "")
            {
                buttonSendRequest.Enabled = false;
                return;
            }
            else
            {
                buttonSendRequest.Enabled = true;
            }
        }
        private void CheckKeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Отправить задачу
        [Obsolete]
        private async void ButtonSendRequest_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxTime1.Text) < 8 || Convert.ToInt32(textBoxTime1.Text) > 18 ||
                Convert.ToInt32(textBoxTime2.Text) < 0 || Convert.ToInt32(textBoxTime2.Text) > 59 ||
                Convert.ToInt32(textBoxTime3.Text) < 8 || Convert.ToInt32(textBoxTime3.Text) > 18 ||
                Convert.ToInt32(textBoxTime4.Text) < 0 || Convert.ToInt32(textBoxTime4.Text) > 59)
            {
                MessageBoxUI.Show("Рабочий день информационного центра с 8 утра до 18:00 вечера!", "Неправильное время", "Error");
                return;
            }
            string time1 = $"{textBoxTime1.Text}:{textBoxTime2.Text}";
            string time2 = $"{textBoxTime3.Text}:{textBoxTime4.Text}";
            if (time1 == time2)
            {
                MessageBoxUI.Show("Интервал времени должен составлять не меньше 1 минуты!", "Неправильное время", "Error");
                return;
            }
            DateTime thisDay = DateTime.Now;
            string timeWork = $"{time1} - {time2}";
            string date = dateTimePicker.Text;
            string time = date + "/" + timeWork;
            string user = DataUsers.Family + " " + DataUsers.Name + " " + DataUsers.Father;
            SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_requests.main} ({Table_requests.theDate}, {Table_requests.tema}, {Table_requests.typeProblem}, {Table_requests.user}, {Table_requests.kabinet}, {Table_requests.discription}, {Table_requests.time}, {Table_requests.status}, {Table_requests.executor}, {Table_requests.executor2}, {Table_requests.nameFile}, {Table_requests.pathFile}) " +
                $"VALUES (@theDate, @tema, @typeProblem, @user, @kabinet, @discription, @time, @status, @executor, @executor2, @nameFile, @pathFile)", DB);
            _ = commandInsert.Parameters.AddWithValue("theDate", thisDay.ToString("dd.MM.yyyy HH:mm")); _ = commandInsert.Parameters.AddWithValue("status", "Новая");
            _ = commandInsert.Parameters.AddWithValue("tema", textBoxTema.Text); _ = commandInsert.Parameters.AddWithValue("executor", comboBoxExecutor.Text);
            _ = commandInsert.Parameters.AddWithValue("typeProblem", comboBoxType.Text); _ = commandInsert.Parameters.AddWithValue("nameFile", DataRequests.NameFile);
            _ = commandInsert.Parameters.AddWithValue("user", user); _ = commandInsert.Parameters.AddWithValue("pathFile", DataRequests.PathTo);
            _ = commandInsert.Parameters.AddWithValue("kabinet", comboBoxKab.Text); _ = commandInsert.Parameters.AddWithValue("executor2", "Не назначен");
            _ = commandInsert.Parameters.AddWithValue("discription", textBoxDiscription.Text);
            _ = commandInsert.Parameters.AddWithValue("time", time);
            _ = await commandInsert.ExecuteNonQueryAsync();
            MessageBoxUI.Show("Задача успешно добавлена!", "Новая задача", "Accept");
            TelegramForm.EnterMessasge(thisDay.ToString("dd.MM.yyyy HH:mm"), textBoxTema.Text, comboBoxType.Text, user, comboBoxKab.Text, textBoxDiscription.Text, time);
            File.AppendAllText(Logs.file, $"[Создание задачи]{DataUsers.Initials} создал заявку {textBoxDiscription.Text} ({thisDay:dd.MM.yyyy HH:mm})");
            File.AppendAllText(Logs.file, Environment.NewLine);
            if (DataUsers.GroupUser == "ADMIN")
            {
                Form fMain = new MainAdminForm();
                fMain.Show();
                fMain.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
                Hide();
            }
            else
            {
                Form fMain = new MainUserForm();
                fMain.Show();
                fMain.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
                Hide();
            }
        }
        #endregion
        #region Прикрепить документ
        private void ButtonLoadDocs_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Word files (*.doc, *.docx)|*.doc;*.docx" +
            "|Excel files (*.xls, *.xlsx)|*.xls;*.xlsx" +
            "|PDF files (*.pdf)|*.pdf" +
            "|Photoshop files (*.psd)|*.psd" +
            "|Image files (*.png, *.jpg)|*.png;*.jpg" +
            "|Music files (*.mp3)|*.mp3" +
            "|Video files (*.mp4, *.mov, *.avi)|*.mp4;*.mov;*.avi";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string path = openFileDialog1.FileName;
            string pathTo = "docs\\" + Path.GetFileName(path);
            string nameFile = Path.GetFileNameWithoutExtension(path);
            string extension = Path.GetExtension(path);
            DataRequests.PathFile = path;
            DataRequests.NameFile = nameFile;
            DataRequests.PathTo = pathTo;
            expUIButtonFile.Visible = true;
            expUIButtonFile.Text = nameFile;
            expUIButtonFile.Image = Image.FromFile(FileImage.PathFile(extension));
            File.Copy(path, pathTo, true);
        }
        #endregion
        #region Открыть файл
        private void ExpUIButtonFile_Click(object sender, EventArgs e)
        {
            _ = Process.Start(DataRequests.PathTo);
        }
        #endregion
    }
}