using System;
using System.Windows.Forms;

namespace PawTrace
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // or your main form name
        }
    }
}