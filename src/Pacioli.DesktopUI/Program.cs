using System;
using System.Windows.Forms;

namespace Pacioli.DesktopUI
{
    public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IoC.Init(args);
            var mainForm = IoC.GetService<MainForm>();

            Application.Run(mainForm);
        }
    }
}
