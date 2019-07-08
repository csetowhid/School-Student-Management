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
    /// Interaction logic for admission.xaml
    /// </summary>
    public partial class admission : Window
    {
        public admission()
        {
            InitializeComponent();
        }

        private void btn_click_ca(object sender, RoutedEventArgs e)
        {
            string name,phn,gender,dob,add,bld;
            int roll, clas;
            name = txt_name.Text;
            roll = int.Parse(txt_roll.Text);
            clas = int.Parse(txt_class.Text);
            phn = txt_phone.Text;
            add = txt_address.Text;
            bld = txt_bg.Text;
            if (rdo_male.IsChecked.Value == true)
            {
                gender = "Male";
            }
            else {
                gender = "Female";
            }
            var a = (ComboBoxItem)cmd_reg.SelectedItem;
            string rel = (String)a.Content;
            dob = dp_dob.SelectedDate.Value.ToShortDateString();
           

          // MessageBox.Show(name+ "\n"+ roll + "\n" +clas + "\n" +phn + "\n" + gender 
               // + "\n" +rel + "\n" + dob + "\n" + add + "\n" + bld);

            string connectionstring = @"Data Source=DESKTOP-4FN44AO;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into student(name,roll,clas,phn,gen,rel,dob,address,bld) values(@a,@b,@c,@d,@e,@f,@g,@h,@i)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@b", SqlDbType.Int).Value = roll;
            cmd.Parameters.Add("@c", SqlDbType.Int).Value = clas;
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = phn;
            cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@f", SqlDbType.VarChar).Value = rel;
            cmd.Parameters.Add("@g", SqlDbType.Date).Value = dob;
            cmd.Parameters.Add("@h", SqlDbType.VarChar).Value = add;
            cmd.Parameters.Add("@i", SqlDbType.VarChar).Value = bld;

            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Admitted");
            sqlcon.Close();

        }

        private void btn_home(object sender, RoutedEventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Close();
        }

        private void btn_click_reset(object sender, RoutedEventArgs e)
        {
            txt_name.Clear();
            txt_roll.Clear();
            txt_class.Clear();
            txt_phone.Clear();
            txt_address.Clear();
            txt_bg.Clear();
            cmd_reg.Text="";
            dp_dob.Text = "";


         }

    }
}
