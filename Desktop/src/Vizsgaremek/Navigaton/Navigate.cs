using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Vizsgaremek.Navigaton
{
     public class Navigate
    {
        public static MainWindow mainwindow;

        public static void Navigation(UserControl userControl)
        {
            mainwindow.PageContent.Children.Add(userControl);

        }
    }
}
