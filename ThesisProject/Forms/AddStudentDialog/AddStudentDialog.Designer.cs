namespace ThesisProject.Forms.AddStudentDialog
{
    partial class AddStudentDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addStudentLastBox = new System.Windows.Forms.TextBox();
            this.addStudentFirstBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addStudentMiddleBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addStudentGroupBox = new System.Windows.Forms.ComboBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ktkCisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ktkCisDataSet = new ThesisProject.ktkCisDataSet();
            this.groupTableAdapter = new ThesisProject.ktkCisDataSetTableAdapters.GroupTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktkCisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktkCisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить студента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // addStudentLastBox
            // 
            this.addStudentLastBox.Location = new System.Drawing.Point(76, 51);
            this.addStudentLastBox.Name = "addStudentLastBox";
            this.addStudentLastBox.Size = new System.Drawing.Size(286, 20);
            this.addStudentLastBox.TabIndex = 3;
            // 
            // addStudentFirstBox
            // 
            this.addStudentFirstBox.Location = new System.Drawing.Point(76, 77);
            this.addStudentFirstBox.Name = "addStudentFirstBox";
            this.addStudentFirstBox.Size = new System.Drawing.Size(286, 20);
            this.addStudentFirstBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя";
            // 
            // addStudentMiddleBox
            // 
            this.addStudentMiddleBox.Location = new System.Drawing.Point(76, 103);
            this.addStudentMiddleBox.Name = "addStudentMiddleBox";
            this.addStudentMiddleBox.Size = new System.Drawing.Size(286, 20);
            this.addStudentMiddleBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Группа";
            // 
            // addStudentGroupBox
            // 
            this.addStudentGroupBox.DataSource = this.groupBindingSource;
            this.addStudentGroupBox.DisplayMember = "Title";
            this.addStudentGroupBox.FormattingEnabled = true;
            this.addStudentGroupBox.Location = new System.Drawing.Point(76, 131);
            this.addStudentGroupBox.Name = "addStudentGroupBox";
            this.addStudentGroupBox.Size = new System.Drawing.Size(286, 21);
            this.addStudentGroupBox.TabIndex = 9;
            this.addStudentGroupBox.ValueMember = "GroupId";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.ktkCisDataSetBindingSource;
            // 
            // ktkCisDataSetBindingSource
            // 
            this.ktkCisDataSetBindingSource.DataSource = this.ktkCisDataSet;
            this.ktkCisDataSetBindingSource.Position = 0;
            // 
            // ktkCisDataSet
            // 
            this.ktkCisDataSet.DataSetName = "ktkCisDataSet";
            this.ktkCisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(16, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddStudentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addStudentGroupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addStudentMiddleBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addStudentFirstBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addStudentLastBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentDialog";
            this.Text = "AddStudentDialog";
            this.Load += new System.EventHandler(this.AddStudentDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktkCisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktkCisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addStudentLastBox;
        private System.Windows.Forms.TextBox addStudentFirstBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addStudentMiddleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addStudentGroupBox;
        private System.Windows.Forms.BindingSource ktkCisDataSetBindingSource;
        private ktkCisDataSet ktkCisDataSet;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private ktkCisDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}