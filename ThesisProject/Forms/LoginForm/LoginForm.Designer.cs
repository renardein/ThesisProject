namespace ThesisProject
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.authLoginBox = new System.Windows.Forms.TextBox();
            this.authButton = new System.Windows.Forms.Button();
            this.authRoleBox = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.authPassBox = new System.Windows.Forms.TextBox();
            this.exitLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThesisProject.Properties.Resources.ktc_logo;
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // authLoginBox
            // 
            this.authLoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLoginBox.Location = new System.Drawing.Point(12, 209);
            this.authLoginBox.Name = "authLoginBox";
            this.authLoginBox.Size = new System.Drawing.Size(341, 29);
            this.authLoginBox.TabIndex = 1;
            // 
            // authButton
            // 
            this.authButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authButton.Location = new System.Drawing.Point(12, 374);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(341, 32);
            this.authButton.TabIndex = 3;
            this.authButton.Text = "Авторизоваться";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // authRoleBox
            // 
            this.authRoleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authRoleBox.FormattingEnabled = true;
            this.authRoleBox.Items.AddRange(new object[] {
            "Администратор",
            "Пользователь"});
            this.authRoleBox.Location = new System.Drawing.Point(12, 327);
            this.authRoleBox.Name = "authRoleBox";
            this.authRoleBox.Size = new System.Drawing.Size(341, 32);
            this.authRoleBox.TabIndex = 4;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLabel.Location = new System.Drawing.Point(9, 189);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(131, 17);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "Имя пользователя";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(9, 247);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(57, 17);
            this.passLabel.TabIndex = 6;
            this.passLabel.Text = "Пароль";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleLabel.Location = new System.Drawing.Point(9, 307);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(74, 17);
            this.roleLabel.TabIndex = 7;
            this.roleLabel.Text = "Войти как";
            // 
            // authPassBox
            // 
            this.authPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authPassBox.Location = new System.Drawing.Point(12, 267);
            this.authPassBox.Name = "authPassBox";
            this.authPassBox.Size = new System.Drawing.Size(341, 29);
            this.authPassBox.TabIndex = 8;
            // 
            // exitLink
            // 
            this.exitLink.Location = new System.Drawing.Point(12, 421);
            this.exitLink.Name = "exitLink";
            this.exitLink.Size = new System.Drawing.Size(341, 23);
            this.exitLink.TabIndex = 9;
            this.exitLink.TabStop = true;
            this.exitLink.Text = "Выйти";
            this.exitLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitLink_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 453);
            this.Controls.Add(this.exitLink);
            this.Controls.Add(this.authPassBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.authRoleBox);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.authLoginBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox authLoginBox;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.ComboBox authRoleBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox authPassBox;
        private System.Windows.Forms.LinkLabel exitLink;
    }
}

