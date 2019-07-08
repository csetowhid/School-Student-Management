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
using System.Windows.Shapes;

namespace School_Student_Management
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn(object sender, RoutedEventArgs e)
        {

        }

        private void btn_logout(object sender, RoutedEventArgs e)
        {
            
            MessageBoxResult result = MessageBox.Show("Do You Want To Exit", "Exit", MessageBoxButton.YesNo);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    System.Environment.Exit(0);
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Thank you!", "Exit");
                    break;
            }
        }

        private void btn_admission(object sender, RoutedEventArgs e)
        {
            admission ad = new admission();
            ad.Show();
            this.Close();
        }

        private void btn_update(object sender, RoutedEventArgs e)
        {
            update up = new update();
            up.Show();
            this.Close();
        }

        private void btn_delete(object sender, RoutedEventArgs e)
        {
            delete de = new delete();
            de.Show();
            this.Close();
        }

        private void btn_search(object sender, RoutedEventArgs e)
        {
            Student_Details sd = new Student_Details();
            sd.Show();
            this.Close();
        }
    }
}
