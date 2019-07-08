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
using System.Data;
using System.Data.SqlClient;

namespace School_Student_Management
{
    /// <summary>
    /// Interaction logic for Student_Details.xaml
    /// </summary>
    public partial class Student_Details : Window
    {
        public Student_Details()
        {
            InitializeComponent();
        }

        private void search_btn(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(txt_roll.Text);
            string connectionstring = @"Data Source=DESKTOP-4FN44AO;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from dbo.student where roll="+a;
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();


            while (read.Read())
            {
                txt_details.Text = "Name : " + read[0].ToString();
                txt_details.Text += "\nRoll : " + read[1].ToString();
                txt_details.Text += "\nClass : " + read[2].ToString();
                txt_details.Text += "\nPhone : " + read[3].ToString();
                txt_details.Text += "\nGender : " + read[4].ToString();
                txt_details.Text += "\nReligion : " + read[5].ToString();
                txt_details.Text += "\nDate Of Birth : " + read[6].ToString();
                txt_details.Text += "\nAddress : " + read[7].ToString();
                txt_details.Text += "\n Blood Group : " + read[8].ToString();
            }

            sqlcon.Close();
        }

        

        private void btn_exit(object sender, RoutedEventArgs e)
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
    }
}
