namespace ThesisProject.Forms.UserForm
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.currentUserStrip = new System.Windows.Forms.ToolStripSplitButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.examsPage = new System.Windows.Forms.TabPage();
            this.studentsPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.addGroupDialogOpen = new System.Windows.Forms.Button();
            this.groupGrid = new System.Windows.Forms.DataGridView();
            this.importGroupsButton = new System.Windows.Forms.Button();
            this.deleteAllGroups = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.studentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserStrip,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // currentUserStrip
            // 
            this.currentUserStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.currentUserStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.currentUserStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.currentUserStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.currentUserStrip.Image = ((System.Drawing.Image)(resources.GetObject("currentUserStrip.Image")));
            this.currentUserStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.currentUserStrip.Name = "currentUserStrip";
            this.currentUserStrip.Size = new System.Drawing.Size(51, 23);
            this.currentUserStrip.Text = "user";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripLabel1.Image = global::ThesisProject.Properties.Resources.ktc_logo;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(312, 23);
            this.toolStripLabel1.Text = "КГБПОУ \"Канский технологический колледж\"";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 23);
            this.toolStripLabel2.Text = "Вы вошли как:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.examsPage);
            this.tabControl1.Controls.Add(this.studentsPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 424);
            this.tabControl1.TabIndex = 1;
            // 
            // examsPage
            // 
            this.examsPage.Location = new System.Drawing.Point(4, 22);
            this.examsPage.Name = "examsPage";
            this.examsPage.Padding = new System.Windows.Forms.Padding(3);
            this.examsPage.Size = new System.Drawing.Size(792, 398);
            this.examsPage.TabIndex = 0;
            this.examsPage.Text = "Экзамены";
            this.examsPage.UseVisualStyleBackColor = true;
            // 
            // studentsPage
            // 
            this.studentsPage.Controls.Add(this.splitContainer1);
            this.studentsPage.Location = new System.Drawing.Point(4, 22);
            this.studentsPage.Name = "studentsPage";
            this.studentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentsPage.Size = new System.Drawing.Size(792, 398);
            this.studentsPage.TabIndex = 1;
            this.studentsPage.Text = "Студенты";
            this.studentsPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deleteGroupButton);
            this.splitContainer1.Panel1.Controls.Add(this.addGroupDialogOpen);
            this.splitContainer1.Panel1.Controls.Add(this.groupGrid);
            this.splitContainer1.Panel1.Controls.Add(this.importGroupsButton);
            this.splitContainer1.Panel1.Controls.Add(this.deleteAllGroups);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(786, 392);
            this.splitContainer1.SplitterDistance = 362;
            this.splitContainer1.TabIndex = 0;
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Location = new System.Drawing.Point(299, 37);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(60, 23);
            this.deleteGroupButton.TabIndex = 5;
            this.deleteGroupButton.Text = "Удалить";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // addGroupDialogOpen
            // 
            this.addGroupDialogOpen.Location = new System.Drawing.Point(7, 37);
            this.addGroupDialogOpen.Name = "addGroupDialogOpen";
            this.addGroupDialogOpen.Size = new System.Drawing.Size(75, 23);
            this.addGroupDialogOpen.TabIndex = 4;
            this.addGroupDialogOpen.Text = "Добавить";
            this.addGroupDialogOpen.UseVisualStyleBackColor = true;
            this.addGroupDialogOpen.Click += new System.EventHandler(this.addGroupDialogOpen_Click);
            // 
            // groupGrid
            // 
            this.groupGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupGrid.Location = new System.Drawing.Point(7, 66);
            this.groupGrid.Name = "groupGrid";
            this.groupGrid.RowHeadersVisible = false;
            this.groupGrid.Size = new System.Drawing.Size(352, 292);
            this.groupGrid.TabIndex = 3;
            this.groupGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupGrid_CellContentClick);
            // 
            // importGroupsButton
            // 
            this.importGroupsButton.Location = new System.Drawing.Point(88, 37);
            this.importGroupsButton.Name = "importGroupsButton";
            this.importGroupsButton.Size = new System.Drawing.Size(205, 23);
            this.importGroupsButton.TabIndex = 2;
            this.importGroupsButton.Text = "Импортирвоать группы из файла";
            this.importGroupsButton.UseVisualStyleBackColor = true;
            this.importGroupsButton.Click += new System.EventHandler(this.importGroupsButton_Click);
            // 
            // deleteAllGroups
            // 
            this.deleteAllGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteAllGroups.Location = new System.Drawing.Point(7, 364);
            this.deleteAllGroups.Name = "deleteAllGroups";
            this.deleteAllGroups.Size = new System.Drawing.Size(352, 23);
            this.deleteAllGroups.TabIndex = 1;
            this.deleteAllGroups.Text = "Удалить тестовые данные";
            this.deleteAllGroups.UseVisualStyleBackColor = true;
            this.deleteAllGroups.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Группы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Студенты";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.studentsPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton currentUserStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage examsPage;
        private System.Windows.Forms.TabPage studentsPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog studentFileOpenDialog;
        private System.Windows.Forms.Button importGroupsButton;
        private System.Windows.Forms.Button deleteAllGroups;
        private System.Windows.Forms.DataGridView groupGrid;
        private System.Windows.Forms.Button addGroupDialogOpen;
        private System.Windows.Forms.Button deleteGroupButton;
    }
}