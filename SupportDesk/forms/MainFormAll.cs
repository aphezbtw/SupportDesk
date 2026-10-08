using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SupportDesk.forms
{
    public partial class MainFormAll : Form
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
        public MainFormAll()
        {
            InitializeComponent();
        }
        private async void MainFormAll_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            labelName.Text = DataUsers.Name + " " + DataUsers.Father;
            labelGroup.Text = DataUsers.GroupName;
            this.Size = new Size(ConstructorWindow.sizeWAll, ConstructorWindow.sizeH);
            WidgetsConstructor();
            FiltersConstructor();
            MnBtnMenuConstructor();
            BtnMenuConstructor();
            comboBoxExecutors.SelectedItem = "Все пользователи";
            comboBoxTypeJob.SelectedItem = "Все работы";
            comboBoxCabinets.SelectedItem = "Все кабинеты";
        }
        #region Конструктор формы
        private void WidgetsConstructor()
        {
            monthCalendar.Visible = ConstructorWindow.Calendar;
            panel4.Visible = ConstructorWindow.AllUsers;
            panel5.Visible = ConstructorWindow.AllInventory;

            if (ConstructorWindow.sizeH == 500)
            {
                groupBox1.Size = new Size(982, ConstructorWindow.sizeGroupBoxUser);
                groupBox1.Location = new Point(210, ConstructorWindow.locationGroupBoxOffWidgets);
                flowLayoutPanel1.Visible = false;
            }
            else if (ConstructorWindow.sizeH == 680)
            {
                if (ConstructorWindow.Calendar == false && ConstructorWindow.AllUsers == false && ConstructorWindow.AllInventory == false)
                {
                    groupBox1.Size = new Size(982, ConstructorWindow.sizeGroupBoxWorker);
                    groupBox1.Location = new Point(210, ConstructorWindow.locationGroupBoxOffWidgets);
                }
                else
                {
                    groupBox1.Size = new Size(982, ConstructorWindow.sizeGroupBoxWorker);
                    groupBox1.Location = new Point(210, ConstructorWindow.locationGroupBoxOnWidgets);
                }
            }
            else if (ConstructorWindow.sizeH == 700)
            {
                if (ConstructorWindow.Calendar == false && ConstructorWindow.AllUsers == false && ConstructorWindow.AllInventory == false)
                {
                    groupBox1.Size = new Size(982, ConstructorWindow.sizeGroupBoxOffWidgets);
                    groupBox1.Location = new Point(210, ConstructorWindow.locationGroupBoxOffWidgets);
                }
                else
                {
                    groupBox1.Size = new Size(982, ConstructorWindow.sizeGroupBoxOnWidgets);
                    groupBox1.Location = new Point(210, ConstructorWindow.locationGroupBoxOnWidgets);
                }
            }
        }
        private void FiltersConstructor()
        {
            comboBoxTypeJob.Visible = ConstructorWindow.TypeJob;
            comboBoxCabinets.Visible = ConstructorWindow.Cabinets;
            comboBoxRequest.Visible = ConstructorWindow.Request;

            if (ConstructorWindow.Executors == false)
            {
                comboBoxExecutors.Visible = false;
                labelReqExecutor.Visible = false;
            }
            else
            {
                comboBoxExecutors.Visible = true;
                labelReqExecutor.Visible = true;
            }
        }
        private void MnBtnMenuConstructor()
        {
            expUIButtonIconCloseTicket.Visible = ConstructorWindow.CloseTicket;
            expUIButtonIconCreateTicket.Visible = ConstructorWindow.CreateTicket;
            expUIButtonIconCalendar.Visible = ConstructorWindow.CalendarMax;

            if (MiniButtonMenuConfig.About == false)
            {
                expUIButtonIconAbout.Visible = false;
                expUIButtonIconSettings.Location = new Point(MiniButtonMenuConfig.location3FirstButton, 145);
                expUIButtonIconDataUser.Location = new Point(MiniButtonMenuConfig.location3SecondButton, 145);
                expUIButtonIconLogout.Location = new Point(MiniButtonMenuConfig.location3ThirdButton, 145);
            } //1
            else
            {
                expUIButtonIconAbout.Visible = true;
            }

            if (MiniButtonMenuConfig.Settings == false)
            {
                expUIButtonIconSettings.Visible = false;
                expUIButtonIconAbout.Location = new Point(MiniButtonMenuConfig.location3FirstButton, 145);
                expUIButtonIconDataUser.Location = new Point(MiniButtonMenuConfig.location3SecondButton, 145);
                expUIButtonIconLogout.Location = new Point(MiniButtonMenuConfig.location3ThirdButton, 145);
            } //2
            else
            {
                expUIButtonIconSettings.Visible = true;
            }

            if (MiniButtonMenuConfig.DataUser == false)
            {
                expUIButtonIconDataUser.Visible = false;
                expUIButtonIconAbout.Location = new Point(MiniButtonMenuConfig.location3FirstButton, 145);
                expUIButtonIconSettings.Location = new Point(MiniButtonMenuConfig.location3SecondButton, 145);
                expUIButtonIconLogout.Location = new Point(MiniButtonMenuConfig.location3ThirdButton, 145);
            } //3
            else
            {
                expUIButtonIconDataUser.Visible = true;
            }

            if (MiniButtonMenuConfig.Logout == false)
            {
                expUIButtonIconLogout.Visible = false;
                expUIButtonIconAbout.Location = new Point(MiniButtonMenuConfig.location3FirstButton, 145);
                expUIButtonIconSettings.Location = new Point(MiniButtonMenuConfig.location3SecondButton, 145);
                expUIButtonIconDataUser.Location = new Point(MiniButtonMenuConfig.location3ThirdButton, 145);
            } //4
            else
            {
                expUIButtonIconLogout.Visible = true;
            }

            if (MiniButtonMenuConfig.About == false && MiniButtonMenuConfig.Settings == false)
            {
                expUIButtonIconAbout.Visible = false;
                expUIButtonIconSettings.Visible = false;
                expUIButtonIconDataUser.Location = new Point(MiniButtonMenuConfig.location2FirstButton, 145);
                expUIButtonIconLogout.Location = new Point(MiniButtonMenuConfig.location2SecondButton, 145);

            } //1+2
            if (MiniButtonMenuConfig.About == false && MiniButtonMenuConfig.DataUser == false)
            {
                expUIButtonIconAbout.Visible = false;
                expUIButtonIconDataUser.Visible = false;
                expUIButtonIconSettings.Location = new Point(MiniButtonMenuConfig.location2FirstButton, 145);
                expUIButtonIconLogout.Location = new Point(MiniButtonMenuConfig.location2SecondButton, 145);
            } //1+3
            if (MiniButtonMenuConfig.About == false && MiniButtonMenuConfig.Logout == false)
            {
                expUIButtonIconAbout.Visible = false;
                expUIButtonIconLogout.Visible = false;
                expUIButtonIconSettings.Location = new Point(MiniButtonMenuConfig.location2FirstButton, 145);
                expUIButtonIconDataUser.Location = new Point(MiniButtonMenuConfig.location2SecondButton, 145);
            } //1+4

            if (MiniButtonMenuConfig.Settings == false && MiniButtonMenuConfig.DataUser == false)
            {
                expUIButtonIconSettings.Visible = false;
                expUIButtonIconDataUser.Visible = false;
                expUIButtonIconAbout.Location = new Point(MiniButtonMenuConfig.location2FirstButton, 145);
                expUIButtonIconLogout.Location = new Point(MiniButtonMenuConfig.location2SecondButton, 145);
            } //2+3
            if (MiniButtonMenuConfig.Settings == false && MiniButtonMenuConfig.Logout == false)
            {
                expUIButtonIconSettings.Visible = false;
                expUIButtonIconLogout.Visible = false;
                expUIButtonIconAbout.Location = new Point(MiniButtonMenuConfig.location2FirstButton, 145);
                expUIButtonIconDataUser.Location = new Point(MiniButtonMenuConfig.location2SecondButton, 145);
            } //2+4

            if (MiniButtonMenuConfig.DataUser == false && MiniButtonMenuConfig.Logout == false)
            {
                expUIButtonIconDataUser.Visible = false;
                expUIButtonIconLogout.Visible = false;
                expUIButtonIconAbout.Location = new Point(MiniButtonMenuConfig.location2FirstButton, 145);
                expUIButtonIconSettings.Location = new Point(MiniButtonMenuConfig.location2SecondButton, 145);
            } //3+4

            if (MiniButtonMenuConfig.About == false && MiniButtonMenuConfig.Settings == false && MiniButtonMenuConfig.DataUser == false)
            {
                expUIButtonIconAbout.Visible = false;
                expUIButtonIconSettings.Visible = false;
                expUIButtonIconDataUser.Visible = false;
                expUIButtonIconLogout.Location = new Point(MiniButtonMenuConfig.location1FirstButton, 145);
            } //1+2+3
            if (MiniButtonMenuConfig.About == false && MiniButtonMenuConfig.Settings == false && MiniButtonMenuConfig.Logout == false)
            {
                expUIButtonIconAbout.Visible = false;
                expUIButtonIconSettings.Visible = false;
                expUIButtonIconLogout.Visible = false;
                expUIButtonIconDataUser.Location = new Point(MiniButtonMenuConfig.location1FirstButton, 145);
            } //1+2+4
            if (MiniButtonMenuConfig.About == false && MiniButtonMenuConfig.DataUser == false && MiniButtonMenuConfig.Logout == false)
            {
                expUIButtonIconAbout.Visible = false;
                expUIButtonIconDataUser.Visible = false;
                expUIButtonIconLogout.Visible = false;
                expUIButtonIconSettings.Location = new Point(MiniButtonMenuConfig.location1FirstButton, 145);
            } //1+3+4

            if (MiniButtonMenuConfig.Settings == false && MiniButtonMenuConfig.DataUser == false && MiniButtonMenuConfig.Logout == false)
            {
                expUIButtonIconSettings.Visible = false;
                expUIButtonIconDataUser.Visible = false;
                expUIButtonIconLogout.Visible = false;
                expUIButtonIconAbout.Location = new Point(MiniButtonMenuConfig.location1FirstButton, 145);
            } //2+3+4

        }
        private void BtnMenuConstructor()
        {
            expUIButtonUsers.Visible = ConstructorWindow.Users;
            expUIButtonPrinters.Visible = ConstructorWindow.Cartridges;
            expUIButtonLicenses.Visible = ConstructorWindow.Licenses;
            expUIButtonInventory.Visible = ConstructorWindow.Inventory;
            expUIButtonPasswords.Visible = ConstructorWindow.Passwords;
            expUIButtonContacts.Visible = ConstructorWindow.Contacts;
            expUIButtonDatabase.Visible = ConstructorWindow.Database;
            expUIButtonExcel.Visible = ConstructorWindow.Excel;

            if (!ConstructorWindow.Users && !ConstructorWindow.Cartridges && !ConstructorWindow.Licenses && !ConstructorWindow.Inventory
                && !ConstructorWindow.Passwords && !ConstructorWindow.Contacts && !ConstructorWindow.Database && !ConstructorWindow.Excel)
            {
                expUIButtonCreateNewTicket.Visible = true;
            }
            else
            {
                expUIButtonCreateNewTicket.Visible = false;
            }
        }
        #endregion
        #region Управление формой
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        #endregion

        #region Кнопки меню
        [Obsolete]
        private void expUIButtonUsers_Click(object sender, EventArgs e)
        {
            Form fUsers = new UsersForm();
            fUsers.Show();
            fUsers.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }

        [Obsolete]
        private void expUIButtonPrinters_Click(object sender, EventArgs e)
        {
            Form fCartridges = new CartridgesForm();
            fCartridges.Show();
            fCartridges.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }

        [Obsolete]
        private void expUIButtonLicenses_Click(object sender, EventArgs e)
        {
            Form fLicenses = new LicensesForm();
            fLicenses.Show();
            fLicenses.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }

        [Obsolete]
        private void expUIButtonInventory_Click(object sender, EventArgs e)
        {
            Form fInventory = new InventoryForm();
            fInventory.Show();
            fInventory.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }

        [Obsolete]
        private void expUIButtonPasswords_Click(object sender, EventArgs e)
        {
            Form fPasswords = new PasswordsForm();
            fPasswords.Show();
            fPasswords.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }

        [Obsolete]
        private void expUIButtonContacts_Click(object sender, EventArgs e)
        {
            Form fContacts = new ContactsForm();
            fContacts.Show();
            fContacts.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }

        [Obsolete]
        private void expUIButtonDatabase_Click(object sender, EventArgs e)
        {
            Form fDatabase = new DirectoryForm();
            fDatabase.Show();
            fDatabase.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        private async void expUIButtonExcel_Click(object sender, EventArgs e)
        {
            //Объявляем приложение
            Excel.Application ex = new Excel.Application
            {
                //Отобразить Excel
                //Количество листов в рабочей книге
                SheetsInNewWorkbook = ExcelConfig.numberOfSheets
            };
            //Добавить рабочую книгу
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
            //Отключить отображение окон с сообщениями
            ex.DisplayAlerts = false;
            //Получаем первый лист документа (счет начинается с 1)
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            //Название листа (вкладки снизу)
            sheet.Name = ExcelConfig.nameSheets;
            //Заполнения ячеек
            sheet.Cells[1, 1] = "Дата создания"; //A 
            sheet.Cells[1, 2] = "Срок"; //B
            sheet.Cells[1, 3] = "От кого"; //C
            sheet.Cells[1, 4] = "Кабинет"; //D
            sheet.Cells[1, 5] = "Описание работы"; //E
            sheet.Cells[1, 6] = "Статус задачи"; //F
            sheet.Cells[1, 7] = "Исполнитель"; //G
            sheet.Cells[1, 8] = "Дублер"; //H
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_requests.main}]", DB);
            List<string[]> data = new List<string[]>();
            int iLastRowA = sheet.Cells[sheet.Rows.Count, "A"].End[Excel.XlDirection.xlUp].Row;
            int iLastRowB = sheet.Cells[sheet.Rows.Count, "B"].End[Excel.XlDirection.xlUp].Row;
            int iLastRowC = sheet.Cells[sheet.Rows.Count, "C"].End[Excel.XlDirection.xlUp].Row;
            int iLastRowD = sheet.Cells[sheet.Rows.Count, "D"].End[Excel.XlDirection.xlUp].Row;
            int iLastRowE = sheet.Cells[sheet.Rows.Count, "E"].End[Excel.XlDirection.xlUp].Row;
            int iLastRowF = sheet.Cells[sheet.Rows.Count, "F"].End[Excel.XlDirection.xlUp].Row;
            int iLastRowG = sheet.Cells[sheet.Rows.Count, "G"].End[Excel.XlDirection.xlUp].Row;
            int iLastRowH = sheet.Cells[sheet.Rows.Count, "H"].End[Excel.XlDirection.xlUp].Row;
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    iLastRowA++;
                    iLastRowB++;
                    iLastRowC++;
                    iLastRowD++;
                    iLastRowE++;
                    iLastRowF++;
                    iLastRowG++;
                    iLastRowH++;
                    sheet.Cells[iLastRowA, "A"].Value = Convert.ToString($"{sqlReader[$"{Table_requests.theDate}"]}");
                    sheet.Cells[iLastRowB, "B"].Value = Convert.ToString($"{sqlReader[$"{Table_requests.time}"]}");
                    sheet.Cells[iLastRowC, "C"].Value = Convert.ToString($"{sqlReader[$"{Table_requests.user}"]}");
                    sheet.Cells[iLastRowD, "D"].Value = Convert.ToString($"{sqlReader[$"{Table_requests.kabinet}"]}");
                    sheet.Cells[iLastRowE, "E"].Value = Convert.ToString($"{sqlReader[$"{Table_requests.discription}"]}");
                    sheet.Cells[iLastRowF, "F"].Value = Convert.ToString($"{sqlReader[$"{Table_requests.status}"]}");
                    sheet.Cells[iLastRowG, "G"].Value = Convert.ToString($"{sqlReader[$"{Table_requests.executor}"]}");
                    sheet.Cells[iLastRowG, "H"].Value = Convert.ToString($"{sqlReader[$"{Table_requests.executor2}"]}");
                }

            }
            catch (Exception exp)
            {
                MessageBoxUI.Show($"{exp.Message}", $"{exp.Source}", "Error");
                return;
            }
            finally
            {
                sqlReader?.Close();
            }
            //Форматирование ячеек
            sheet.Cells.Font.Name = "Times New Roman";
            sheet.Cells.Font.Size = 10;
            sheet.Cells.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            sheet.Cells.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            sheet.Cells.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            sheet.Cells.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            sheet.Cells.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            sheet.Cells.EntireColumn.AutoFit();
            sheet.Cells.EntireRow.AutoFit();
            sheet.Cells.WrapText = true;
            ex.Visible = true;
            //Сохранение документа
            /*ex.Application.ActiveWorkbook.SaveAs($"{excel_config.nameFile}", Type.Missing,
              Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
              Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);*/
        }

        [Obsolete]
        private void expUIButtonCreateNewTicket_Click(object sender, EventArgs e)
        {
            Form fCreateTicket = new CreateNewTicketForm();
            fCreateTicket.Show();
            fCreateTicket.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        #endregion

        #region Мини кнопки меню
        private void expUIButtonIconAbout_Click(object sender, EventArgs e)
        {
            if (DataRequests.IsOpen)
            {
                return;
            }

            Form fAbout = new AboutLicensesForm();
            fAbout.Show();
            DataRequests.IsOpen = true;
        }

        [Obsolete]
        private void expUIButtonIconSettings_Click(object sender, EventArgs e)
        {
            Form fSettings = new SettingForm();
            fSettings.Show();
            fSettings.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }

        [Obsolete]
        private void expUIButtonIconDataUser_Click(object sender, EventArgs e)
        {
            Form fDataArea = new UserDataForm();
            fDataArea.Show();
            fDataArea.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }

        [Obsolete]
        private void expUIButtonIconLogout_Click(object sender, EventArgs e)
        {
            DataUsers.GroupUser = "";
            Form fLogin = new LoginForm();
            fLogin.Show();
            fLogin.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        #endregion

        #region Мини кнопки
        #endregion
    }
}
