
namespace SupportDesk
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new ExpUI.dll.ExpUIButtonIcon();
            this.label1 = new System.Windows.Forms.Label();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.CheckRemember = new System.Windows.Forms.CheckBox();
            this.ButtonRegUser = new System.Windows.Forms.Button();
            this.ButtonEnterLogin = new System.Windows.Forms.Button();
            this.expUIButtonIconCheckUnlock = new ExpUI.dll.ExpUIButtonIcon();
            this.TextBoxPassword = new MaterialUIPack.dll.textBoxUI();
            this.TextBoxLogin = new MaterialUIPack.dll.textBoxUI();
            this.expUIButtonIconCheckLock = new ExpUI.dll.ExpUIButtonIcon();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 225);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 20);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
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
            this.buttonExit.Location = new System.Drawing.Point(239, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Remember = false;
            this.buttonExit.RememberColor = System.Drawing.Color.White;
            this.buttonExit.ShowBorder = false;
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.buttonExit.TabIndex = 41;
            this.buttonExit.Text = "expUIButtonIcon1";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgotPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForgotPassword.Location = new System.Drawing.Point(362, 141);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(125, 20);
            this.labelForgotPassword.TabIndex = 16;
            this.labelForgotPassword.Text = "Забыли пароль?";
            this.labelForgotPassword.Click += new System.EventHandler(this.LabelForgotPassword_Click);
            // 
            // CheckRemember
            // 
            this.CheckRemember.AutoSize = true;
            this.CheckRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckRemember.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckRemember.Location = new System.Drawing.Point(231, 140);
            this.CheckRemember.Name = "CheckRemember";
            this.CheckRemember.Size = new System.Drawing.Size(124, 20);
            this.CheckRemember.TabIndex = 15;
            this.CheckRemember.Text = "Запомнить меня";
            this.CheckRemember.UseVisualStyleBackColor = true;
            this.CheckRemember.CheckedChanged += new System.EventHandler(this.CheckRemember_CheckedChanged);
            // 
            // ButtonRegUser
            // 
            this.ButtonRegUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonRegUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegUser.FlatAppearance.BorderSize = 0;
            this.ButtonRegUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRegUser.ForeColor = System.Drawing.Color.White;
            this.ButtonRegUser.Location = new System.Drawing.Point(352, 170);
            this.ButtonRegUser.Name = "ButtonRegUser";
            this.ButtonRegUser.Size = new System.Drawing.Size(119, 30);
            this.ButtonRegUser.TabIndex = 14;
            this.ButtonRegUser.Text = "Регистрация";
            this.ButtonRegUser.UseVisualStyleBackColor = false;
            this.ButtonRegUser.Click += new System.EventHandler(this.ButtonRegUser_Click);
            // 
            // ButtonEnterLogin
            // 
            this.ButtonEnterLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonEnterLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEnterLogin.Enabled = false;
            this.ButtonEnterLogin.FlatAppearance.BorderSize = 0;
            this.ButtonEnterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEnterLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEnterLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonEnterLogin.Location = new System.Drawing.Point(231, 170);
            this.ButtonEnterLogin.Name = "ButtonEnterLogin";
            this.ButtonEnterLogin.Size = new System.Drawing.Size(115, 30);
            this.ButtonEnterLogin.TabIndex = 13;
            this.ButtonEnterLogin.Text = "Войти";
            this.ButtonEnterLogin.UseVisualStyleBackColor = false;
            this.ButtonEnterLogin.Click += new System.EventHandler(this.ButtonEnterLogin_Click);
            // 
            // expUIButtonIconCheckUnlock
            // 
            this.expUIButtonIconCheckUnlock.BackColor = System.Drawing.Color.White;
            this.expUIButtonIconCheckUnlock.BorderColor = System.Drawing.Color.Black;
            this.expUIButtonIconCheckUnlock.BorderSize = 1;
            this.expUIButtonIconCheckUnlock.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconCheckUnlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonIconCheckUnlock.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconCheckUnlock.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonIconCheckUnlock.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonIconCheckUnlock.Image")));
            this.expUIButtonIconCheckUnlock.Location = new System.Drawing.Point(438, 99);
            this.expUIButtonIconCheckUnlock.Name = "expUIButtonIconCheckUnlock";
            this.expUIButtonIconCheckUnlock.Remember = false;
            this.expUIButtonIconCheckUnlock.RememberColor = System.Drawing.Color.White;
            this.expUIButtonIconCheckUnlock.ShowBorder = false;
            this.expUIButtonIconCheckUnlock.Size = new System.Drawing.Size(32, 32);
            this.expUIButtonIconCheckUnlock.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.expUIButtonIconCheckUnlock.TabIndex = 17;
            this.expUIButtonIconCheckUnlock.TabStop = false;
            this.expUIButtonIconCheckUnlock.Text = "expUIButtonIcon1";
            this.expUIButtonIconCheckUnlock.Visible = false;
            this.expUIButtonIconCheckUnlock.Click += new System.EventHandler(this.ExpUIButtonIconCheckUnlock_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.White;
            this.TextBoxPassword.BorderColor = System.Drawing.Color.Black;
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.FontColor = System.Drawing.Color.Black;
            this.TextBoxPassword.FontTextPreview = new System.Drawing.Font("Arial", 9.75F);
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPassword.Location = new System.Drawing.Point(231, 90);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(240, 42);
            this.TextBoxPassword.TabIndex = 12;
            this.TextBoxPassword.TextPreview = "Ваш пароль";
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.BackColor = System.Drawing.Color.White;
            this.TextBoxLogin.BorderColor = System.Drawing.Color.Black;
            this.TextBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLogin.FontColor = System.Drawing.Color.Black;
            this.TextBoxLogin.FontTextPreview = new System.Drawing.Font("Arial", 9.75F);
            this.TextBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.TextBoxLogin.Location = new System.Drawing.Point(231, 35);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(240, 42);
            this.TextBoxLogin.TabIndex = 11;
            this.TextBoxLogin.TextPreview = "Ваш логин";
            this.TextBoxLogin.UseSystemPasswordChar = false;
            this.TextBoxLogin.TextChanged += new System.EventHandler(this.TextBoxLogin_TextChanged);
            // 
            // expUIButtonIconCheckLock
            // 
            this.expUIButtonIconCheckLock.BackColor = System.Drawing.Color.White;
            this.expUIButtonIconCheckLock.BorderColor = System.Drawing.Color.Black;
            this.expUIButtonIconCheckLock.BorderSize = 1;
            this.expUIButtonIconCheckLock.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconCheckLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonIconCheckLock.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonIconCheckLock.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonIconCheckLock.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonIconCheckLock.Image")));
            this.expUIButtonIconCheckLock.Location = new System.Drawing.Point(438, 99);
            this.expUIButtonIconCheckLock.Name = "expUIButtonIconCheckLock";
            this.expUIButtonIconCheckLock.Remember = false;
            this.expUIButtonIconCheckLock.RememberColor = System.Drawing.Color.White;
            this.expUIButtonIconCheckLock.ShowBorder = false;
            this.expUIButtonIconCheckLock.Size = new System.Drawing.Size(32, 32);
            this.expUIButtonIconCheckLock.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.expUIButtonIconCheckLock.TabIndex = 18;
            this.expUIButtonIconCheckLock.TabStop = false;
            this.expUIButtonIconCheckLock.Text = "expUIButtonIcon1";
            this.expUIButtonIconCheckLock.Click += new System.EventHandler(this.ExpUIButtonIconCheckLock_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 223);
            this.ControlBox = false;
            this.Controls.Add(this.expUIButtonIconCheckLock);
            this.Controls.Add(this.expUIButtonIconCheckUnlock);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.CheckRemember);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.ButtonRegUser);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.ButtonEnterLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(485, 225);
            this.MinimumSize = new System.Drawing.Size(485, 225);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private ExpUI.dll.ExpUIButtonIcon buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.CheckBox CheckRemember;
        private MaterialUIPack.dll.textBoxUI TextBoxPassword;
        private System.Windows.Forms.Button ButtonRegUser;
        private MaterialUIPack.dll.textBoxUI TextBoxLogin;
        private System.Windows.Forms.Button ButtonEnterLogin;
        private ExpUI.dll.ExpUIButtonIcon expUIButtonIconCheckUnlock;
        private ExpUI.dll.ExpUIButtonIcon expUIButtonIconCheckLock;
    }
}