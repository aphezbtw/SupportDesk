using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SupportDesk
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        [Obsolete]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PreLoaderForm());
        }
    }

    internal static class Database
    {
        public static string connectionString = @"Data Source=teh_db.db;Integrated Security=False; MultipleActiveResultSets=True";
        public static int limitUsers = 500;
        public static int limitTech = 5000;
        public static int limitExecutors = 15;
    }
    internal static class CertificateSecurity
    {
        public static string textHeadError = "Сертификат безопасности";
        public static string textError = "Измените пароль учетной записи в личном кабинете, так как он не соответствует стандартным требованиям безопасности!";
        public static string textLowPassword = "Ненадежный пароль";
        public static string textHighPassword = "Надежный пароль";
        public static string textNoPassword = "Недопустимый пароль";
        public static List<string> noPasswords = new List<string>()
        {
            "123456",
            "1qwerty",
            "1q2w3e4r5t",
            "1q2w3e4r",
            "1q2w3e4r5t6y",
            "159753",
            "753159",
            "951753",
            "357159",
            "123456789",
            "1234567890",
            "0123456789",
            "qwerty123",
            "qwerty",
            "qwerty1",
            "password",
            "12345678",
            "1q2w3e",
            "111111",
            "11111111",
            "a111111",
            "000000",
            "asdasd",
            "asdasd123",
            "123321",
            "qwertyuiop",
            "abc123",
            "666666",
            "7777777",
            "password1",
            "passw0rd1",
            "passw0rd",
            "iloveyou",
            "zxcvbnm",
            "qazwsx",
            "dragon",
            "asdfghjkl",
            "monkey",
            "unknown",
            "1qaz2wsx",
            "gfhjkm",
            "ghbdtn",
            "default",
            "covid19",
            "gfyltvbz",
        };
    }
    internal static class Logs
    {
        public static string file = "logs.txt";
    }
    internal static class RememberLogin
    {
        public static string directoryName = "SupportDesk\\";
        public static string fileName = "loginPassword.txt";
    }
    internal static class RootAccess
    {
        public static string rootPassword = "K00pt3hR00t4cce$$";
        public static string CheckDelete { get; set; }
        public static bool CheckRunApp { get; set; } = false;
    }
    internal static class AvatarUsers
    {
        public static string CheckImage(string gender, string group, string userImage)
        {
            string image = "";
            bool fileExist = File.Exists(userImage);
            if (!fileExist && userImage != null && !fileExist && userImage != "")
            {
                image = "Error";
                return image;
            }
            else if (fileExist && userImage != null)
            {
                image = userImage;
                return image;
            }
            if (gender == "Мужской" && group == "USER")
            {
                image = "image/avatar/Man.png";
                return image;
            }
            else if (gender == "Женский" && group == "USER")
            {
                image = "image/avatar/Woman.png";
                return image;
            }
            else if (gender == "Мужской" && group != "USER")
            {
                image = "image/avatar/supportMan.png";
                return image;
            }
            else if (gender == "Женский" && group != "USER")
            {
                image = "image/avatar/supportWoman.png";
                return image;
            }
            return image;
        }
    }
    internal static class FileImage
    {
        public static string PathFile(string extension)
        {
            string image = "";
            if (extension == ".doc" || extension == ".docx")
            {
                image = "image/files/word.png";
                return image;
            }
            else if (extension == ".xls" || extension == ".xlsx")
            {
                image = "image/files/excel.png";
                return image;
            }
            else if (extension == ".pdf")
            {
                image = "image/files/pdf.png";
                return image;
            }
            else if (extension == ".psd")
            {
                image = "image/files/psd.png";
                return image;
            }
            else if (extension == ".png")
            {
                image = "image/files/png.png";
                return image;
            }
            else if (extension == ".jpg")
            {
                image = "image/files/jpg.png";
                return image;
            }
            else if (extension == ".mp3")
            {
                image = "image/files/mp3.png";
                return image;
            }
            else if (extension == ".mp4")
            {
                image = "image/files/mp4.png";
                return image;
            }
            else if (extension == ".mov")
            {
                image = "image/files/mov.png";
                return image;
            }
            else if (extension == ".avi")
            {
                image = "image/files/avi.png";
                return image;
            }
            return image;
        }
    }
    internal static class Email
    {
        public static string mailLogin = "infcentrkoop@mail.ru";
        public static string mailPassword = "WUmRevjR6ecWssf5r7GN";
        public static string mailSMTP = "smtp.mail.ru";
        public static int mailPort = 25;
        private static readonly string yandexLogin = "Distantkoop@yandex.ru";
        private static readonly string yandexPassword = "Nt[ybrev109";
        private static readonly string yandexSMTP = "smtp.yandex.ru";
        private static readonly int yandexPort = 587;
        private static readonly string subject = "Восстановление доступа к программе";

        public static void CheckEmail(string emailTo, string name, string father, string login, string password)
        {
            string check = emailTo.Split('@').Last();
            if (check == "mail.ru" || check == "internet.ru" || check == "bk.ru" || check == "inbox.ru" || check == "list.ru")
            {
                _ = SendEmail(emailTo, name, father, login, password);
            }
            else if (check == "yandex.ru")
            {
                _ = SendEmailYandex(emailTo, name, father, login, password);
            }
        }

        private static string SendEmail(string emailTo, string name, string father, string login, string password)
        {
            using (MailMessage mm = new MailMessage($"{mailLogin}", $"{emailTo}"))
            {
                mm.Subject = subject;
                mm.Body = $"Добрый день {name} {father}!\nВосстановление доступа к программе Support Desk\nВаш логин: {login}\nВаш пароль: {password}";
                mm.IsBodyHtml = false;
                using (SmtpClient sc = new SmtpClient($"{mailSMTP}", mailPort))
                {
                    sc.EnableSsl = true;
                    sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                    sc.UseDefaultCredentials = false;
                    sc.Credentials = new NetworkCredential($"{mailLogin}", $"{mailPassword}");
                    sc.Send(mm);
                    string action = "Accept";
                    return action;
                }
            }
        }

        private static string SendEmailYandex(string emailTo, string name, string father, string login, string password)
        {
            using (MailMessage mm = new MailMessage($"{yandexLogin}", $"{emailTo}"))
            {
                mm.Subject = subject;
                mm.Body = $"Добрый день {name} {father}!\nВосстановление доступа к программе Support Desk\nВаш логин: {login}\nВаш пароль: {password}";
                mm.IsBodyHtml = false;
                using (SmtpClient sc = new SmtpClient($"{yandexSMTP}", yandexPort))
                {
                    sc.EnableSsl = true;
                    sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                    sc.UseDefaultCredentials = false;
                    sc.Credentials = new NetworkCredential($"{yandexLogin}", $"{yandexPassword}");
                    sc.Send(mm);
                    string action = "Accept";
                    return action;
                }
            }
        }
    }
    internal static class EmailSupport
    {
        public static string subject = "Отзыв / Предложение по улучшению Support Desk";
        public static string email = "enable.false@mail.ru";
    }
    internal static class WidgetsConfig
    {
        public static string fileName = "config.txt";
        public static bool Calendar { get; set; } = true;
        public static bool AllUsers { get; set; } = true;
        public static bool AllInventory { get; set; } = true;

        public static int sizeGroupBoxOnWidgets = 503;
        public static int sizeGroupBoxOffWidgets = 650;
        public static int locationGroupBoxOnWidgets = 200;
        public static int locationGroupBoxOffWidgets = 38;

        public static int locationFirstWidget = 212;
        public static int locationTwoWidget = 384;
        public static int locationThirdWidget = 558;
    }
    internal static class ExcelConfig
    {
        public static int numberOfSheets = 1;
        public static string nameSheets = "Отчёт за год";
        public static string nameFile = "отчёт.xlsx";
    }
    internal static class TelegramConfig
    {
        public static string botName = "Technical support KOOP";
        public static string botToken = "1803354166:AAGHbBN9JxLQW_TfMxRbIaEQ5_vTCTmSsB0";
        public static string idChannel = "-1001544019364";
        public static string idAdmin = "1046474899";
        public static string Channel { get; set; } = idChannel;
    }
    public static class ConvertBool
    {
        public static string ConvertCheckBox(bool value)
        {
            if (value)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
    #region Календарь
    public class Calendar
    {
        public static int MaxItem { get; set; } = 0;
        public List<Item> items = new List<Item>();
        public List<Slot> InventoryArray = new List<Slot>();
        public void CreateItem(string idReq, string title, string dateReq)
        {
            if (idReq != "" && title != "")
            {
                Item.Accessories item = new Item.Accessories { Id = items.Count, IdReq = idReq, Title = title, DateReq = dateReq };
                items.Add(item);
            }
        }
        public Calendar(int capacity)
        {
            if (capacity > 0)
            {
                InventoryArray = new List<Slot>();
                for (int i = 0; i < capacity; i++)
                {
                    InventoryArray.Add(new Slot());
                }
            }
        }
    }
    public class Item
    {
        public int Id { get; set; }
        public string IdReq { get; set; }
        public string Title { get; set; }
        public string DateReq { get; set; }

        public class Accessories : Item
        {

        }
    }
    public class Slot
    {
        public Item Item { get; set; }
        public int Count { get; set; }
    }
    #endregion
    #region Таблицы
    internal static class Table_users
    {
        public static string main = "Users";
        public static string id = "id";
        public static string family = "family";
        public static string name = "name";
        public static string father = "father";
        public static string initials = "initials";
        public static string gender = "gender";
        public static string number = "number";
        public static string email = "email";
        public static string depart = "depart";
        public static string position = "position";
        public static string login = "login";
        public static string pass = "pass";
        public static string groupUser = "groupUser";
        public static string image = "image";
        public static string typeAccess = "typeAccess";
    }
    internal static class Table_requests
    {
        public static string main = "Requests";
        public static string id = "id";
        public static string theDate = "theDate";
        public static string tema = "tema";
        public static string typeProblem = "typeProblem";
        public static string user = "userReq";
        public static string kabinet = "kabinet";
        public static string discription = "discription";
        public static string date = "date";
        public static string time = "time";
        public static string status = "status";
        public static string executor = "executor";
        public static string executor2 = "executor2";
        public static string nameFile = "nameFile";
        public static string pathFile = "pathFile";
        public static string nameFileResult = "nameFileResult";
        public static string pathFileResult = "pathFileResult";
    }
    internal static class Table_cartrigde
    {
        public static string main = "Cartridges";
        public static string id = "ID";
        public static string cabinet = "Cabinet";
        public static string fio = "FIO";
        public static string namePrinter = "NamePrinter";
        public static string cartridge = "Cartridge";
        public static string date1 = "Date1";
        public static string date2 = "Date2";
        public static string date3 = "Date3";
        public static string date4 = "Date4";
        public static string date5 = "Date5";
        public static string date6 = "Date6";
        public static string date7 = "Date7";
        public static string date8 = "Date8";
    }
    internal static class Table_licenses
    {
        public static string main = "Licenses";
        public static string id = "ID";
        public static string cabinet = "cabinet";
        public static string software = "software";
        public static string check = "check";
        public static string pdf = "pdf";
    }
    internal static class Table_inventory
    {
        public static string main = "Inventory";
        public static string id = "ID";
        public static string name = "name";
        public static string purchaseDate = "purchaseDate";
        public static string invNum = "invNum";
        public static string amount = "amount";
        public static string location = "location";
        public static string factLocation = "factLocation";
    }
    internal static class Table_cabinets
    {
        public static string main = "Cabinets";
        public static string id = "ID";
        public static string cabinet = "cabinet";
        public static string licenses = "licenses";
    }
    internal static class Table_typeJob
    {
        public static string main = "TypeJob";
        public static string id = "ID";
        public static string typeJob = "typeJob";
    }
    internal static class Table_depart
    {
        public static string main = "Departaments";
        public static string id = "ID";
        public static string depart = "depart";
    }
    internal static class Table_postiton
    {
        public static string main = "Positions";
        public static string id = "ID";
        public static string position = "position";
    }
    internal static class Table_status
    {
        public static string main = "Status";
        public static string id = "ID";
        public static string status = "status";
    }
    internal static class Table_executor
    {
        public static string main = "Executors";
        public static string id = "ID";
        public static string initials = "initials";
    }
    internal static class Table_passwords
    {
        public static string main = "Passwords";
        public static string id = "ID";
        public static string site = "Site";
        public static string login = "Login";
        public static string pass = "Pass";
    }
    internal static class Table_contacts
    {
        public static string main = "Contacts";
        public static string id = "ID";
        public static string company = "Company";
        public static string name = "Name";
        public static string phone = "Phone";
    }
    class Table_Roles
    {
        public static string main = "Roles";
        public static string id = "id";
        public static string role = "role";
        public static string name = "name";
    }
    class Table_RightsRoles
    {
        public static string main = "RightsRoles";
        public static string id = "id";
        public static string role = "role";
        public static string name = "name";
        public static string heightWindow = "heightWindow";
        public static string avatar = "avatar";

        public static string w_calendar = "w_calendar";
        public static string w_users = "w_users";
        public static string w_inventory = "w_inventory";

        public static string f_typeJob = "f_typeJob";
        public static string f_cabinets = "f_cabinets";
        public static string f_status = "f_status";
        public static string f_executor = "f_executor";

        public static string mnBtn_closeTicket = "mnBtn_closeTicket";
        public static string mnBtn_createTicket = "mnBtn_createTicket";
        public static string mnBtn_calendar = "mnBtn_calendar";

        public static string mnBtnMenu_about = "mnBtnMenu_about";
        public static string mnBtnMenu_settings = "mnBtnMenu_settings";
        public static string mnBtnMenu_dataUser = "mnBtnMenu_dataUser";
        public static string mnBtnMenu_logout = "mnBtnMenu_logout";

        public static string btnMenu_users = "btnMenu_users";
        public static string btnMenu_cartridges = "btnMenu_cartridges";
        public static string btnMenu_licenses = "btnMenu_licenses";
        public static string btnMenu_inventory = "btnMenu_inventory";
        public static string btnMenu_passwords = "btnMenu_passwords";
        public static string btnMenu_contacts = "btnMenu_contacts";
        public static string btnMenu_database = "btnMenu_database";
        public static string btnMenu_excel = "btnMenu_excel";
        public static string btnMenu_createTicket = "btnMenu_createTicket";
    }
    class Table_Functional
    {
        public static string main = "Functional";
        public static string id = "id";
        public static string role = "role";

        public static string ticketUser = "ticketUser";
        public static string ticketWorker = "ticketWorker";
        public static string ticketAdmin = "ticketAdmin";
        public static string jobIsTicket = "jobIsTicket";
        public static string signExecutors = "signExecutors";
    }
    #endregion
    #region Данные
    internal static class DataUsers
    {
        public static string Family { get; set; }
        public static string Name { get; set; }
        public static string Father { get; set; }
        public static string Initials { get; set; }
        public static string Gender { get; set; }
        public static string Number { get; set; }
        public static string Email { get; set; }
        public static string Depart { get; set; }
        public static string Position { get; set; }
        public static string Login { get; set; }
        public static string Pass { get; set; }
        public static string GroupUser { get; set; }
        public static string GroupName { get; set; }
        public static string Image { get; set; }
        public static string PathTo { get; set; }
        public static bool UseSystemNotifaction { get; set; } = true;
        public static bool UseDublicateNotificationForEmail { get; set; } = false;
    }
    internal static class DataRequests
    {
        public static string Kod { get; set; }
        public static string Tema { get; set; }
        public static string TheDate { get; set; }
        public static string Type { get; set; }
        public static string User { get; set; }
        public static string Kabinet { get; set; }
        public static string Time { get; set; }
        public static string Discription { get; set; }
        public static string Status { get; set; }
        public static string Executor { get; set; }
        public static string Executor2 { get; set; }
        public static string Result { get; set; }
        public static string NameFile { get; set; }
        public static string PathFile { get; set; }
        public static string PathTo { get; set; }
        public static string NameFileResult { get; set; }
        public static string PathResultFile { get; set; }
        public static string PathResultTo { get; set; }
        public static bool IsOpen { get; set; } = false;
    }
    internal static class DataSpecificUser
    {
        public static string Family { get; set; }
        public static string Name { get; set; }
        public static string Father { get; set; }
        public static string Initials { get; set; }
        public static string Gender { get; set; }
        public static string Number { get; set; }
        public static string Email { get; set; }
        public static string Depart { get; set; }
        public static string Position { get; set; }
        public static string Login { get; set; }
        public static string Pass { get; set; }
        public static string Image { get; set; }
        public static string PathTo { get; set; }
        public static string CheckLocked { get; set; }
        public static string GroupUser { get; set; }
    }
    internal static class LoginPerUser
    {
        public static string Login { get; set; } = null;
        public static string Pass { get; set; } = null;
    }
    class ConstructorWindow
    {
        /// Window ///
        public static int sizeH { get; set; }
        public static int sizeWAll = 1200;

        /// GroupBox ///
        public static int sizeGroupBoxOnWidgets = 503;
        public static int sizeGroupBoxOffWidgets = 650;
        public static int locationGroupBoxOnWidgets = 200;
        public static int locationGroupBoxOffWidgets = 38;
        public static int sizeGroupBoxWorker = 477;
        public static int sizeGroupBoxUser = 450;


        /// Widgets ///
        public static bool Calendar { get; set; } = true;
        public static bool AllUsers { get; set; } = true;
        public static bool AllInventory { get; set; } = true;

        /// Filtres ///
        public static bool TypeJob { get; set; }
        public static bool Cabinets { get; set; }
        public static bool Request { get; set; }
        public static bool Executors { get; set; }

        /// Mini Buttons ///
        public static bool CloseTicket { get; set; }
        public static bool CreateTicket { get; set; }
        public static bool CalendarMax { get; set; }

        /// Buttons ///
        public static bool Users { get; set; }
        public static bool Cartridges { get; set; }
        public static bool Licenses { get; set; }
        public static bool Inventory { get; set; }
        public static bool Passwords { get; set; }
        public static bool Contacts { get; set; }
        public static bool Database { get; set; }
        public static bool Excel { get; set; }
        public static bool CreateTicketOther { get; set; }
    }
    class MiniButtonMenuConfig
    {
        public static bool About { get; set; } //В конструктор
        public static bool Settings { get; set; } //В конструктор
        public static bool DataUser { get; set; } //В конструктор
        public static bool Logout { get; set; } //В конструктор

        public static int locationFirstButton = 13;
        public static int locationSecondButton = 58;
        public static int locationThirdButton = 103;
        public static int locationFourButton = 148;

        public static int location3FirstButton = 34;
        public static int location3SecondButton = 80;
        public static int location3ThirdButton = 126;

        public static int location2FirstButton = 57;
        public static int location2SecondButton = 103;

        public static int location1FirstButton = 79;
    }
    class DataFunctional
    {
        public static bool ticketUser { get; set; }
        public static bool ticketWorker { get; set; }
        public static bool ticketAdmin { get; set; }
        public static bool jobIsTicket { get; set; }
        public static bool signExecutors { get; set; }
    }
    #endregion
}