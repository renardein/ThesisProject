using System;
using System.Windows.Forms;

namespace ThesisProject
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        public static class FormDataExchange
        {
            public static string CurrentUser { get; set; }
        }
    }
}
