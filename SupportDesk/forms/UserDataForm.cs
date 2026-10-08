using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class UserDataForm : Form
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
        public UserDataForm()
        {
            InitializeComponent();
        }
        private async void UserDataForm_Load(object sender, EventArgs e)
        {
            textBoxFamilyUser.Text = DataUsers.Family;
            textBoxNameUser.Text = DataUsers.Name;
            textBoxFatherUser.Text = DataUsers.Father;
            _ = comboBoxGender.Items.Add(DataUsers.Gender);
            comboBoxGender.SelectedItem = DataUsers.Gender;
            textBoxNumberUser.Text = DataUsers.Number;
            textBoxEmailUser.Text = DataUsers.Email;
            _ = comboBoxDepart.Items.Add(DataUsers.Depart);
            comboBoxDepart.SelectedItem = DataUsers.Depart;
            _ = comboBoxPosition.Items.Add(DataUsers.Position);
            comboBoxPosition.SelectedItem = DataUsers.Position;
            textBoxLoginUser.Text = DataUsers.Login;
            expUIToggleControlSystemNotification.SwitchOnOff = DataUsers.UseSystemNotifaction;
            expUIToggleControlDublicateNotificationForEmail.SwitchOnOff = DataUsers.UseDublicateNotificationForEmail;
            string image = AvatarUsers.CheckImage(DataUsers.Gender, DataUsers.GroupUser, DataUsers.Image);
            pictureBoxUserImage.ImageLocation = image;
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
        }
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
            else if (DataUsers.GroupUser == "WORKER")
            {
                Form fMain = new MainWorkerForm();
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
        private void PictureBoxUserImage_MouseHover(object sender, EventArgs e)
        {
            pictureBoxUserImage.Visible = false;
            pictureBoxNewImage.Visible = true;
        }
        private void MouseHoverOff(object sender, EventArgs e)
        {
            pictureBoxUserImage.Visible = true;
            pictureBoxNewImage.Visible = false;
        }
        #endregion
        #region Сохранить
        [Obsolete]
        private async void ButtonSaveDataUser_Click(object sender, EventArgs e)
        {
            if (textBoxFamilyUser.Text != "" && textBoxNameUser.Text != "" && textBoxFatherUser.Text != "")
            {
                Regex rEMail = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (textBoxEmailUser.Text.Length > 0)
                {
                    if (!rEMail.IsMatch(textBoxEmailUser.Text))
                    {
                        MessageBoxUI.Show("Некорректный адрес электронной почты!", "Ошибка редактирования", "Error");
                        textBoxEmailUser.SelectAll();
                        return;
                    }
                }
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_users.main} SET [{Table_users.family}]=@family, [{Table_users.name}]=@name, [{Table_users.father}]=@father, [{Table_users.number}]=@number, [{Table_users.email}]=@email, [image]=@image WHERE [{Table_users.login}]=@login", DB);
                _ = commandUpdate.Parameters.AddWithValue("family", textBoxFamilyUser.Text); _ = commandUpdate.Parameters.AddWithValue("login", textBoxLoginUser.Text);
                _ = commandUpdate.Parameters.AddWithValue("name", textBoxNameUser.Text); _ = commandUpdate.Parameters.AddWithValue("image", DataUsers.PathTo);
                _ = commandUpdate.Parameters.AddWithValue("father", textBoxFatherUser.Text);
                _ = commandUpdate.Parameters.AddWithValue("number", textBoxNumberUser.Text);
                _ = commandUpdate.Parameters.AddWithValue("email", textBoxEmailUser.Text);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                DataUsers.Family = textBoxFamilyUser.Text;
                DataUsers.Name = textBoxNameUser.Text;
                DataUsers.Father = textBoxFatherUser.Text;
                DataUsers.Number = textBoxNumberUser.Text;
                DataUsers.Email = textBoxEmailUser.Text;
                MessageBoxUI.Show("Сохранение прошло успешно!", "Редактирование данных", "Accept");
                if (DataUsers.GroupUser == "ADMIN")
                {
                    Form fMain = new MainAdminForm();
                    fMain.Show();
                    fMain.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
                    Hide();
                }
                else if (DataUsers.GroupUser == "WORKER")
                {
                    Form fMain = new MainWorkerForm();
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
            else
            {
                MessageBoxUI.Show("Данные не заполнены либо заполнены некорректно!", "Ошибка редактирования", "Error");
            }
        }
        #endregion
        #region Сменить пароль
        [Obsolete]
        private void ButtonChangePass_Click(object sender, EventArgs e)
        {
            Form fChangePass = new ChangePassForm();
            fChangePass.Show();
            fChangePass.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            Hide();
        }
        #endregion
        #region Загрузить изображение
        private void PictureBoxNewImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.png, *.jpg, *.gif)|*.png;*.jpg;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                pictureBoxUserImage.Image = Image.FromFile(path);
                label10.Visible = false;
                pictureBoxNewImage.Visible = false;
                string pathTo = "image\\" + Path.GetFileName(path);
                DataUsers.Image = path;
                DataUsers.PathTo = pathTo;
                File.Copy(path, pathTo, true);
            }
        }
        #endregion
        #region Уведомления
        private void ExpUIToggleControlSystemNotification_Click(object sender, EventArgs e)
        {
            if (DataUsers.UseSystemNotifaction)
            {
                DataUsers.UseSystemNotifaction = false;
                MessageBoxUI.Show("Системные уведомления выключены!", "Системные уведомления", "Info");
            }
            else
            {
                DataUsers.UseSystemNotifaction = true;
                MessageBoxUI.Show("Системные уведомления включены!", "Системные уведомления", "Info");
            }

        }
        private void ExpUIToggleControlDublicateNotificationForEmail_Click(object sender, EventArgs e)
        {
            if (DataUsers.UseDublicateNotificationForEmail)
            {
                DataUsers.UseDublicateNotificationForEmail = false;
                MessageBoxUI.Show("Дублирование уведомлений на почту выключено!", "Системные уведомления", "Info");
            }
            else
            {
                DataUsers.UseDublicateNotificationForEmail = true;
                MessageBoxUI.Show("Дублирование уведомлений на почту включено!", "Системные уведомления", "Info");
            }
        }
        #endregion
        #region Проверка почты на валидность
        private void TextBoxEmailUser_TextChanged(object sender, EventArgs e)
        {
            textBoxEmailUser.Text = Regex.Replace(textBoxEmailUser.Text, "[^A-Za-z0-9@._-]", "");
        }
        #endregion
    }
}