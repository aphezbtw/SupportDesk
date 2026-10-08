using SupportDesk.forms;
using System;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SupportDesk
{
    public partial class RegisterForm : Form
    {
        #region Настройки формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        #region Локальные переменные
        private SQLiteConnection DB;
        private readonly DateTime thisDay = DateTime.Now;
        private static char name1;
        private static char father1;
        #endregion
        [Obsolete]
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void RegisterForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
            LoadingDeparts();
            LoadingPositions();
        }
        #region Загрузка данных
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
        #region Выход
        [Obsolete]
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (DataUsers.GroupUser == "ADMIN")
            {
                Close();
            }
            else
            {
                Form fLogin = new LoginForm();
                fLogin.Show();
                fLogin.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                Hide();
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        #endregion
        #region Генератор пароля
        private void ButtonGeneratePass_Click(object sender, EventArgs e)
        {
            string param = "qwertyuiopasdfghjklzxcvbnm1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            int count = 8;
            string result = "";
            Random rnd = new Random();
            int lng = param.Length;

            for (int i = 0; i < count; i++)

            {
                result += param[rnd.Next(lng)];
            }

            textBoxPassUser.Text = result;
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
        #region Проверка заполненных данных
        private void CheckFillData(object sender, EventArgs e)
        {
            buttonRegUser.Enabled = textBoxFamilyUser.Text != "" && textBoxNameUser.Text != "" && textBoxFatherUser.Text != "" &&
            comboBoxGender.Text != "" && comboBoxDepart.Text != "" && comboBoxPosition.Text != "" && textBoxLoginUser.Text != "" && textBoxPassUser.Text != "";
        }
        #endregion
        #region Зарегистрировать аккаунт
        [Obsolete]
        private async void ButtonRegUser_Click(object sender, EventArgs e)
        {
            name1 = textBoxNameUser.Text[0];
            father1 = textBoxFatherUser.Text[0];
            Regex rEMail = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (textBoxEmailUser.Text.Length > 0)
            {
                if (!rEMail.IsMatch(textBoxEmailUser.Text))
                {
                    MessageBoxUI.Show("Некорректный адрес электронной почты!", "Ошибка регистрации", "Error");
                    textBoxEmailUser.SelectAll();
                    return;
                }
            }
            SQLiteCommand commandCheck = new SQLiteCommand($"SELECT COUNT(*) FROM [{Table_users.main}]", DB);
            object count = commandCheck.ExecuteScalar();
            if (Convert.ToInt32(count) >= Database.limitUsers)
            {
                MessageBoxUI.Show("Достигнуто максимальное количество пользователей", "Ошибка регистрации", "Error");
                return;
            }
            else
            {
                SQLiteDataReader sqlReader = null;
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_users.main}] WHERE {Table_users.family}=@family AND {Table_users.name}=@name AND {Table_users.father}=@father", DB);
                _ = command.Parameters.AddWithValue("family", textBoxFamilyUser.Text);
                _ = command.Parameters.AddWithValue("name", textBoxNameUser.Text);
                _ = command.Parameters.AddWithValue("father", textBoxFatherUser.Text);
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                if (await sqlReader.ReadAsync())
                {
                    MessageBoxUI.Show("Такой пользователь уже есть в базе данных!", "Ошибка регистрации", "Error");
                    return;
                }
                else
                {
                    SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_users.main} ({Table_users.family}, {Table_users.name}, {Table_users.father}, {Table_users.initials}, {Table_users.gender}, {Table_users.number}, {Table_users.email}, {Table_users.depart}, {Table_users.position}, {Table_users.login}, {Table_users.pass}, {Table_users.groupUser}) VALUES (@family, @name, @father, @initials, @gender, @number, @email, @depart, @position, @login, @pass, @gp)", DB);
                    _ = commandInsert.Parameters.AddWithValue("family", textBoxFamilyUser.Text); _ = commandInsert.Parameters.AddWithValue("position", comboBoxPosition.Text);
                    _ = commandInsert.Parameters.AddWithValue("name", textBoxNameUser.Text); _ = commandInsert.Parameters.AddWithValue("login", textBoxLoginUser.Text);
                    _ = commandInsert.Parameters.AddWithValue("father", textBoxFatherUser.Text); _ = commandInsert.Parameters.AddWithValue("pass", textBoxPassUser.Text);
                    _ = commandInsert.Parameters.AddWithValue("number", textBoxNumberUser.Text); _ = commandInsert.Parameters.AddWithValue("initials", textBoxFamilyUser.Text + " " + name1 + "." + father1);
                    _ = commandInsert.Parameters.AddWithValue("email", textBoxEmailUser.Text); _ = commandInsert.Parameters.AddWithValue("gender", comboBoxGender.Text);
                    _ = commandInsert.Parameters.AddWithValue("depart", comboBoxDepart.Text);
                    _ = commandInsert.Parameters.AddWithValue("gp", "USER");
                    _ = await commandInsert.ExecuteNonQueryAsync();
                    string fio = textBoxFamilyUser.Text + " " + textBoxNameUser.Text + " " + textBoxFatherUser.Text;
                    TelegramForm.RegisterNewUser(fio, textBoxNumberUser.Text, textBoxEmailUser.Text, comboBoxDepart.Text, "USER", comboBoxPosition.Text, textBoxLoginUser.Text, textBoxPassUser.Text);
                    File.AppendAllText(Logs.file, $"[Регистрация]{fio} ({thisDay:dd.MM.yyyy HH:mm})");
                    File.AppendAllText(Logs.file, Environment.NewLine);
                    MessageBoxUI.Show($"Пользователь успешно зарегистрирован!\nЛогин: {textBoxLoginUser.Text} Пароль: {textBoxPassUser.Text}", "Регистрация нового пользователя", "Accept");
                    if (DataUsers.GroupUser == "ADMIN")
                    {
                        Close();
                    }
                    else
                    {
                        Form fLogin = new LoginForm();
                        fLogin.Show();
                        fLogin.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                        Hide();
                    }
                }
            }
        }
        #endregion
        #region Проверка валидности почты
        private void TextBoxEmailUser_TextChanged(object sender, EventArgs e)
        {
            textBoxEmailUser.Text = Regex.Replace(textBoxEmailUser.Text, "[^A-Za-z0-9@._-]", "");
        }
        #endregion
    }
}