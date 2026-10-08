using System;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class AddPrinterForm : Form
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
        public AddPrinterForm()
        {
            InitializeComponent();
        }

        private async void AddPrinterForm_Load(object sender, EventArgs e)
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
            string cabinet = textBoxCabinet.Text;
            string fio = textBoxFio.Text;
            string printer = textBoxPrinter.Text;
            string cartridge = textBoxCartridge.Text;
            if (cabinet == "" || fio == "" || cartridge == "")
            {
                return;
            }
            else
            {
                SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO {Table_cartrigde.main} ({Table_cartrigde.cabinet}, {Table_cartrigde.fio}, {Table_cartrigde.namePrinter}, {Table_cartrigde.cartridge}) VALUES (@cabinet, @fio, @printer, @cartridge)", DB);
                _ = commandInsert.Parameters.AddWithValue("cabinet", cabinet);
                _ = commandInsert.Parameters.AddWithValue("fio", fio);
                _ = commandInsert.Parameters.AddWithValue("printer", printer);
                _ = commandInsert.Parameters.AddWithValue("cartridge", cartridge);
                _ = await commandInsert.ExecuteNonQueryAsync();
                MessageBoxUI.Show("Принтер успешно добавлен!", "Новый принтер", "Accept");
                DateTime thisDay = DateTime.Now;
                File.AppendAllText(Logs.file, $"[Принтер]Добавлен {printer}({cartridge}) в {cabinet} ({DataUsers.Initials}) ({thisDay:dd.MM.yyyy HH:mm})");
                File.AppendAllText(Logs.file, Environment.NewLine);
                Close();
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
            buttonAdd.Enabled = textBoxCabinet.Text != "" && textBoxCartridge.Text != "" && textBoxFio.Text != "" && textBoxPrinter.Text != "";
        }
        #endregion
    }
}