namespace SupportDesk.forms
{
    partial class DataSpecificUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSpecificUserForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new ExpUI.dll.ExpUIButtonIcon();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFatherUser = new System.Windows.Forms.TextBox();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLoginUser = new System.Windows.Forms.TextBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmailUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFamilyUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDepart = new System.Windows.Forms.ComboBox();
            this.textBoxNumberUser = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxNewImage = new System.Windows.Forms.PictureBox();
            this.expUIButtonIconUnlock = new ExpUI.dll.ExpUIButtonIcon();
            this.expUIButtonIconLogin = new ExpUI.dll.ExpUIButtonIcon();
            this.expUIButtonIconSendMail = new ExpUI.dll.ExpUIButtonIcon();
            this.expUIButtonIconSave = new ExpUI.dll.ExpUIButtonIcon();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 20);
            this.panel2.TabIndex = 69;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.buttonExit.BorderColor = System.Drawing.Color.Black;
            this.buttonExit.BorderSize = 1;
            this.buttonExit.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.HoverColor = System.Drawing.Color.Red;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(496, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Remember = false;
            this.buttonExit.RememberColor = System.Drawing.Color.White;
            this.buttonExit.ShowBorder = false;
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.buttonExit.TabIndex = 42;
            this.buttonExit.Text = "expUIButtonIcon1";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(513, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Карточка сотрудника";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            this.label11.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.White;
            this.textBoxPass.Enabled = false;
            this.textBoxPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(276, 318);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(230, 22);
            this.textBoxPass.TabIndex = 87;
            this.textBoxPass.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(150, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 86;
            this.label7.Text = "Пароль:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(150, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 85;
            this.label9.Text = "Отчество:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // textBoxFatherUser
            // 
            this.textBoxFatherUser.BackColor = System.Drawing.Color.White;
            this.textBoxFatherUser.Enabled = false;
            this.textBoxFatherUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFatherUser.Location = new System.Drawing.Point(276, 94);
            this.textBoxFatherUser.Name = "textBoxFatherUser";
            this.textBoxFatherUser.Size = new System.Drawing.Size(230, 22);
            this.textBoxFatherUser.TabIndex = 73;
            this.textBoxFatherUser.TabStop = false;
            // 
            // textBoxNameUser
            // 
            this.textBoxNameUser.BackColor = System.Drawing.Color.White;
            this.textBoxNameUser.Enabled = false;
            this.textBoxNameUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameUser.Location = new System.Drawing.Point(276, 62);
            this.textBoxNameUser.Name = "textBoxNameUser";
            this.textBoxNameUser.Size = new System.Drawing.Size(230, 22);
            this.textBoxNameUser.TabIndex = 72;
            this.textBoxNameUser.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(150, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 84;
            this.label8.Text = "Имя:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(150, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 83;
            this.label6.Text = "Логин:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // textBoxLoginUser
            // 
            this.textBoxLoginUser.BackColor = System.Drawing.Color.White;
            this.textBoxLoginUser.Enabled = false;
            this.textBoxLoginUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLoginUser.Location = new System.Drawing.Point(276, 286);
            this.textBoxLoginUser.Name = "textBoxLoginUser";
            this.textBoxLoginUser.Size = new System.Drawing.Size(230, 22);
            this.textBoxLoginUser.TabIndex = 80;
            this.textBoxLoginUser.TabStop = false;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.BackColor = System.Drawing.Color.White;
            this.comboBoxPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(276, 254);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(230, 24);
            this.comboBoxPosition.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(150, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 82;
            this.label5.Text = "Должность:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(150, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 81;
            this.label4.Text = "Отдел:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(150, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 79;
            this.label3.Text = "E-mail:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // textBoxEmailUser
            // 
            this.textBoxEmailUser.BackColor = System.Drawing.Color.White;
            this.textBoxEmailUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmailUser.Location = new System.Drawing.Point(276, 190);
            this.textBoxEmailUser.Name = "textBoxEmailUser";
            this.textBoxEmailUser.Size = new System.Drawing.Size(230, 22);
            this.textBoxEmailUser.TabIndex = 76;
            this.textBoxEmailUser.TabStop = false;
            this.textBoxEmailUser.TextChanged += new System.EventHandler(this.TextBoxEmailUser_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(150, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "Телефон: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // textBoxFamilyUser
            // 
            this.textBoxFamilyUser.BackColor = System.Drawing.Color.White;
            this.textBoxFamilyUser.Enabled = false;
            this.textBoxFamilyUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFamilyUser.Location = new System.Drawing.Point(276, 30);
            this.textBoxFamilyUser.Name = "textBoxFamilyUser";
            this.textBoxFamilyUser.Size = new System.Drawing.Size(230, 22);
            this.textBoxFamilyUser.TabIndex = 70;
            this.textBoxFamilyUser.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(150, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 71;
            this.label1.Text = "Фамилия:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // comboBoxDepart
            // 
            this.comboBoxDepart.BackColor = System.Drawing.Color.White;
            this.comboBoxDepart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDepart.FormattingEnabled = true;
            this.comboBoxDepart.Location = new System.Drawing.Point(276, 222);
            this.comboBoxDepart.Name = "comboBoxDepart";
            this.comboBoxDepart.Size = new System.Drawing.Size(230, 24);
            this.comboBoxDepart.TabIndex = 77;
            // 
            // textBoxNumberUser
            // 
            this.textBoxNumberUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberUser.Location = new System.Drawing.Point(276, 158);
            this.textBoxNumberUser.Mask = "8(999)000-0000";
            this.textBoxNumberUser.Name = "textBoxNumberUser";
            this.textBoxNumberUser.Size = new System.Drawing.Size(230, 22);
            this.textBoxNumberUser.TabIndex = 88;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.Color.White;
            this.comboBoxGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(276, 126);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(230, 24);
            this.comboBoxGender.TabIndex = 89;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(150, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 23);
            this.label12.TabIndex = 90;
            this.label12.Text = "Пол:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(10, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 15);
            this.label10.TabIndex = 91;
            this.label10.Text = "Нет изображения";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Visible = false;
            this.label10.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUserImage.Location = new System.Drawing.Point(10, 30);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserImage.TabIndex = 96;
            this.pictureBoxUserImage.TabStop = false;
            this.pictureBoxUserImage.MouseHover += new System.EventHandler(this.PictureBoxUserImage_MouseHover);
            // 
            // pictureBoxNewImage
            // 
            this.pictureBoxNewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxNewImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNewImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNewImage.Image")));
            this.pictureBoxNewImage.Location = new System.Drawing.Point(10, 30);
            this.pictureBoxNewImage.Name = "pictureBoxNewImage";
            this.pictureBoxNewImage.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxNewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNewImage.TabIndex = 97;
            this.pictureBoxNewImage.TabStop = false;
            this.pictureBoxNewImage.Visible = false;
            // 
            // expUIButtonIconUnlock
            // 
            this.expUIButtonIconUnlock.BackColor = System.Drawing.Color.White;
            this.expUIButtonIconUnlock.BorderColor = System.Drawing.Color.Black;
            this.expUIButtonIconUnlock.BorderSize = 1;
            this.expUIButtonIconUnlock.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconUnlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonIconUnlock.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconUnlock.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonIconUnlock.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonIconUnlock.Image")));
            this.expUIButtonIconUnlock.Location = new System.Drawing.Point(136, 230);
            this.expUIButtonIconUnlock.Name = "expUIButtonIconUnlock";
            this.expUIButtonIconUnlock.Remember = false;
            this.expUIButtonIconUnlock.RememberColor = System.Drawing.Color.White;
            this.expUIButtonIconUnlock.ShowBorder = true;
            this.expUIButtonIconUnlock.Size = new System.Drawing.Size(35, 35);
            this.expUIButtonIconUnlock.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.expUIButtonIconUnlock.TabIndex = 95;
            this.expUIButtonIconUnlock.Text = "expUIButtonIcon1";
            this.toolTip1.SetToolTip(this.expUIButtonIconUnlock, "Разблокировать");
            this.expUIButtonIconUnlock.Visible = false;
            this.expUIButtonIconUnlock.Click += new System.EventHandler(this.ExpUIButtonIconUnlock_Click);
            this.expUIButtonIconUnlock.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // expUIButtonIconLogin
            // 
            this.expUIButtonIconLogin.BackColor = System.Drawing.Color.White;
            this.expUIButtonIconLogin.BorderColor = System.Drawing.Color.Black;
            this.expUIButtonIconLogin.BorderSize = 1;
            this.expUIButtonIconLogin.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonIconLogin.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconLogin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonIconLogin.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonIconLogin.Image")));
            this.expUIButtonIconLogin.Location = new System.Drawing.Point(94, 230);
            this.expUIButtonIconLogin.Name = "expUIButtonIconLogin";
            this.expUIButtonIconLogin.Remember = false;
            this.expUIButtonIconLogin.RememberColor = System.Drawing.Color.White;
            this.expUIButtonIconLogin.ShowBorder = true;
            this.expUIButtonIconLogin.Size = new System.Drawing.Size(35, 35);
            this.expUIButtonIconLogin.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.expUIButtonIconLogin.TabIndex = 94;
            this.expUIButtonIconLogin.Text = "expUIButtonIcon1";
            this.toolTip1.SetToolTip(this.expUIButtonIconLogin, "Авторизоваться");
            this.expUIButtonIconLogin.Click += new System.EventHandler(this.ExpUIButtonIconLogin_Click);
            this.expUIButtonIconLogin.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // expUIButtonIconSendMail
            // 
            this.expUIButtonIconSendMail.BackColor = System.Drawing.Color.White;
            this.expUIButtonIconSendMail.BorderColor = System.Drawing.Color.Black;
            this.expUIButtonIconSendMail.BorderSize = 1;
            this.expUIButtonIconSendMail.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconSendMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonIconSendMail.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconSendMail.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonIconSendMail.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonIconSendMail.Image")));
            this.expUIButtonIconSendMail.Location = new System.Drawing.Point(52, 230);
            this.expUIButtonIconSendMail.Name = "expUIButtonIconSendMail";
            this.expUIButtonIconSendMail.Remember = false;
            this.expUIButtonIconSendMail.RememberColor = System.Drawing.Color.White;
            this.expUIButtonIconSendMail.ShowBorder = true;
            this.expUIButtonIconSendMail.Size = new System.Drawing.Size(35, 35);
            this.expUIButtonIconSendMail.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.expUIButtonIconSendMail.TabIndex = 93;
            this.expUIButtonIconSendMail.Text = "expUIButtonIcon1";
            this.toolTip1.SetToolTip(this.expUIButtonIconSendMail, "Отправить письмо");
            this.expUIButtonIconSendMail.Click += new System.EventHandler(this.ExpUIButtonIconSendMail_Click);
            this.expUIButtonIconSendMail.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // expUIButtonIconSave
            // 
            this.expUIButtonIconSave.BackColor = System.Drawing.Color.White;
            this.expUIButtonIconSave.BorderColor = System.Drawing.Color.Black;
            this.expUIButtonIconSave.BorderSize = 1;
            this.expUIButtonIconSave.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonIconSave.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonIconSave.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonIconSave.Image")));
            this.expUIButtonIconSave.Location = new System.Drawing.Point(10, 230);
            this.expUIButtonIconSave.Name = "expUIButtonIconSave";
            this.expUIButtonIconSave.Remember = false;
            this.expUIButtonIconSave.RememberColor = System.Drawing.Color.White;
            this.expUIButtonIconSave.ShowBorder = true;
            this.expUIButtonIconSave.Size = new System.Drawing.Size(35, 35);
            this.expUIButtonIconSave.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.expUIButtonIconSave.TabIndex = 92;
            this.expUIButtonIconSave.Text = "expUIButtonIcon1";
            this.toolTip1.SetToolTip(this.expUIButtonIconSave, "Сохранить");
            this.expUIButtonIconSave.Click += new System.EventHandler(this.ExpUIButtonIconSave_Click);
            this.expUIButtonIconSave.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // DataSpecificUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 348);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxNewImage);
            this.Controls.Add(this.pictureBoxUserImage);
            this.Controls.Add(this.expUIButtonIconUnlock);
            this.Controls.Add(this.expUIButtonIconLogin);
            this.Controls.Add(this.expUIButtonIconSendMail);
            this.Controls.Add(this.expUIButtonIconSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxNumberUser);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxFatherUser);
            this.Controls.Add(this.textBoxNameUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLoginUser);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmailUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFamilyUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDepart);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(516, 350);
            this.MinimumSize = new System.Drawing.Size(516, 350);
            this.Name = "DataSpecificUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DataSpecificUserForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            this.MouseHover += new System.EventHandler(this.MouseHoverOff);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private ExpUI.dll.ExpUIButtonIcon buttonExit;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFatherUser;
        private System.Windows.Forms.TextBox textBoxNameUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLoginUser;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmailUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFamilyUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDepart;
        private System.Windows.Forms.MaskedTextBox textBoxNumberUser;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private ExpUI.dll.ExpUIButtonIcon expUIButtonIconSave;
        private ExpUI.dll.ExpUIButtonIcon expUIButtonIconSendMail;
        private ExpUI.dll.ExpUIButtonIcon expUIButtonIconLogin;
        private ExpUI.dll.ExpUIButtonIcon expUIButtonIconUnlock;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.PictureBox pictureBoxNewImage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}