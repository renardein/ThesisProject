using System;
using System.Windows.Forms;

namespace ThesisProject.Forms.UserForm.AddProModuleDialog
{
    public partial class AddProModuleDialog : Form
    {
        internal string PmName;
        public AddProModuleDialog()
        {
            InitializeComponent();
        }

        private void addPmButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(addPmTitleBox.Text))
                PmName = addPmTitleBox.Text;
            if (string.IsNullOrEmpty(addPmTitleBox.Text))
            {
                MessageBox.Show("Проверьте заполненность полей");
                DialogResult = DialogResult.None;
                return;
            }
        }
    }
}
