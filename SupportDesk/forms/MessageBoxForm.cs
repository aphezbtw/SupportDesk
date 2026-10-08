using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class MessageBoxForm : Form
    {
        #region Настройки формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        public MessageBoxForm(string text, string headText, string icon)
        {
            InitializeComponent();
            Text = headText;
            labelHead.Text = headText;
            labelText.Text = text;
            if (icon == "Accept")
            {
                pictureBoxAccept.Visible = true;
            }
            else if (icon == "Info")
            {
                pictureBoxInfo.Visible = true;
            }
            else if (icon == "Error")
            {
                pictureBoxError.Visible = true;
            }
        }

        private void ExpUIButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LabelHead_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MessageBoxForm_Load(object sender, EventArgs e)
        {

        }
    }
    public static class MessageBoxUI
    {
        public static void Show(string text, string headText, string icon)
        {
            using (MessageBoxForm form = new MessageBoxForm(text, headText, icon))
            {
                if (!DataUsers.UseSystemNotifaction)
                {
                    return;
                }

                _ = form.ShowDialog();
            }
        }
    }
}
