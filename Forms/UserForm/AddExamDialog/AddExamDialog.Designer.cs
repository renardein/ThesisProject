namespace ThesisProject.Forms.UserForm.AddExamDialog
{
    partial class AddExamDialog
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.criteriaFilenameBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.examDatetime = new System.Windows.Forms.DateTimePicker();
            this.addExamGroupBox = new System.Windows.Forms.ComboBox();
            this.openCriteriaFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addExamProModuleBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(16, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Критерии";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Модуль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Добавить экзамен";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Состав\r\nкомиссии";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 157);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 78);
            this.textBox1.TabIndex = 22;
            // 
            // criteriaFilenameBox
            // 
            this.criteriaFilenameBox.Location = new System.Drawing.Point(76, 131);
            this.criteriaFilenameBox.Name = "criteriaFilenameBox";
            this.criteriaFilenameBox.Size = new System.Drawing.Size(205, 20);
            this.criteriaFilenameBox.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 24;
            this.button2.Text = "Обзор";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // examDatetime
            // 
            this.examDatetime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.examDatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.examDatetime.Location = new System.Drawing.Point(76, 105);
            this.examDatetime.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.examDatetime.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.examDatetime.Name = "examDatetime";
            this.examDatetime.Size = new System.Drawing.Size(286, 20);
            this.examDatetime.TabIndex = 25;
            this.examDatetime.Value = new System.DateTime(2022, 4, 6, 18, 1, 0, 0);
            this.examDatetime.ValueChanged += new System.EventHandler(this.examDatetime_ValueChanged);
            // 
            // addExamGroupBox
            // 
            this.addExamGroupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addExamGroupBox.FormattingEnabled = true;
            this.addExamGroupBox.Location = new System.Drawing.Point(76, 78);
            this.addExamGroupBox.Name = "addExamGroupBox";
            this.addExamGroupBox.Size = new System.Drawing.Size(286, 21);
            this.addExamGroupBox.TabIndex = 26;
            // 
            // openCriteriaFileDialog
            // 
            this.openCriteriaFileDialog.FileName = "openCriteriaFileDialog";
            // 
            // addExamProModuleBox
            // 
            this.addExamProModuleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addExamProModuleBox.FormattingEnabled = true;
            this.addExamProModuleBox.Location = new System.Drawing.Point(77, 51);
            this.addExamProModuleBox.Name = "addExamProModuleBox";
            this.addExamProModuleBox.Size = new System.Drawing.Size(286, 21);
            this.addExamProModuleBox.TabIndex = 27;
            // 
            // AddExamDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 275);
            this.Controls.Add(this.addExamProModuleBox);
            this.Controls.Add(this.addExamGroupBox);
            this.Controls.Add(this.examDatetime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.criteriaFilenameBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddExamDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить экзамен";
            this.Load += new System.EventHandler(this.AddExamDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox criteriaFilenameBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker examDatetime;
        private System.Windows.Forms.ComboBox addExamGroupBox;
        private System.Windows.Forms.OpenFileDialog openCriteriaFileDialog;
        private System.Windows.Forms.ComboBox addExamProModuleBox;
    }
}