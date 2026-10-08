using System;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class DataSpecificUserForm : Form
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
        public DataSpecificUserForm()
        {
            InitializeComponent();
        }

        private async void DataSpecificUserForm_Load(object sender, EventArgs e)
        {
            textBoxFamilyUser.Text = DataSpecificUser.Family;
            textBoxNameUser.Text = DataSpecificUser.Name;
            textBoxFatherUser.Text = DataSpecificUser.Father;
            textBoxNumberUser.Text = DataSpecificUser.Number;
            textBoxEmailUser.Text = DataSpecificUser.Email;
            textBoxLoginUser.Text = DataSpecificUser.Login;
            textBoxPass.Text = DataSpecificUser.Pass;
            comboBoxGender.SelectedItem = DataSpecificUser.Gender;
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            LoadingDeparts();
            LoadingPositions();
            comboBoxDepart.SelectedItem = DataSpecificUser.Depart;
            comboBoxPosition.SelectedItem = DataSpecificUser.Position;
            if (DataSpecificUser.CheckLocked == "LOCKED")
            {
                expUIButtonIconUnlock.Visible = true;
            }

            string image = AvatarUsers.CheckImage(DataSpecificUser.Gender, DataSpecificUser.GroupUser, DataSpecificUser.Image);
            pictureBoxUserImage.ImageLocation = image;
        }
        #region Загрузка БД
        private async void LoadingDeparts()
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_depart.main}]", DB);
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string depart = Convert.ToString($"{sqlReader[$"{Table_depart.depart}"]}");
                    _ = comboBoxDepart.Items.Add(depart);
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
        private async void LoadingPositions()
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_postiton.main}]", DB);
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string position = Convert.ToString($"{sqlReader[$"{Table_postiton.position}"]}");
                    _ = comboBoxPosition.Items.Add(position);
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
        private async void ExpUIButtonIconSave_Click(object sender, EventArgs e)
        {
            if (textBoxFamilyUser.Text != "" && textBoxNameUser.Text != "" && textBoxFatherUser.Text != "" &&
            comboBoxDepart.Text != "" && comboBoxPosition.Text != "")
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
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_users.main} SET [{Table_users.family}]=@family, [{Table_users.name}]=@name, [{Table_users.father}]=@father, [{Table_users.gender}]=@gender, [{Table_users.number}]=@number, [{Table_users.email}]=@email, [{Table_users.depart}]=@depart, [{Table_users.position}]=@position, [image]=@image WHERE [{Table_users.login}]=@login", DB);
                _ = commandUpdate.Parameters.AddWithValue("family", textBoxFamilyUser.Text); _ = commandUpdate.Parameters.AddWithValue("position", comboBoxPosition.Text);
                _ = commandUpdate.Parameters.AddWithValue("name", textBoxNameUser.Text);
                _ = commandUpdate.Parameters.AddWithValue("father", textBoxFatherUser.Text); _ = commandUpdate.Parameters.AddWithValue("login", textBoxLoginUser.Text);
                _ = commandUpdate.Parameters.AddWithValue("number", textBoxNumberUser.Text); _ = commandUpdate.Parameters.AddWithValue("image", DataSpecificUser.PathTo);
                _ = commandUpdate.Parameters.AddWithValue("email", textBoxEmailUser.Text);
                _ = commandUpdate.Parameters.AddWithValue("depart", comboBoxDepart.Text);
                _ = commandUpdate.Parameters.AddWithValue("gender", comboBoxGender.Text);
                _ = await commandUpdate.ExecuteNonQueryAsync();
                DataSpecificUser.Family = textBoxFamilyUser.Text;
                DataSpecificUser.Name = textBoxNameUser.Text;
                DataSpecificUser.Father = textBoxFatherUser.Text;
                DataSpecificUser.Number = textBoxNumberUser.Text;
                DataSpecificUser.Email = textBoxEmailUser.Text;
                MessageBoxUI.Show("Сохранение прошло успешно!", "Редактирование данных", "Accept");
                Close();
            }
            else
            {
                MessageBoxUI.Show("Данные не заполнены либо заполнены некорректно!", "Ошибка редактирования", "Error");
            }
        }
        #endregion
        #region Восстановление доступа
        private void ExpUIButtonIconSendMail_Click(object sender, EventArgs e)
        {
            Email.CheckEmail(DataSpecificUser.Email, DataSpecificUser.Name, DataSpecificUser.Father, DataSpecificUser.Login, DataSpecificUser.Pass);
            MessageBoxUI.Show("Отправлено письмо о восстановлении доступа к программе!", "Восстановление доступа", "Accept");
            File.AppendAllText(Logs.file, $"[Пользователи]Отправлено письмо доступа {DataSpecificUser.Name} {DataSpecificUser.Father} (ЗАБЫЛИ ПАРОЛЬ)");
            File.AppendAllText(Logs.file, Environment.NewLine);
        }
        #endregion
        #region Авторизоваться под пользователем
        [Obsolete]
        private void ExpUIButtonIconLogin_Click(object sender, EventArgs e)
        {
            LoginPerUser.Login = textBoxLoginUser.Text;
            LoginPerUser.Pass = textBoxPass.Text;
            LoginForm fLogin = new LoginForm();
            fLogin.EnterLoginPerUser(DB);
            Close();
        }
        #endregion
        #region Разблокировать
        private async void ExpUIButtonIconUnlock_Click(object sender, EventArgs e)
        {
            SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Table_users.main} SET [{Table_users.typeAccess}]=@typeAccess WHERE [{Table_users.login}]=@login", DB);
            _ = commandUpdate.Parameters.AddWithValue("login", DataSpecificUser.Login);
            _ = commandUpdate.Parameters.AddWithValue("typeAccess", null);
            _ = await commandUpdate.ExecuteNonQueryAsync();
            DataSpecificUser.CheckLocked = "";
            MessageBoxUI.Show("Учетная запись пользователя разблокирована!", "Учетная запись пользователя", "Info");
            Close();
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