using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DrivingSchoolManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonFechar_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;

            //GridBody.Margin { Left = 300; }
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridBody.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "Home":
                    usc = new UserControlHome();
                    GridBody.Children.Add(usc);
                    break;
                case "Vehicles":
                    usc = new VehicleControl();
                    GridBody.Children.Add(usc);
                    break;
                case "Students":
                    usc = new VehicleControl();
                    GridBody.Children.Add(usc);
                    break;
                case "Settings":
                    usc = new VehicleControl();
                    GridBody.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }
    }
}
