using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class SettingForm : Form
    {
        #region Настройка формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        [Obsolete]
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            comboBoxClear.SelectedItem = "Не выбрано";
            LoadingWidgets();
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        private void FormControl(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        #region Виджеты
        private void LoadingWidgets()
        {
            toggleControlCalendar.SwitchOnOff = WidgetsConfig.Calendar == true;

            toggleControlAllUsers.SwitchOnOff = WidgetsConfig.AllUsers == true;

            toggleControlAllInventory.SwitchOnOff = WidgetsConfig.AllInventory == true;
        }
        private void ToggleControl_Click(object sender, EventArgs e)
        {
            WidgetsConfig.Calendar = WidgetsConfig.Calendar != true;
        }
        private void ToggleControlAllUsers_Click(object sender, EventArgs e)
        {
            WidgetsConfig.AllUsers = WidgetsConfig.AllUsers != true;
        }
        private void ToggleControlAllInventory_Click(object sender, EventArgs e)
        {
            WidgetsConfig.AllInventory = WidgetsConfig.AllInventory != true;
        }
        #endregion
        #region Очистить базу
        private void ButtonClearDB_Click(object sender, EventArgs e)
        {
            Form fRoot = new RootCheckForm();
            fRoot.Show();
            RootAccess.CheckDelete = comboBoxClear.Text;
        }
        #endregion
        #region Система логов
        private void ButtonOpenLogs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = $@"{Logs.file}";
            _ = txt.Start();
        }
        private void ButtonClearLogs_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Logs.file, string.Empty);
            MessageBoxUI.Show("Лог-файл успешно очищен!", "Очистка лог-файла", "Accept");
        }
        #endregion
    }
}