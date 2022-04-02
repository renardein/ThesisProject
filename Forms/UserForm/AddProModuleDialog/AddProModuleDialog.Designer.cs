namespace ThesisProject.Forms.UserForm.AddProModuleDialog
{
    partial class AddProModuleDialog
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
            this.addPmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addPmTitleBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addPmButton
            // 
            this.addPmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addPmButton.Location = new System.Drawing.Point(20, 89);
            this.addPmButton.Name = "addPmButton";
            this.addPmButton.Size = new System.Drawing.Size(339, 23);
            this.addPmButton.TabIndex = 6;
            this.addPmButton.Text = "Добавить ПМ";
            this.addPmButton.UseVisualStyleBackColor = true;
            this.addPmButton.Click += new System.EventHandler(this.addPmButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавить ПМ";
            // 
            // addPmTitleBox
            // 
            this.addPmTitleBox.Location = new System.Drawing.Point(80, 51);
            this.addPmTitleBox.Name = "addPmTitleBox";
            this.addPmTitleBox.Size = new System.Drawing.Size(279, 20);
            this.addPmTitleBox.TabIndex = 7;
            // 
            // AddProModuleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 123);
            this.Controls.Add(this.addPmTitleBox);
            this.Controls.Add(this.addPmButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 162);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 162);
            this.Name = "AddProModuleDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить ПМ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPmButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addPmTitleBox;
    }
}