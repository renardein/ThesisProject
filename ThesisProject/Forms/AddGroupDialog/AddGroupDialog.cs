using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisProject.Forms.AddGroupDialog
{
    public partial class AddGroupDialog : Form
    {
        public AddGroupDialog()
        {
            InitializeComponent();
        }


        private void addGroupButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addGroupTitleBox.Text))
                MessageBox.Show("Проверьте заполненность полей");
            else
                Program.FormDataExchange.NewGroupString = addGroupTitleBox.Text;
        }
    }
}
