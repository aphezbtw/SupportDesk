using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class SendBagsForm : Form
    {
        #region Настройка формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        public SendBagsForm()
        {
            InitializeComponent();
        }
        private void SendBagsForm_Load(object sender, EventArgs e)
        {

        }
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            string text = textBoxText.Text;
            if (text == "")
            {
                return;
            }

            using (MailMessage mm = new MailMessage($"{Email.mailLogin}", $"{EmailSupport.email}"))
            {
                mm.Subject = EmailSupport.subject;
                mm.Body = text;
                mm.IsBodyHtml = false;
                using (SmtpClient sc = new SmtpClient($"{Email.mailSMTP}", Email.mailPort))
                {
                    sc.EnableSsl = true;
                    sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                    sc.UseDefaultCredentials = false;
                    sc.Credentials = new NetworkCredential($"{Email.mailLogin}", $"{Email.mailPassword}");
                    sc.Send(mm);
                    File.AppendAllText(Logs.file, $"[Отзыв]Отправлен отзыв или предложение по улучшению системы ({DataUsers.Initials})");
                    File.AppendAllText(Logs.file, Environment.NewLine);
                    Close();
                }
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
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
    }
}
