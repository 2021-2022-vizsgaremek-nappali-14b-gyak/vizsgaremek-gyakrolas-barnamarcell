using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vizsgaremek.Navigaton;
using Vizsgaremek.Pages;

namespace Vizsgaremek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            // Statikus osztály a Navigate
            // Eltárolja a nyító ablakot, hog yazon módosítani tudjuk a "page"-eket

            Navigate.mainwindow = this;

            // Létrehozzuk a nyitó "UserControl" (WelcomePage)
            WelcomePage welcomePage = new WelcomePage();
            // Megjelenik a WelcomePage
            Navigate.Navigation(welcomePage);
        }

        /// <summary>
        /// ListView elemen a bal egér gomb fel lett engedve
        /// </summary>
        /// <param name="sender">Lenyomtuk a bal egér gombot</param>
        /// <param name="e"></param>
        private void ListView_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ListView lvMenu = sender as ListView;
            //ListViewItem lvMenuItem = (ListViewItem)lvMenu.SelectedItem;
            ListViewItem lvMenuItem = lvMenu.SelectedItem as ListViewItem;

            if (lvMenuItem != null)
            {
                // x:Name tulajdonságot vizsgáljuk
                switch(lvMenuItem.Name)
                {
                    case "lviExit":
                            Close();
                        break;
                }
            }

        }
    }
}
