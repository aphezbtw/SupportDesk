using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SupportDesk.forms
{
    public partial class RootCheckForm : Form
    {
        private SQLiteConnection DB;
        public RootCheckForm()
        {
            InitializeComponent();
        }

        private async void RootCheckForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
        }

        private async void ExpUIButtonAccept_Click(object sender, EventArgs e)
        {
            if (textBoxUIRoot.Text != RootAccess.rootPassword)
            {
                textBoxUIRoot.Text = "";
                MessageBoxUI.Show("Root-пароль введен не правильно!", "Root-пароль", "Error");
                Close();
            }
            else
            {
                if (RootAccess.CheckDelete == "База заявок")
                {
                    SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_requests.main}", DB);
                    _ = await commandDelete.ExecuteNonQueryAsync();
                    MessageBoxUI.Show("База данных очищена!", "База заявок", "Accept");
                    TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу заявок");
                }
                else if (RootAccess.CheckDelete == "База пользователей")
                {
                    SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_users.main}", DB);
                    _ = await commandDelete.ExecuteNonQueryAsync();
                    MessageBoxUI.Show("База данных очищена!", "База пользователей", "Accept");
                    TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу пользователей");
                }
                else if (RootAccess.CheckDelete == "База картриджей")
                {
                    SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_cartrigde.main}", DB);
                    _ = await commandDelete.ExecuteNonQueryAsync();
                    MessageBoxUI.Show("База данных очищена!", "База картриджей", "Accept");
                    TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу картриджей");
                }
                else if (RootAccess.CheckDelete == "База лицензий")
                {
                    SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_licenses.main}", DB);
                    _ = await commandDelete.ExecuteNonQueryAsync();
                    MessageBoxUI.Show("База данных очищена!", "База лицензий", "Accept");
                    TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу лицензий");
                }
                else if (RootAccess.CheckDelete == "База инвентаризации")
                {
                    SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_inventory.main}", DB);
                    _ = await commandDelete.ExecuteNonQueryAsync();
                    MessageBoxUI.Show("База данных очищена!", "База оборудования", "Accept");
                    TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу оборудования");
                }
                else if (RootAccess.CheckDelete == "База паролей")
                {
                    SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_passwords.main}", DB);
                    _ = await commandDelete.ExecuteNonQueryAsync();
                    MessageBoxUI.Show("База данных очищена!", "База паролей", "Accept");
                    TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу паролей");
                }
                else if (RootAccess.CheckDelete == "База внешних контактов")
                {
                    SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Table_contacts.main}", DB);
                    _ = await commandDelete.ExecuteNonQueryAsync();
                    MessageBoxUI.Show("База данных очищена!", "База внешних контактов", "Accept");
                    TelegramForm.DeleteDatabase(DataUsers.Initials, "очистил базу внешних контактов");
                }
                Close();
            }
        }

        private void ExpUIButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}