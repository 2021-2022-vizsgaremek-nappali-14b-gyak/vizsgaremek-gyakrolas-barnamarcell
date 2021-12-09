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
        /// <summary>
        /// eltároljuk a MainWindow-t, hogy tudjunk váltani ablakok között (Pages)
        /// </summary>
        public static MainWindow mainwindow;

        /// <summary>
        /// Egy új ablakra vált
        /// </summary>
        /// <param name="userControl">Erre az ablakra váltunk</param>
        public static void Navigation(UserControl userControl)
        {
            mainwindow.PageContent.Children.Add(userControl);

        }
    }
}
