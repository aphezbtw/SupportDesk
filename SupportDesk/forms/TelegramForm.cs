using System;
using System.Net;
using System.Windows.Forms;
using Telegram.Bot;

namespace SupportDesk.forms
{
    public partial class TelegramForm : Form
    {
        private static TelegramBotClient Bot;

        [Obsolete]
        public TelegramForm()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void TelegramForm_Load(object sender, EventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Tls13
                   | SecurityProtocolType.Ssl3;
            Bot = new TelegramBotClient(TelegramConfig.botToken);
            Bot.StartReceiving();
            //this.WindowState = FormWindowState.Minimized;
            FormBorderStyle = FormBorderStyle.None;
            BackColor = System.Drawing.Color.Red;
            TransparencyKey = System.Drawing.Color.Red;
        }
        public static async void EnterMessasge(string theDate, string tema, string typeProblem, string user, string kabinet, string discription, string time)
        {
            string textMessage = $"{theDate}\n" + "Тема: " + $"{tema}\n" + "Тип работы: " + $"{typeProblem}\n" + "От кого: " + $"{user}\n" + "Кабинет: " + $"{kabinet}\n" + "Описание: " + $"{discription}\n" + "Время: " + $"{time}";
            _ = await Bot.SendTextMessageAsync(TelegramConfig.Channel, textMessage);
        }

        public static async void RegisterNewUser(string fio, string number, string email, string depart, string gp, string position, string log, string pass)
        {
            string textMessage = $"{fio}\n" + "Номер телефона: " + $"{number}\n" + "Почта: " + $"{email}\n" + "Отдел: " + $"{depart}\n" + "Группа: " + $"{gp}\n" + "Должность: " + $"{position}\n" + "Логин: " + $"{log}\n" + "Пароль: " + $"{pass}";
            _ = await Bot.SendTextMessageAsync(TelegramConfig.Channel, textMessage);
        }

        public static async void AcceptRequest(string initials, string tema, string typeProblem, string user, string kabinet, string time, string status)
        {
            string textMessage = $"{initials} принял(а) задачу\n" + "Тема: " + $"{tema}\n" + "Тип работы: " + $"{typeProblem}\n" + "От кого: " + $"{user}\n" + "Кабинет: " + $"{kabinet}\n" + "Время: " + $"{time}\n" + "Статус: " + $"{status}";
            _ = await Bot.SendTextMessageAsync(TelegramConfig.Channel, textMessage);
        }

        public static async void CloseRequest(string initials, string tema, string typeProblem, string user, string kabinet, string time, string status, string result)
        {
            string textMessage = $"{initials} закрыл(а) задачу\n" + "Тема: " + $"{tema}\n" + "Тип работы: " + $"{typeProblem}\n" + "От кого: " + $"{user}\n" + "Кабинет: " + $"{kabinet}\n" + "Время: " + $"{time}\n" + "Статус: " + $"{status}\n" + "Результат: " + $"{result}";
            _ = await Bot.SendTextMessageAsync(TelegramConfig.Channel, textMessage);
        }

        public static async void ReplaceCartridge(string initials, string cabinet, string cartridge)
        {
            string textMessage = $"{initials} заменил(а) картридж ({cartridge}) в кабинете: {cabinet}";
            _ = await Bot.SendTextMessageAsync(TelegramConfig.Channel, textMessage);
        }
        public static async void AddExecutor(string initials, string user, string kabinet, string time, string executor, string disc)
        {
            string textMessage = $"{initials} закрепил(а) исполнителя {executor} за задачей\n" + "От кого: " + $"{user}\n" + "Кабинет: " + $"{kabinet}\n" + "Время: " + $"{time}\n" + "Описание: " + $"{disc}";
            _ = await Bot.SendTextMessageAsync(TelegramConfig.Channel, textMessage);
        }

        public static async void ConfirmRequest(string initials, string user, string kabinet, string time, string status, string executor, string disc)
        {
            string textMessage = $"{initials} подтвердил(а) задачу {executor}\n" + "От кого: " + $"{user}\n" + "Кабинет: " + $"{kabinet}\n" + "Время: " + $"{time}\n" + "Описание: " + $"{disc}\n" + "Статус: " + $"{status}";
            _ = await Bot.SendTextMessageAsync(TelegramConfig.Channel, textMessage);
        }

        public static async void DeleteDatabase(string initials, string text)
        {
            string textMessage = $"{initials} {text}";
            _ = await Bot.SendTextMessageAsync(TelegramConfig.Channel, textMessage);
        }

        public static async void EditRequest(string initials, string tema, string typeProblem, string user, string kabinet, string time, string text)
        {
            string textMessage = $"{initials} отредактировал(а) описание задачи\n" + "Тема: " + $"{tema}\n" + "Тип работы: " + $"{typeProblem}\n" + "От кого: " + $"{user}\n" + "Кабинет: " + $"{kabinet}\n" + "Время: " + $"{time}\n" + "Описание: " + $"{text}";
            _ = await Bot.SendTextMessageAsync(TelegramConfig.Channel, textMessage);
        }
    }
}