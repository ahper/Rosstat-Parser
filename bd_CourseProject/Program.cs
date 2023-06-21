using bd_CourseProject.src.view;
using System;
using System.Windows.Forms;

namespace bd_CourseProject
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
            //Application.Run(new ConnectionDBWindow());
            Application.Run(new ExcelParsingWindow());
        }
    }
}
