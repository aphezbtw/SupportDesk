using System;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class AddInvForm : Form
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
        #endregion
        public AddInvForm()
        {
            InitializeComponent();
        }

        private async void AddInvForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
        }
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
        #region Добавить
        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string purchaseDate = textBoxDateBuy.Text;
            string invNum = textBoxInvNumber.Text;
            string amount = textBoxAmount.Text;
            string location = textBoxPosition.Text;
            string factLocation = textBoxFactPosition.Text;

            if (name == "" || amount == "" || location == "" || factLocation == "")
            {
                return;
            }
            else
            {
                SQLiteCommand commandCheck = new SQLiteCommand($"SELECT COUNT(*) FROM [{Table_inventory.main}]", DB);
                object count = commandCheck.ExecuteScalar();
                if (Convert.ToInt32(count) >= Database.limitTech)
                {
                    MessageBoxUI.Show("Достигнуто максимальное количество оборудования!", "Ошибка добавления", "Error");
                    return;
                }
                else
                {
                    SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_inventory.main} ({Table_inventory.name}, {Table_inventory.purchaseDate}, {Table_inventory.invNum}, {Table_inventory.amount}, {Table_inventory.location}, {Table_inventory.factLocation}) VALUES (@name, @purchaseDate, @invNum, @amount, @location, @factLocation)", DB);
                    _ = commandInsert.Parameters.AddWithValue("name", name); _ = commandInsert.Parameters.AddWithValue("purchaseDate", purchaseDate);
                    _ = commandInsert.Parameters.AddWithValue("invNum", invNum); _ = commandInsert.Parameters.AddWithValue("amount", amount);
                    _ = commandInsert.Parameters.AddWithValue("location", location); _ = commandInsert.Parameters.AddWithValue("factLocation", factLocation);
                    _ = await commandInsert.ExecuteNonQueryAsync();
                    MessageBoxUI.Show("Оборудование успешно добавлено!", "Новое оборудование", "Accept");
                    DateTime thisDay = DateTime.Now;
                    File.AppendAllText(Logs.file, $"[Оборудование]Добавлено {name} {invNum} {amount}шт. в {location} ({DataUsers.Initials}) ({thisDay:dd.MM.yyyy HH:mm})");
                    File.AppendAllText(Logs.file, Environment.NewLine);
                    Close();
                }
            }
        }
        #endregion
        #region Отмена
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region Проверка на заполненость всех данных
        private void CheckTextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = textBoxPosition.Text != "" && textBoxName.Text != "" && textBoxInvNumber.Text != "" &&
                textBoxFactPosition.Text != "" && textBoxDateBuy.Text != "" && textBoxAmount.Text != "";
        }
        #endregion
    }
}