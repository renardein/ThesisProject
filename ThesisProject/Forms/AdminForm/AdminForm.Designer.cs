namespace ThesisProject.Forms.AdminForm
{
    partial class AdminForm
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.Пользователь = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пароль = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Роль = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.regUserRole = new System.Windows.Forms.ComboBox();
            this.addUser = new System.Windows.Forms.Button();
            this.regPasswordConfirm = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rmUserButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rmUserButton);
            this.groupBox2.Controls.Add(this.usersGrid);
            this.groupBox2.Location = new System.Drawing.Point(215, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пользователи";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // usersGrid
            // 
            this.usersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersGrid.BackgroundColor = System.Drawing.Color.White;
            this.usersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Пользователь,
            this.Пароль,
            this.Роль});
            this.usersGrid.Location = new System.Drawing.Point(6, 19);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.RowHeadersVisible = false;
            this.usersGrid.Size = new System.Drawing.Size(260, 101);
            this.usersGrid.TabIndex = 1;
            // 
            // Пользователь
            // 
            this.Пользователь.HeaderText = "usernameCol";
            this.Пользователь.Name = "Пользователь";
            this.Пользователь.ReadOnly = true;
            this.Пользователь.Visible = false;
            // 
            // Пароль
            // 
            this.Пароль.HeaderText = "passCol";
            this.Пароль.Name = "Пароль";
            this.Пароль.ReadOnly = true;
            this.Пароль.Visible = false;
            // 
            // Роль
            // 
            this.Роль.HeaderText = "roleCol";
            this.Роль.Name = "Роль";
            this.Роль.ReadOnly = true;
            this.Роль.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.regUserRole);
            this.groupBox1.Controls.Add(this.addUser);
            this.groupBox1.Controls.Add(this.regPasswordConfirm);
            this.groupBox1.Controls.Add(this.regPassword);
            this.groupBox1.Controls.Add(this.regUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить пользователя";
            // 
            // regUserRole
            // 
            this.regUserRole.FormattingEnabled = true;
            this.regUserRole.Items.AddRange(new object[] {
            "Администратор",
            "Пользователь"});
            this.regUserRole.Location = new System.Drawing.Point(55, 99);
            this.regUserRole.Name = "regUserRole";
            this.regUserRole.Size = new System.Drawing.Size(139, 21);
            this.regUserRole.TabIndex = 9;
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(10, 126);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(184, 23);
            this.addUser.TabIndex = 8;
            this.addUser.Text = "Добавить";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // regPasswordConfirm
            // 
            this.regPasswordConfirm.Location = new System.Drawing.Point(55, 72);
            this.regPasswordConfirm.Name = "regPasswordConfirm";
            this.regPasswordConfirm.Size = new System.Drawing.Size(139, 20);
            this.regPasswordConfirm.TabIndex = 6;
            // 
            // regPassword
            // 
            this.regPassword.Location = new System.Drawing.Point(55, 46);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(139, 20);
            this.regPassword.TabIndex = 5;
            // 
            // regUsername
            // 
            this.regUsername.Location = new System.Drawing.Point(55, 20);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(139, 20);
            this.regUsername.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Повтор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Роль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(3, 7);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(81, 13);
            this.currentUserLabel.TabIndex = 0;
            this.currentUserLabel.Text = "Вы вошли как:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(757, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Выйти";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.currentUserLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 28);
            this.panel1.TabIndex = 1;
            // 
            // MyContextMenuStrip
            // 
            this.MyContextMenuStrip.Name = "MyContextMenuStrip";
            this.MyContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // rmUserButton
            // 
            this.rmUserButton.Location = new System.Drawing.Point(6, 126);
            this.rmUserButton.Name = "rmUserButton";
            this.rmUserButton.Size = new System.Drawing.Size(260, 23);
            this.rmUserButton.TabIndex = 10;
            this.rmUserButton.Text = "Удалить";
            this.rmUserButton.UseVisualStyleBackColor = true;
            this.rmUserButton.Click += new System.EventHandler(this.rmUserButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox regUserRole;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.TextBox regPasswordConfirm;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.TextBox regUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пользователь;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пароль;
        private System.Windows.Forms.DataGridViewTextBoxColumn Роль;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip MyContextMenuStrip;
        private System.Windows.Forms.Button rmUserButton;
    }
}