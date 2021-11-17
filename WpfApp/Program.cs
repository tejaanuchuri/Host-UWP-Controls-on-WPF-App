using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp
{
    public class Program
    {
        [System.STAThreadAttribute()]
        public static void Main()
        {
            using (new MyUWPApp.App())
            {
                WpfApp.App app = new WpfApp.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
