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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rmUserButton = new System.Windows.Forms.Button();
            this.usersGrid = new System.Windows.Forms.DataGridView();
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
            this.MyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.currentUserStrip = new System.Windows.Forms.ToolStripSplitButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rmUserButton);
            this.groupBox2.Controls.Add(this.usersGrid);
            this.groupBox2.Location = new System.Drawing.Point(218, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пользователи";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rmUserButton
            // 
            this.rmUserButton.Location = new System.Drawing.Point(6, 126);
            this.rmUserButton.Name = "rmUserButton";
            this.rmUserButton.Size = new System.Drawing.Size(129, 23);
            this.rmUserButton.TabIndex = 10;
            this.rmUserButton.Text = "Удалить";
            this.rmUserButton.UseVisualStyleBackColor = true;
            this.rmUserButton.Click += new System.EventHandler(this.rmUserButton_Click);
            // 
            // usersGrid
            // 
            this.usersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersGrid.BackgroundColor = System.Drawing.Color.White;
            this.usersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Location = new System.Drawing.Point(6, 19);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.RowHeadersVisible = false;
            this.usersGrid.Size = new System.Drawing.Size(260, 101);
            this.usersGrid.TabIndex = 1;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
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
            // MyContextMenuStrip
            // 
            this.MyContextMenuStrip.Name = "MyContextMenuStrip";
            this.MyContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Сменить роль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserStrip,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(500, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // currentUserStrip
            // 
            this.currentUserStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.currentUserStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.currentUserStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.currentUserStrip.Image = ((System.Drawing.Image)(resources.GetObject("currentUserStrip.Image")));
            this.currentUserStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.currentUserStrip.Name = "currentUserStrip";
            this.currentUserStrip.Size = new System.Drawing.Size(67, 23);
            this.currentUserStrip.Text = "user";
            this.currentUserStrip.ButtonClick += new System.EventHandler(this.currentUserStrip_ButtonClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exitToolStripMenuItem.Text = "Выйти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripLabel1.Image = global::ThesisProject.Properties.Resources.ktc_logo;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(312, 23);
            this.toolStripLabel1.Text = "КГБПОУ \"Канский технологический колледж\"";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 190);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(516, 229);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip MyContextMenuStrip;
        private System.Windows.Forms.Button rmUserButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton currentUserStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}