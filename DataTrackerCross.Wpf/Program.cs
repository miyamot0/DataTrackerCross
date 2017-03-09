using System;
using Eto;
using Eto.Forms;

namespace DataTrackerCross.Wpf
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            new Application(Platforms.Wpf).Run(new MainForm());
        }
    }
}
