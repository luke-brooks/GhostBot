using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GhostBotApp
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var userConfigOptions = ConfigService.LoadConfigData();

            Application.Run(new GhostBotGui(userConfigOptions));
        }
    }
}
