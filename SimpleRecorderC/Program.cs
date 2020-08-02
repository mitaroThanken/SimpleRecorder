using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRecorderC
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
