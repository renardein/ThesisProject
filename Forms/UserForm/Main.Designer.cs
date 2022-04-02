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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.currentUserStrip = new System.Windows.Forms.ToolStripSplitButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.examsPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.deletePmButton = new System.Windows.Forms.Button();
            this.addProModuleDialogOpen = new System.Windows.Forms.Button();
            this.pmGrid = new System.Windows.Forms.DataGridView();
            this.importPmButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.examGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.studentsPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.addGroupDialogOpen = new System.Windows.Forms.Button();
            this.groupGrid = new System.Windows.Forms.DataGridView();
            this.importGroupsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.importStudentsButton = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.deleteAllGroupsAndStudents = new System.Windows.Forms.Button();
            this.addStudentDialogOpen = new System.Windows.Forms.Button();
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.examsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pmGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examGrid)).BeginInit();
            this.studentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1181, 26);
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1181, 649);
            this.tabControl1.TabIndex = 1;
            // 
            // examsPage
            // 
            this.examsPage.Controls.Add(this.splitContainer2);
            this.examsPage.Location = new System.Drawing.Point(4, 22);
            this.examsPage.Name = "examsPage";
            this.examsPage.Padding = new System.Windows.Forms.Padding(3);
            this.examsPage.Size = new System.Drawing.Size(1173, 623);
            this.examsPage.TabIndex = 0;
            this.examsPage.Text = "Экзамены";
            this.examsPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.deletePmButton);
            this.splitContainer2.Panel1.Controls.Add(this.addProModuleDialogOpen);
            this.splitContainer2.Panel1.Controls.Add(this.pmGrid);
            this.splitContainer2.Panel1.Controls.Add(this.importPmButton);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Panel2.Controls.Add(this.button5);
            this.splitContainer2.Panel2.Controls.Add(this.button6);
            this.splitContainer2.Panel2.Controls.Add(this.button7);
            this.splitContainer2.Panel2.Controls.Add(this.examGrid);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Size = new System.Drawing.Size(1167, 617);
            this.splitContainer2.SplitterDistance = 577;
            this.splitContainer2.TabIndex = 1;
            // 
            // deletePmButton
            // 
            this.deletePmButton.Location = new System.Drawing.Point(88, 37);
            this.deletePmButton.Name = "deletePmButton";
            this.deletePmButton.Size = new System.Drawing.Size(75, 23);
            this.deletePmButton.TabIndex = 5;
            this.deletePmButton.Text = "Удалить";
            this.deletePmButton.UseVisualStyleBackColor = true;
            this.deletePmButton.Click += new System.EventHandler(this.deletePmButton_Click);
            // 
            // addProModuleDialogOpen
            // 
            this.addProModuleDialogOpen.Cursor = System.Windows.Forms.Cursors.Default;
            this.addProModuleDialogOpen.Location = new System.Drawing.Point(7, 37);
            this.addProModuleDialogOpen.Name = "addProModuleDialogOpen";
            this.addProModuleDialogOpen.Size = new System.Drawing.Size(75, 23);
            this.addProModuleDialogOpen.TabIndex = 4;
            this.addProModuleDialogOpen.Text = "Добавить";
            this.addProModuleDialogOpen.UseVisualStyleBackColor = true;
            this.addProModuleDialogOpen.Click += new System.EventHandler(this.addProModuleDialogOpen_Click);
            // 
            // pmGrid
            // 
            this.pmGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pmGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pmGrid.Location = new System.Drawing.Point(7, 66);
            this.pmGrid.Name = "pmGrid";
            this.pmGrid.RowHeadersVisible = false;
            this.pmGrid.Size = new System.Drawing.Size(567, 546);
            this.pmGrid.TabIndex = 3;
            // 
            // importPmButton
            // 
            this.importPmButton.Location = new System.Drawing.Point(169, 37);
            this.importPmButton.Name = "importPmButton";
            this.importPmButton.Size = new System.Drawing.Size(75, 23);
            this.importPmButton.TabIndex = 2;
            this.importPmButton.Text = "Импорт";
            this.importPmButton.UseVisualStyleBackColor = true;
            this.importPmButton.Click += new System.EventHandler(this.importPmButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Модули";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(169, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Импорт";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(88, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.Location = new System.Drawing.Point(7, 589);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(574, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Удалить тестовые данные";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // examGrid
            // 
            this.examGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.examGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examGrid.Location = new System.Drawing.Point(7, 66);
            this.examGrid.Name = "examGrid";
            this.examGrid.RowHeadersVisible = false;
            this.examGrid.Size = new System.Drawing.Size(574, 517);
            this.examGrid.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Экзамены";
            // 
            // studentsPage
            // 
            this.studentsPage.Controls.Add(this.splitContainer1);
            this.studentsPage.Location = new System.Drawing.Point(4, 22);
            this.studentsPage.Name = "studentsPage";
            this.studentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentsPage.Size = new System.Drawing.Size(1173, 623);
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.importStudentsButton);
            this.splitContainer1.Panel2.Controls.Add(this.deleteStudentButton);
            this.splitContainer1.Panel2.Controls.Add(this.deleteAllGroupsAndStudents);
            this.splitContainer1.Panel2.Controls.Add(this.addStudentDialogOpen);
            this.splitContainer1.Panel2.Controls.Add(this.studentGrid);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1167, 617);
            this.splitContainer1.SplitterDistance = 577;
            this.splitContainer1.TabIndex = 0;
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Location = new System.Drawing.Point(88, 37);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(75, 23);
            this.deleteGroupButton.TabIndex = 5;
            this.deleteGroupButton.Text = "Удалить";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // addGroupDialogOpen
            // 
            this.addGroupDialogOpen.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.groupGrid.Size = new System.Drawing.Size(567, 546);
            this.groupGrid.TabIndex = 3;
            this.groupGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.groupGrid_CellMouseClick);
            // 
            // importGroupsButton
            // 
            this.importGroupsButton.Location = new System.Drawing.Point(169, 37);
            this.importGroupsButton.Name = "importGroupsButton";
            this.importGroupsButton.Size = new System.Drawing.Size(75, 23);
            this.importGroupsButton.TabIndex = 2;
            this.importGroupsButton.Text = "Импорт";
            this.importGroupsButton.UseVisualStyleBackColor = true;
            this.importGroupsButton.Click += new System.EventHandler(this.importGroupsButton_Click);
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
            // importStudentsButton
            // 
            this.importStudentsButton.Location = new System.Drawing.Point(169, 37);
            this.importStudentsButton.Name = "importStudentsButton";
            this.importStudentsButton.Size = new System.Drawing.Size(75, 23);
            this.importStudentsButton.TabIndex = 6;
            this.importStudentsButton.Text = "Импорт";
            this.importStudentsButton.UseVisualStyleBackColor = true;
            this.importStudentsButton.Click += new System.EventHandler(this.importStudentsButton_Click);
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Location = new System.Drawing.Point(88, 37);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(75, 23);
            this.deleteStudentButton.TabIndex = 9;
            this.deleteStudentButton.Text = "Удалить";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            // 
            // deleteAllGroupsAndStudents
            // 
            this.deleteAllGroupsAndStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteAllGroupsAndStudents.Location = new System.Drawing.Point(7, 589);
            this.deleteAllGroupsAndStudents.Name = "deleteAllGroupsAndStudents";
            this.deleteAllGroupsAndStudents.Size = new System.Drawing.Size(574, 23);
            this.deleteAllGroupsAndStudents.TabIndex = 8;
            this.deleteAllGroupsAndStudents.Text = "Удалить тестовые данные";
            this.deleteAllGroupsAndStudents.UseVisualStyleBackColor = true;
            this.deleteAllGroupsAndStudents.Click += new System.EventHandler(this.deleteAllGroupsAndStudents_Click);
            // 
            // addStudentDialogOpen
            // 
            this.addStudentDialogOpen.Location = new System.Drawing.Point(7, 37);
            this.addStudentDialogOpen.Name = "addStudentDialogOpen";
            this.addStudentDialogOpen.Size = new System.Drawing.Size(75, 23);
            this.addStudentDialogOpen.TabIndex = 7;
            this.addStudentDialogOpen.Text = "Добавить";
            this.addStudentDialogOpen.UseVisualStyleBackColor = true;
            this.addStudentDialogOpen.Click += new System.EventHandler(this.addStudentDialogOpen_Click);
            // 
            // studentGrid
            // 
            this.studentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Location = new System.Drawing.Point(7, 66);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.RowHeadersVisible = false;
            this.studentGrid.Size = new System.Drawing.Size(574, 517);
            this.studentGrid.TabIndex = 4;
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1173, 623);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Модули";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1173, 623);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ведомости";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1173, 623);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Критерии";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 675);
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
            this.examsPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pmGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examGrid)).EndInit();
            this.studentsPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog txtFileOpenDialog;
        private System.Windows.Forms.Button importGroupsButton;
        private System.Windows.Forms.DataGridView groupGrid;
        private System.Windows.Forms.Button addGroupDialogOpen;
        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView studentGrid;
        private System.Windows.Forms.Button addStudentDialogOpen;
        private System.Windows.Forms.Button deleteAllGroupsAndStudents;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button importStudentsButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button deletePmButton;
        private System.Windows.Forms.Button addProModuleDialogOpen;
        private System.Windows.Forms.DataGridView pmGrid;
        private System.Windows.Forms.Button importPmButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView examGrid;
        private System.Windows.Forms.Label label7;
    }
}