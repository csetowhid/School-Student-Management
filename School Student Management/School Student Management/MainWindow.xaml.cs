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

namespace School_Student_Management
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

        private void btn_exit_click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result= MessageBox.Show("Do You Want To Exit", "Exit", MessageBoxButton.YesNo);

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

        private void btn_login_click(object sender, RoutedEventArgs e)
        {
            Home bw = new Home();
            if(username.Text=="towhid" && password.Password=="1234")
            {
                bw.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dont Match", "Login Status", MessageBoxButton.OKCancel);
                username.Text = "";
                password.Password = "";
            }
        }

        private void btn_student(object sender, RoutedEventArgs e)
        {
            Student_Details sd = new Student_Details();
            sd.Show();
            this.Close();
        }
    }
}
