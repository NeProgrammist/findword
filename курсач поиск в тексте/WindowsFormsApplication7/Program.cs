using System;
using System.Windows.Forms;

namespace Kurs
{
    public class gg
    {
        public string s;
        public string ks;
    }

    static class Program 
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
