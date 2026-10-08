namespace SupportDesk.forms
{
    partial class UserDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDataForm));
            this.pictureBoxNewImage = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFatherUser = new System.Windows.Forms.TextBox();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.buttonSaveDataUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new ExpUI.dll.ExpUIButtonIcon();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxNumberUser = new System.Windows.Forms.MaskedTextBox();
            this.expUIToggleControlDublicateNotificationForEmail = new ExpUI.dll.ExpUIToggleControl();
            this.expUIToggleControlSystemNotification = new ExpUI.dll.ExpUIToggleControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.pictureBoxNewImage.TabIndex = 67;
            this.pictureBoxNewImage.TabStop = false;
            this.pictureBoxNewImage.Visible = false;
            this.pictureBoxNewImage.Click += new System.EventHandler(this.PictureBoxNewImage_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(10, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 15);
            this.label10.TabIndex = 66;
            this.label10.Text = "Нет изображения";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Visible = false;
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUserImage.Location = new System.Drawing.Point(10, 30);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserImage.TabIndex = 65;
            this.pictureBoxUserImage.TabStop = false;
            this.pictureBoxUserImage.MouseHover += new System.EventHandler(this.PictureBoxUserImage_MouseHover);
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangePass.FlatAppearance.BorderSize = 0;
            this.buttonChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePass.ForeColor = System.Drawing.Color.White;
            this.buttonChangePass.Location = new System.Drawing.Point(276, 318);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(244, 30);
            this.buttonChangePass.TabIndex = 63;
            this.buttonChangePass.Text = "Сменить пароль";
            this.buttonChangePass.UseVisualStyleBackColor = false;
            this.buttonChangePass.Click += new System.EventHandler(this.ButtonChangePass_Click);
            this.buttonChangePass.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Выберите файл";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(151, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 62;
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
            this.textBoxFatherUser.Size = new System.Drawing.Size(244, 22);
            this.textBoxFatherUser.TabIndex = 48;
            this.textBoxFatherUser.TabStop = false;
            this.textBoxFatherUser.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // textBoxNameUser
            // 
            this.textBoxNameUser.BackColor = System.Drawing.Color.White;
            this.textBoxNameUser.Enabled = false;
            this.textBoxNameUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameUser.Location = new System.Drawing.Point(276, 62);
            this.textBoxNameUser.Name = "textBoxNameUser";
            this.textBoxNameUser.Size = new System.Drawing.Size(244, 22);
            this.textBoxNameUser.TabIndex = 47;
            this.textBoxNameUser.TabStop = false;
            this.textBoxNameUser.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(151, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 61;
            this.label8.Text = "Имя:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(151, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 60;
            this.label7.Text = "Пароль:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(151, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 59;
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
            this.textBoxLoginUser.ReadOnly = true;
            this.textBoxLoginUser.Size = new System.Drawing.Size(244, 22);
            this.textBoxLoginUser.TabIndex = 55;
            this.textBoxLoginUser.TabStop = false;
            this.textBoxLoginUser.MouseHover += new System.EventHandler(this.MouseHoverOff);
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
            this.comboBoxPosition.Size = new System.Drawing.Size(244, 24);
            this.comboBoxPosition.TabIndex = 53;
            this.comboBoxPosition.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(151, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 57;
            this.label5.Text = "Должность:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(151, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "Отдел:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(151, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 54;
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
            this.textBoxEmailUser.Size = new System.Drawing.Size(244, 22);
            this.textBoxEmailUser.TabIndex = 51;
            this.textBoxEmailUser.TabStop = false;
            this.textBoxEmailUser.TextChanged += new System.EventHandler(this.TextBoxEmailUser_TextChanged);
            this.textBoxEmailUser.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(151, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 49;
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
            this.textBoxFamilyUser.Size = new System.Drawing.Size(244, 22);
            this.textBoxFamilyUser.TabIndex = 45;
            this.textBoxFamilyUser.TabStop = false;
            this.textBoxFamilyUser.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 46;
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
            this.comboBoxDepart.Size = new System.Drawing.Size(244, 24);
            this.comboBoxDepart.TabIndex = 52;
            this.comboBoxDepart.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // buttonSaveDataUser
            // 
            this.buttonSaveDataUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSaveDataUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveDataUser.FlatAppearance.BorderSize = 0;
            this.buttonSaveDataUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDataUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveDataUser.ForeColor = System.Drawing.Color.White;
            this.buttonSaveDataUser.Location = new System.Drawing.Point(10, 318);
            this.buttonSaveDataUser.Name = "buttonSaveDataUser";
            this.buttonSaveDataUser.Size = new System.Drawing.Size(160, 30);
            this.buttonSaveDataUser.TabIndex = 58;
            this.buttonSaveDataUser.Text = "Сохранить";
            this.buttonSaveDataUser.UseVisualStyleBackColor = false;
            this.buttonSaveDataUser.Click += new System.EventHandler(this.ButtonSaveDataUser_Click);
            this.buttonSaveDataUser.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 20);
            this.panel2.TabIndex = 68;
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
            this.buttonExit.Location = new System.Drawing.Point(510, 0);
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
            this.label11.Size = new System.Drawing.Size(530, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Личный кабинет";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            this.label11.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(151, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 23);
            this.label12.TabIndex = 70;
            this.label12.Text = "Пол:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.Color.White;
            this.comboBoxGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(276, 126);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(244, 24);
            this.comboBoxGender.TabIndex = 69;
            this.comboBoxGender.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(76, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(444, 23);
            this.label13.TabIndex = 73;
            this.label13.Text = "Использовать системные уведомления ВЫКЛ/ВКЛ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(76, 390);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(444, 23);
            this.label14.TabIndex = 74;
            this.label14.Text = "Дублировать уведомления на почту* ВЫКЛ/ВКЛ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNumberUser
            // 
            this.textBoxNumberUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberUser.Location = new System.Drawing.Point(276, 158);
            this.textBoxNumberUser.Mask = "8(999)000-0000";
            this.textBoxNumberUser.Name = "textBoxNumberUser";
            this.textBoxNumberUser.Size = new System.Drawing.Size(244, 22);
            this.textBoxNumberUser.TabIndex = 76;
            this.textBoxNumberUser.MouseHover += new System.EventHandler(this.MouseHoverOff);
            // 
            // expUIToggleControlDublicateNotificationForEmail
            // 
            this.expUIToggleControlDublicateNotificationForEmail.ColorMainOFF = System.Drawing.Color.Red;
            this.expUIToggleControlDublicateNotificationForEmail.ColorMainON = System.Drawing.Color.Green;
            this.expUIToggleControlDublicateNotificationForEmail.ColorOFF = System.Drawing.Color.White;
            this.expUIToggleControlDublicateNotificationForEmail.ColorON = System.Drawing.Color.White;
            this.expUIToggleControlDublicateNotificationForEmail.ColorTextOFF = System.Drawing.Color.Black;
            this.expUIToggleControlDublicateNotificationForEmail.ColorTextON = System.Drawing.Color.White;
            this.expUIToggleControlDublicateNotificationForEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIToggleControlDublicateNotificationForEmail.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIToggleControlDublicateNotificationForEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.expUIToggleControlDublicateNotificationForEmail.Location = new System.Drawing.Point(10, 388);
            this.expUIToggleControlDublicateNotificationForEmail.Name = "expUIToggleControlDublicateNotificationForEmail";
            this.expUIToggleControlDublicateNotificationForEmail.Size = new System.Drawing.Size(60, 25);
            this.expUIToggleControlDublicateNotificationForEmail.SolidStyle = true;
            this.expUIToggleControlDublicateNotificationForEmail.TabIndex = 72;
            this.expUIToggleControlDublicateNotificationForEmail.Text = "expUIToggleControl2";
            this.expUIToggleControlDublicateNotificationForEmail.UseText = false;
            this.expUIToggleControlDublicateNotificationForEmail.Click += new System.EventHandler(this.ExpUIToggleControlDublicateNotificationForEmail_Click);
            // 
            // expUIToggleControlSystemNotification
            // 
            this.expUIToggleControlSystemNotification.ColorMainOFF = System.Drawing.Color.Red;
            this.expUIToggleControlSystemNotification.ColorMainON = System.Drawing.Color.Green;
            this.expUIToggleControlSystemNotification.ColorOFF = System.Drawing.Color.White;
            this.expUIToggleControlSystemNotification.ColorON = System.Drawing.Color.White;
            this.expUIToggleControlSystemNotification.ColorTextOFF = System.Drawing.Color.Black;
            this.expUIToggleControlSystemNotification.ColorTextON = System.Drawing.Color.White;
            this.expUIToggleControlSystemNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIToggleControlSystemNotification.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIToggleControlSystemNotification.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.expUIToggleControlSystemNotification.Location = new System.Drawing.Point(10, 358);
            this.expUIToggleControlSystemNotification.Name = "expUIToggleControlSystemNotification";
            this.expUIToggleControlSystemNotification.Size = new System.Drawing.Size(60, 25);
            this.expUIToggleControlSystemNotification.SolidStyle = true;
            this.expUIToggleControlSystemNotification.TabIndex = 71;
            this.expUIToggleControlSystemNotification.Text = "expUIToggleControl1";
            this.expUIToggleControlSystemNotification.UseText = false;
            this.expUIToggleControlSystemNotification.Click += new System.EventHandler(this.ExpUIToggleControlSystemNotification_Click);
            // 
            // UserDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 423);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxNumberUser);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.expUIToggleControlDublicateNotificationForEmail);
            this.Controls.Add(this.expUIToggleControlSystemNotification);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonSaveDataUser);
            this.Controls.Add(this.pictureBoxNewImage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBoxUserImage);
            this.Controls.Add(this.buttonChangePass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxFatherUser);
            this.Controls.Add(this.textBoxNameUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(530, 425);
            this.MinimumSize = new System.Drawing.Size(530, 425);
            this.Name = "UserDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserDataForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            this.MouseHover += new System.EventHandler(this.MouseHoverOff);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxNewImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFatherUser;
        private System.Windows.Forms.TextBox textBoxNameUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Button buttonSaveDataUser;
        private System.Windows.Forms.Panel panel2;
        private ExpUI.dll.ExpUIButtonIcon buttonExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private ExpUI.dll.ExpUIToggleControl expUIToggleControlSystemNotification;
        private ExpUI.dll.ExpUIToggleControl expUIToggleControlDublicateNotificationForEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox textBoxNumberUser;
    }
}