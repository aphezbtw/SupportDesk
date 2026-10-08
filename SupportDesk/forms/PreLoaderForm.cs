using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportDesk
{
    public partial class PreLoaderForm : Form
    {
        private static readonly string path = Path.GetTempPath();
        private static readonly string directory = RememberLogin.directoryName;
        private static readonly string nameFileRemember = RememberLogin.fileName;
        private static int check = 0;

        [Obsolete]
        public PreLoaderForm()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void PreLoaderForm_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            timer1.Enabled = true;
            timer1.Interval = 25;
            timer1.Tick += Timer1_Tick;
            //timer1.Start();

            CreateFileLogs.Start(); CreateFileLogs.Wait();
            CreateImage.Start(); CreateImage.Wait();
            CreateImageFiles.Start(); CreateImageFiles.Wait();
            CreateImageAvatar.Start(); CreateImageAvatar.Wait();
            CreateDocs.Start(); CreateDocs.Wait();
            CreateAndUpdateDirectorySettings.Start(); CreateAndUpdateDirectorySettings.Wait();
            CreateAndUpdateFileRemember.Start(); //CreateAndUpdateFileRemember.Wait();
        }
        #region Загрузка
        private readonly Task CreateFileLogs = new Task(() =>
        {
            FileInfo fileInf = new FileInfo(Logs.file);
            if (!fileInf.Exists)
            {
                _ = fileInf.Create();
            }

            _ = Task.Delay(1000);
        });
        private readonly Task CreateImage = new Task(() =>
        {
            DirectoryInfo directoryInf = new DirectoryInfo("image");
            if (!directoryInf.Exists)
            {
                directoryInf.Create();
                directoryInf.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
            _ = Task.Delay(1000);
        });
        private readonly Task CreateImageFiles = new Task(() =>
        {
            DirectoryInfo directoryInf = new DirectoryInfo("image/files");
            if (!directoryInf.Exists)
            {
                directoryInf.Create();
                directoryInf.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
            _ = Task.Delay(1000);
        });
        private readonly Task CreateImageAvatar = new Task(() =>
        {
            DirectoryInfo directoryInf = new DirectoryInfo("image/avatar");
            if (!directoryInf.Exists)
            {
                directoryInf.Create();
                directoryInf.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
            _ = Task.Delay(1000);
        });
        private readonly Task CreateDocs = new Task(() =>
        {
            DirectoryInfo directoryInf = new DirectoryInfo("docs");
            if (!directoryInf.Exists)
            {
                directoryInf.Create();
                directoryInf.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
            _ = Task.Delay(1000);
        });
        private readonly Task CreateAndUpdateDirectorySettings = new Task(() =>
        {
            DirectoryInfo directoryInf = new DirectoryInfo(path + directory);
            if (!directoryInf.Exists)
            {
                directoryInf.Create();
            }

            _ = Task.Delay(1000);
        });
        private readonly Task CreateAndUpdateFileRemember = new Task(() =>
        {
            FileInfo fileInf = new FileInfo(path + directory + nameFileRemember);
            if (!fileInf.Exists)
            {
                File.Create(path + directory + nameFileRemember).Close();
            }
            //Task.Delay(10);
        });
        #endregion
        [Obsolete]
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Minimum;
            }
            else
            {
                progressBar1.Value += 1;
            }

            check++;

            Random rnd = new Random();
            int num = rnd.Next(120, 200);

            if (check >= num)
            {
                timer1.Enabled = false;
                if (!RootAccess.CheckRunApp)
                {
                    Form fLogin = new LoginForm();
                    fLogin.Show();
                    fLogin.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                    Hide();
                }
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}