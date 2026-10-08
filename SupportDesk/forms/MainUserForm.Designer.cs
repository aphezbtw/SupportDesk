
namespace SupportDesk.forms
{
    partial class MainUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.expUIButtonCreateNewTicket = new ExpUI.dll.ExpUIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expUIButtonIconLogout = new ExpUI.dll.ExpUIButtonIcon();
            this.expUIButtonIconDataUser = new ExpUI.dll.ExpUIButtonIcon();
            this.expUIButtonIconAbout = new ExpUI.dll.ExpUIButtonIcon();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAllRequests = new System.Windows.Forms.Label();
            this.labelRequestNew = new System.Windows.Forms.Label();
            this.labelRequestReady = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonExit = new ExpUI.dll.ExpUIButtonIcon();
            this.expUIButtonIconMaximaze = new ExpUI.dll.ExpUIButtonIcon();
            this.buttonMin = new ExpUI.dll.ExpUIButtonIcon();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.expUIButtonIconRefresh = new ExpUI.dll.ExpUIButtonIcon();
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.comboBoxCabinets = new System.Windows.Forms.ComboBox();
            this.comboBoxRequest = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeJob = new System.Windows.Forms.ComboBox();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExecutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExecutor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.expUIButtonCreateNewTicket);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 499);
            this.panel1.TabIndex = 3;
            // 
            // expUIButtonCreateNewTicket
            // 
            this.expUIButtonCreateNewTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.expUIButtonCreateNewTicket.BorderSize = 1;
            this.expUIButtonCreateNewTicket.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonCreateNewTicket.ColorTextForBorder = System.Drawing.Color.White;
            this.expUIButtonCreateNewTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonCreateNewTicket.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonCreateNewTicket.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.expUIButtonCreateNewTicket.ForeColor = System.Drawing.Color.White;
            this.expUIButtonCreateNewTicket.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonCreateNewTicket.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonCreateNewTicket.Image")));
            this.expUIButtonCreateNewTicket.Location = new System.Drawing.Point(0, 329);
            this.expUIButtonCreateNewTicket.Name = "expUIButtonCreateNewTicket";
            this.expUIButtonCreateNewTicket.Remember = false;
            this.expUIButtonCreateNewTicket.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.expUIButtonCreateNewTicket.ResponsiveText = true;
            this.expUIButtonCreateNewTicket.Size = new System.Drawing.Size(200, 35);
            this.expUIButtonCreateNewTicket.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.expUIButtonCreateNewTicket.TabIndex = 1;
            this.expUIButtonCreateNewTicket.Text = "Создать задачу";
            this.expUIButtonCreateNewTicket.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleRight;
            this.expUIButtonCreateNewTicket.Click += new System.EventHandler(this.ExpUIButtonCreateNewTicket_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.expUIButtonIconLogout);
            this.panel2.Controls.Add(this.expUIButtonIconDataUser);
            this.panel2.Controls.Add(this.expUIButtonIconAbout);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.labelAllRequests);
            this.panel2.Controls.Add(this.labelRequestNew);
            this.panel2.Controls.Add(this.labelRequestReady);
            this.panel2.Controls.Add(this.labelGroup);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 270);
            this.panel2.TabIndex = 1;
            // 
            // expUIButtonIconLogout
            // 
            this.expUIButtonIconLogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.expUIButtonIconLogout.BorderColor = System.Drawing.Color.Black;
            this.expUIButtonIconLogout.BorderSize = 1;
            this.expUIButtonIconLogout.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonIconLogout.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconLogout.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonIconLogout.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonIconLogout.Image")));
            this.expUIButtonIconLogout.Location = new System.Drawing.Point(126, 145);
            this.expUIButtonIconLogout.Name = "expUIButtonIconLogout";
            this.expUIButtonIconLogout.Remember = false;
            this.expUIButtonIconLogout.RememberColor = System.Drawing.Color.White;
            this.expUIButtonIconLogout.ShowBorder = true;
            this.expUIButtonIconLogout.Size = new System.Drawing.Size(40, 40);
            this.expUIButtonIconLogout.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Rounded;
            this.expUIButtonIconLogout.TabIndex = 52;
            this.expUIButtonIconLogout.Text = "expUIButtonIcon3";
            this.toolTip1.SetToolTip(this.expUIButtonIconLogout, "Сменить пользователя");
            this.expUIButtonIconLogout.Click += new System.EventHandler(this.ExpUIButtonIconLogout_Click);
            // 
            // expUIButtonIconDataUser
            // 
            this.expUIButtonIconDataUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.expUIButtonIconDataUser.BorderColor = System.Drawing.Color.Black;
            this.expUIButtonIconDataUser.BorderSize = 1;
            this.expUIButtonIconDataUser.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconDataUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonIconDataUser.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconDataUser.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonIconDataUser.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonIconDataUser.Image")));
            this.expUIButtonIconDataUser.Location = new System.Drawing.Point(80, 145);
            this.expUIButtonIconDataUser.Name = "expUIButtonIconDataUser";
            this.expUIButtonIconDataUser.Remember = false;
            this.expUIButtonIconDataUser.RememberColor = System.Drawing.Color.White;
            this.expUIButtonIconDataUser.ShowBorder = true;
            this.expUIButtonIconDataUser.Size = new System.Drawing.Size(40, 40);
            this.expUIButtonIconDataUser.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Rounded;
            this.expUIButtonIconDataUser.TabIndex = 51;
            this.expUIButtonIconDataUser.Text = "expUIButtonIcon2";
            this.toolTip1.SetToolTip(this.expUIButtonIconDataUser, "Личный кабинет");
            this.expUIButtonIconDataUser.Click += new System.EventHandler(this.ExpUIButtonIconDataUser_Click);
            // 
            // expUIButtonIconAbout
            // 
            this.expUIButtonIconAbout.BackColor = System.Drawing.Color.DodgerBlue;
            this.expUIButtonIconAbout.BorderColor = System.Drawing.Color.Black;
            this.expUIButtonIconAbout.BorderSize = 1;
            this.expUIButtonIconAbout.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonIconAbout.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconAbout.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonIconAbout.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonIconAbout.Image")));
            this.expUIButtonIconAbout.Location = new System.Drawing.Point(34, 145);
            this.expUIButtonIconAbout.Name = "expUIButtonIconAbout";
            this.expUIButtonIconAbout.Remember = false;
            this.expUIButtonIconAbout.RememberColor = System.Drawing.Color.White;
            this.expUIButtonIconAbout.ShowBorder = true;
            this.expUIButtonIconAbout.Size = new System.Drawing.Size(40, 40);
            this.expUIButtonIconAbout.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Rounded;
            this.expUIButtonIconAbout.TabIndex = 4;
            this.expUIButtonIconAbout.Text = "expUIButtonIcon1";
            this.toolTip1.SetToolTip(this.expUIButtonIconAbout, "Справка");
            this.expUIButtonIconAbout.Click += new System.EventHandler(this.ExpUIButtonIconAbout_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(54, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Всего заявок";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(54, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Новая/В работе";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(54, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "Выполнено";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAllRequests
            // 
            this.labelAllRequests.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllRequests.ForeColor = System.Drawing.Color.White;
            this.labelAllRequests.Location = new System.Drawing.Point(5, 245);
            this.labelAllRequests.Name = "labelAllRequests";
            this.labelAllRequests.Size = new System.Drawing.Size(45, 25);
            this.labelAllRequests.TabIndex = 47;
            this.labelAllRequests.Text = "999";
            this.labelAllRequests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRequestNew
            // 
            this.labelRequestNew.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRequestNew.ForeColor = System.Drawing.Color.White;
            this.labelRequestNew.Location = new System.Drawing.Point(5, 220);
            this.labelRequestNew.Name = "labelRequestNew";
            this.labelRequestNew.Size = new System.Drawing.Size(45, 25);
            this.labelRequestNew.TabIndex = 46;
            this.labelRequestNew.Text = "999";
            this.labelRequestNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRequestReady
            // 
            this.labelRequestReady.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRequestReady.ForeColor = System.Drawing.Color.White;
            this.labelRequestReady.Location = new System.Drawing.Point(5, 195);
            this.labelRequestReady.Name = "labelRequestReady";
            this.labelRequestReady.Size = new System.Drawing.Size(45, 25);
            this.labelRequestReady.TabIndex = 45;
            this.labelRequestReady.Text = "999";
            this.labelRequestReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGroup
            // 
            this.labelGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.ForeColor = System.Drawing.Color.White;
            this.labelGroup.Location = new System.Drawing.Point(0, 121);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(200, 15);
            this.labelGroup.TabIndex = 33;
            this.labelGroup.Text = "Пользователь";
            this.labelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(0, 86);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(200, 35);
            this.labelName.TabIndex = 32;
            this.labelName.Text = "Даниил Константинович";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(62, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Support Desk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Controls.Add(this.expUIButtonIconMaximaze);
            this.panel3.Controls.Add(this.buttonMin);
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 20);
            this.panel3.TabIndex = 4;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.buttonExit.BorderColor = System.Drawing.Color.Black;
            this.buttonExit.BorderSize = 1;
            this.buttonExit.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.HoverColor = System.Drawing.Color.Red;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(980, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Remember = false;
            this.buttonExit.RememberColor = System.Drawing.Color.White;
            this.buttonExit.ShowBorder = false;
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.buttonExit.TabIndex = 43;
            this.buttonExit.Text = "expUIButtonIcon1";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // expUIButtonIconMaximaze
            // 
            this.expUIButtonIconMaximaze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expUIButtonIconMaximaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.expUIButtonIconMaximaze.BorderColor = System.Drawing.Color.Black;
            this.expUIButtonIconMaximaze.BorderSize = 1;
            this.expUIButtonIconMaximaze.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconMaximaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonIconMaximaze.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconMaximaze.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonIconMaximaze.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonIconMaximaze.Image")));
            this.expUIButtonIconMaximaze.Location = new System.Drawing.Point(960, 0);
            this.expUIButtonIconMaximaze.Name = "expUIButtonIconMaximaze";
            this.expUIButtonIconMaximaze.Remember = false;
            this.expUIButtonIconMaximaze.RememberColor = System.Drawing.Color.White;
            this.expUIButtonIconMaximaze.ShowBorder = false;
            this.expUIButtonIconMaximaze.Size = new System.Drawing.Size(20, 20);
            this.expUIButtonIconMaximaze.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.expUIButtonIconMaximaze.TabIndex = 45;
            this.expUIButtonIconMaximaze.Text = "expUIButtonIcon1";
            this.expUIButtonIconMaximaze.Click += new System.EventHandler(this.ExpUIButtonIconMaximaze_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.buttonMin.BorderColor = System.Drawing.Color.Black;
            this.buttonMin.BorderSize = 1;
            this.buttonMin.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMin.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonMin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMin.Image = ((System.Drawing.Image)(resources.GetObject("buttonMin.Image")));
            this.buttonMin.Location = new System.Drawing.Point(940, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Remember = false;
            this.buttonMin.RememberColor = System.Drawing.Color.White;
            this.buttonMin.ShowBorder = false;
            this.buttonMin.Size = new System.Drawing.Size(20, 20);
            this.buttonMin.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.buttonMin.TabIndex = 44;
            this.buttonMin.Text = "expUIButtonIcon1";
            this.buttonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.expUIButtonIconRefresh);
            this.groupBox1.Controls.Add(this.dataGridViewRequests);
            this.groupBox1.Controls.Add(this.comboBoxCabinets);
            this.groupBox1.Controls.Add(this.comboBoxRequest);
            this.groupBox1.Controls.Add(this.comboBoxTypeJob);
            this.groupBox1.Location = new System.Drawing.Point(210, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 450);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // expUIButtonIconRefresh
            // 
            this.expUIButtonIconRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expUIButtonIconRefresh.BackColor = System.Drawing.Color.White;
            this.expUIButtonIconRefresh.BorderColor = System.Drawing.Color.Black;
            this.expUIButtonIconRefresh.BorderSize = 1;
            this.expUIButtonIconRefresh.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonIconRefresh.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconRefresh.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonIconRefresh.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonIconRefresh.Image")));
            this.expUIButtonIconRefresh.Location = new System.Drawing.Point(944, 7);
            this.expUIButtonIconRefresh.Name = "expUIButtonIconRefresh";
            this.expUIButtonIconRefresh.Remember = false;
            this.expUIButtonIconRefresh.RememberColor = System.Drawing.Color.White;
            this.expUIButtonIconRefresh.ShowBorder = false;
            this.expUIButtonIconRefresh.Size = new System.Drawing.Size(32, 32);
            this.expUIButtonIconRefresh.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.expUIButtonIconRefresh.TabIndex = 61;
            this.expUIButtonIconRefresh.Text = "expUIButtonIcon1";
            this.expUIButtonIconRefresh.Click += new System.EventHandler(this.ExpUIButtonIconRefresh_Click);
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.AllowUserToAddRows = false;
            this.dataGridViewRequests.AllowUserToDeleteRows = false;
            this.dataGridViewRequests.AllowUserToResizeColumns = false;
            this.dataGridViewRequests.AllowUserToResizeRows = false;
            this.dataGridViewRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRequests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRequests.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnData,
            this.ColumnTema,
            this.ColumnTypeProblem,
            this.ColumnFio,
            this.ColumnKab,
            this.ColumnTime,
            this.ColumnStatus,
            this.ColumnExecutor,
            this.ColumnExecutor2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRequests.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRequests.Location = new System.Drawing.Point(5, 39);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRequests.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRequests.RowHeadersVisible = false;
            this.dataGridViewRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRequests.Size = new System.Drawing.Size(971, 443);
            this.dataGridViewRequests.TabIndex = 60;
            this.dataGridViewRequests.DoubleClick += new System.EventHandler(this.DataGridViewRequests_DoubleClick);
            // 
            // comboBoxCabinets
            // 
            this.comboBoxCabinets.BackColor = System.Drawing.Color.White;
            this.comboBoxCabinets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCabinets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCabinets.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCabinets.FormattingEnabled = true;
            this.comboBoxCabinets.Items.AddRange(new object[] {
            "Все кабинеты"});
            this.comboBoxCabinets.Location = new System.Drawing.Point(160, 10);
            this.comboBoxCabinets.Name = "comboBoxCabinets";
            this.comboBoxCabinets.Size = new System.Drawing.Size(150, 24);
            this.comboBoxCabinets.TabIndex = 59;
            this.comboBoxCabinets.TextChanged += new System.EventHandler(this.ComboBoxCabinets_TextChanged);
            // 
            // comboBoxRequest
            // 
            this.comboBoxRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRequest.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRequest.FormattingEnabled = true;
            this.comboBoxRequest.Items.AddRange(new object[] {
            "Все задачи"});
            this.comboBoxRequest.Location = new System.Drawing.Point(315, 10);
            this.comboBoxRequest.Name = "comboBoxRequest";
            this.comboBoxRequest.Size = new System.Drawing.Size(150, 24);
            this.comboBoxRequest.TabIndex = 58;
            this.comboBoxRequest.TextChanged += new System.EventHandler(this.ComboBoxRequest_TextChanged);
            // 
            // comboBoxTypeJob
            // 
            this.comboBoxTypeJob.BackColor = System.Drawing.Color.White;
            this.comboBoxTypeJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTypeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeJob.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypeJob.FormattingEnabled = true;
            this.comboBoxTypeJob.Items.AddRange(new object[] {
            "Все работы"});
            this.comboBoxTypeJob.Location = new System.Drawing.Point(5, 10);
            this.comboBoxTypeJob.Name = "comboBoxTypeJob";
            this.comboBoxTypeJob.Size = new System.Drawing.Size(150, 24);
            this.comboBoxTypeJob.TabIndex = 57;
            this.comboBoxTypeJob.TextChanged += new System.EventHandler(this.ComboBoxTypeJob_TextChanged);
            // 
            // ColumnData
            // 
            this.ColumnData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnData.Frozen = true;
            this.ColumnData.HeaderText = "Дата создания";
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            this.ColumnData.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnData.Width = 120;
            // 
            // ColumnTema
            // 
            this.ColumnTema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnTema.Frozen = true;
            this.ColumnTema.HeaderText = "Тема";
            this.ColumnTema.Name = "ColumnTema";
            this.ColumnTema.ReadOnly = true;
            this.ColumnTema.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnTema.Width = 102;
            // 
            // ColumnTypeProblem
            // 
            this.ColumnTypeProblem.HeaderText = "Тип работы";
            this.ColumnTypeProblem.Name = "ColumnTypeProblem";
            this.ColumnTypeProblem.ReadOnly = true;
            this.ColumnTypeProblem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnFio
            // 
            this.ColumnFio.HeaderText = "От кого";
            this.ColumnFio.Name = "ColumnFio";
            this.ColumnFio.ReadOnly = true;
            this.ColumnFio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnKab
            // 
            this.ColumnKab.HeaderText = "Кабинет";
            this.ColumnKab.Name = "ColumnKab";
            this.ColumnKab.ReadOnly = true;
            this.ColumnKab.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Время";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Статус задачи";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnExecutor
            // 
            this.ColumnExecutor.HeaderText = "Исполнитель";
            this.ColumnExecutor.Name = "ColumnExecutor";
            this.ColumnExecutor.ReadOnly = true;
            this.ColumnExecutor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnExecutor2
            // 
            this.ColumnExecutor2.HeaderText = "Дублер";
            this.ColumnExecutor2.Name = "ColumnExecutor2";
            this.ColumnExecutor2.ReadOnly = true;
            // 
            // MainUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 498);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainUserForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAllRequests;
        private System.Windows.Forms.Label labelRequestNew;
        private System.Windows.Forms.Label labelRequestReady;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ExpUI.dll.ExpUIButtonIcon expUIButtonIconLogout;
        private ExpUI.dll.ExpUIButtonIcon expUIButtonIconDataUser;
        private ExpUI.dll.ExpUIButtonIcon expUIButtonIconAbout;
        private ExpUI.dll.ExpUIButton expUIButtonCreateNewTicket;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTypeJob;
        private System.Windows.Forms.ComboBox comboBoxCabinets;
        private System.Windows.Forms.ComboBox comboBoxRequest;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private ExpUI.dll.ExpUIButtonIcon expUIButtonIconRefresh;
        private ExpUI.dll.ExpUIButtonIcon buttonMin;
        private ExpUI.dll.ExpUIButtonIcon buttonExit;
        private ExpUI.dll.ExpUIButtonIcon expUIButtonIconMaximaze;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKab;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExecutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExecutor2;
    }
}