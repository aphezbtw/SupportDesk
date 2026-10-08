using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class AboutLicensesForm : Form
    {
        #region Настройка формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        public AboutLicensesForm()
        {
            InitializeComponent();
        }

        private void AboutLicensesForm_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void ButtonUserGuide_Click(object sender, EventArgs e)
        {
            MessageBoxUI.Show("Находится в разработке!", "Руководство пользователя", "Info");
        }

        private void ButtonSendBags_Click(object sender, EventArgs e)
        {
            Form fSendBags = new SendBagsForm();
            fSendBags.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
            DataRequests.IsOpen = false;
        }
        private void FormControl(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
