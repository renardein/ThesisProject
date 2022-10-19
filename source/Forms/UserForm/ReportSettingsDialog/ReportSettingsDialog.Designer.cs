namespace ThesisProject.Forms.UserForm.ReportSettingsDialog
{
    partial class ReportSettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportSettingsDialog));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addExamProModuleBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reportGroupList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportStudentList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(26, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cоздать ведомость";
            // 
            // addExamProModuleBox
            // 
            this.addExamProModuleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addExamProModuleBox.FormattingEnabled = true;
            this.addExamProModuleBox.Items.AddRange(new object[] {
            "Пустая ведомость",
            "Заполненная ведомость"});
            this.addExamProModuleBox.Location = new System.Drawing.Point(86, 52);
            this.addExamProModuleBox.Name = "addExamProModuleBox";
            this.addExamProModuleBox.Size = new System.Drawing.Size(286, 21);
            this.addExamProModuleBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Вид отчета";
            // 
            // reportGroupList
            // 
            this.reportGroupList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportGroupList.FormattingEnabled = true;
            this.reportGroupList.Location = new System.Drawing.Point(86, 106);
            this.reportGroupList.Name = "reportGroupList";
            this.reportGroupList.Size = new System.Drawing.Size(286, 21);
            this.reportGroupList.TabIndex = 31;
            this.reportGroupList.SelectedIndexChanged += new System.EventHandler(this.reportGroupList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Группа";
            // 
            // reportStudentList
            // 
            this.reportStudentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportStudentList.FormattingEnabled = true;
            this.reportStudentList.Location = new System.Drawing.Point(86, 133);
            this.reportStudentList.Name = "reportStudentList";
            this.reportStudentList.Size = new System.Drawing.Size(286, 21);
            this.reportStudentList.TabIndex = 33;
            this.reportStudentList.SelectedIndexChanged += new System.EventHandler(this.reportStudentList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Студент";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Отчет по студенту",
            "Отчет по группе",
            "Отчет по критериям"});
            this.comboBox3.Location = new System.Drawing.Point(86, 79);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(286, 21);
            this.comboBox3.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Тип отчета";
            // 
            // ReportSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 200);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportStudentList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportGroupList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addExamProModuleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 239);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(398, 239);
            this.Name = "ReportSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создать ведомость";
            this.Load += new System.EventHandler(this.ReportSettingsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addExamProModuleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox reportGroupList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox reportStudentList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
    }
}