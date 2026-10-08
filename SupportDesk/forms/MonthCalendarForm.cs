using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class MonthCalendarForm : Form
    {
        #region Настройки формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        private static readonly Calendar _calendar = new Calendar(Calendar.MaxItem);
        private SQLiteConnection DB;
        private readonly Dictionary<string, string> months = new Dictionary<string, string>()
        {
            {".01.","Январь"},
            {".02.","Февраль"},
            {".03.","Март"},
            {".04.","Апрель"},
            {".05.","Май"},
            {".06.","Июнь"},
            {".07.","Июль"},
            {".08.","Август"},
            {".09.","Сентябрь"},
            {".10.","Октябрь"},
            {".11.","Ноябрь"},
            {".12.","Декабрь"},
        };
        private string myDate;
        private string myYear;
        private int checkItem = 0;

        [Obsolete]
        public MonthCalendarForm()
        {
            InitializeComponent();
        }

        private async void MonthCalendarForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            MonthNow();

            //LoadingCount();
            //LoadingCalendarDB();
        }
        private void MonthNow()
        {
            int month = DateTime.Now.Month;
            string newMonth = "";
            if (month >= 1 && month <= 9)
            {
                newMonth = $".0" + month + '.';
                myDate = newMonth;
            }
            foreach (KeyValuePair<string, string> date in months)
            {
                if (date.Key == myDate)
                {
                    comboBoxMonth.SelectedItem = date.Value;
                }
            }

            int year = DateTime.Now.Year;
            comboBoxYear.Items.Add(year - 1);
            comboBoxYear.Items.Add(year);
            comboBoxYear.Items.Add(year + 1);
            comboBoxYear.SelectedItem = year;
        }
        private void LoadingCount()
        {
            Panel[] allPanels = new Panel[]
            {
                panel1, panel2, panel3, panel4, panel5,
                panel6, panel7, panel8, panel9, panel10,
                panel11, panel12, panel13, panel14, panel15,
                panel16, panel17, panel18, panel19, panel20,
                panel21, panel22, panel23, panel24, panel25,
                panel26, panel27, panel28, panel29, panel30,
                panel31,
            };
            for (int i = 1; i <= 31; i++)
            {
                allPanels[i - 1].Visible = false;
            }
            SQLiteCommand command = new SQLiteCommand($"SELECT COUNT(*) FROM [{Table_requests.main}] " +
                $"WHERE {Table_requests.time} " +
                $"LIKE @myDate", DB);
            _ = command.Parameters.AddWithValue("myDate", $"%{myDate}{myYear}%");
            object count = command.ExecuteScalar();
            Calendar.MaxItem = Convert.ToInt32(count);
            labelAll.Text = $"Всего задач за месяц: {Calendar.MaxItem}";
            int check = Convert.ToInt32(count);
            for (int i = 1; i <= check; i++)
            {
                allPanels[i - 1].Visible = true;
            }
        }
        private async void LoadingCalendarDB()
        {
            SQLiteDataReader sqlReader;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_requests.main}] " +
                $"WHERE {Table_requests.time} " +
                $"LIKE @date", DB);
            _ = command.Parameters.AddWithValue("date", $"%{myDate}{myYear}%");
            sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
            while (await sqlReader.ReadAsync())
            {
                object idReq = sqlReader.GetValue(0);
                object title = sqlReader.GetValue(2);
                object dateReq = sqlReader.GetValue(7);
                string newDate = dateReq.ToString().Split('/').First();
                _calendar.CreateItem(idReq.ToString(), title.ToString(), newDate);
            }
            Label[] allLabelTime = new Label[]
            {
                labelTime1,labelTime2, labelTime3, labelTime4, labelTime5,
                labelTime6, labelTime7, labelTime8, labelTime9,labelTime10,
                labelTime11, labelTime12, labelTime13, labelTime14, labelTime15,
                labelTime16, labelTime17, labelTime18, labelTime19, labelTime20,
                labelTime21, labelTime22, labelTime23, labelTime24, labelTime25,
                labelTime26, labelTime27, labelTime28, labelTime29, labelTime30,
                labelTime31,
            };
            Label[] allLabelTitle = new Label[]
            {
                labelTitle1, labelTitle2, labelTitle3, labelTitle4, labelTitle5,
                labelTitle6, labelTitle7, labelTitle8, labelTitle9, labelTitle10,
                labelTitle11, labelTitle12, labelTitle13, labelTitle14, labelTitle15,
                labelTitle16, labelTitle17, labelTitle18, labelTitle19, labelTitle20,
                labelTitle21, labelTitle22, labelTitle23, labelTitle24, labelTitle25,
                labelTitle26, labelTitle27, labelTitle28, labelTitle29, labelTitle30,
                labelTitle31,
            };
            for (int c = 1; c <= Calendar.MaxItem; c++)
            {
                allLabelTime[c - 1].Text = _calendar.items[checkItem].DateReq;
                allLabelTitle[c - 1].Text = _calendar.items[checkItem].Title;
                checkItem++;
            }
        }
        private async void OpenDescriptionTicket(int id)
        {
            string idReq = _calendar.items[id].IdReq;
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_requests.main}] " +
                $"WHERE [{Table_requests.id}] = @idReq", DB);
            _ = command.Parameters.AddWithValue("idReq", idReq);
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
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
        #region Помощь
        private readonly Dictionary<string, string> allTickets = new Dictionary<string, string>()
        {
            {"0","labelTitle1"},
            {"1","labelTitle2"},
            {"2","labelTitle3"},
            {"3","labelTitle4"},
            {"4","labelTitle5"},
            {"5","labelTitle6"},
            {"6","labelTitle7"},
            {"7","labelTitle8"},
            {"8","labelTitle9"},
            {"9","labelTitle10"},
            {"10","labelTitle11"},
            {"11","labelTitle12"},
            {"12","labelTitle13"},
            {"13","labelTitle14"},
            {"14","labelTitle15"},
            {"15","labelTitle16"},
            {"16","labelTitle17"},
            {"17","labelTitle18"},
            {"18","labelTitle19"},
            {"19","labelTitle20"},
            {"20","labelTitle21"},
            {"21","labelTitle22"},
            {"22","labelTitle23"},
            {"23","labelTitle24"},
            {"24","labelTitle25"},
            {"25","labelTitle26"},
            {"26","labelTitle27"},
            {"27","labelTitle28"},
            {"28","labelTitle29"},
            {"29","labelTitle30"},
            {"30","labelTitle31"},
        };
        private void TicketClick(object sender, EventArgs e)
        {
            if (sender is Control clicked)
            {
                string text = clicked.Name;
                foreach (KeyValuePair<string, string> allNames in allTickets)
                {
                    if (allNames.Value == text)
                    {
                        OpenDescriptionTicket(int.Parse(allNames.Key));
                    }
                }
            }
        }
        #endregion
        private void comboBoxYear_TextChanged(object sender, EventArgs e)
        {
            myYear = comboBoxYear.Text;
            string month = comboBoxMonth.Text;
            foreach (KeyValuePair<string, string> date in months)
            {
                if (date.Value == month)
                {
                    myDate = date.Key;
                }
            }
            _calendar.items = new List<Item>();
            Calendar.MaxItem = 0;
            checkItem = 0;
            LoadingCount();
            LoadingCalendarDB();
        }
        private void ComboBoxMonth_TextChanged(object sender, EventArgs e)
        {
            string month = comboBoxMonth.Text;
            foreach (KeyValuePair<string, string> date in months)
            {
                if (date.Value == month)
                {
                    myDate = date.Key;
                }
            }
            _calendar.items = new List<Item>();
            Calendar.MaxItem = 0;
            checkItem = 0;
            LoadingCount();
            LoadingCalendarDB();
        }
    }
}