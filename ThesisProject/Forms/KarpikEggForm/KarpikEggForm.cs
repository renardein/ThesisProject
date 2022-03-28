using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisProject.Forms.KarpikEggForm
{
    public partial class KarpikEggForm : Form
    {
        public KarpikEggForm()
        {
            InitializeComponent();
        }

        private void KarpikEggForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
