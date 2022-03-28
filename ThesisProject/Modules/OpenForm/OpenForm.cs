using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ThesisProject.Modules.OpenForm
{
    internal class OpenForm
    {
        public static void AdminForm()
        {
            Forms.AdminForm.AdminForm af = new Forms.AdminForm.AdminForm();
            af.Show();
        }
        public static void UserForm()
        {
            Forms.UserForm.UserForm uf = new Forms.UserForm.UserForm();
            uf.ShowDialog();
        }
        public static void KarpikEgg()
        {
            Forms.KarpikEggForm.KarpikEggForm egg = new Forms.KarpikEggForm.KarpikEggForm();
            egg.Show();
        }
    }
}
