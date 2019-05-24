using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace CourseWork
{
    /// <summary>
    /// Логика взаимодействия для Admin_template.xaml
    /// </summary>
    public partial class Admin_template : Window
    {
        public string CoolerDb;
        public string CPUDb;
        public string VideoDb;
        public string OperDb;
        public string PowerDb;
        public string HardDb;
        public string MotherDb;
        public string PriceDb = "500$";

        public Admin_template()
        {
            InitializeComponent();
        }
        private void Cooler_Click(object sender, RoutedEventArgs e)
        {
            if (Cooler.Content == FindResource("Coolerbw"))
            {
                Menu.Width = 500;
                CoolerData.Opacity = 1d;
                Radio1.Opacity = 1d;
                Radio2.Opacity = 1d;
                Radio3.Opacity = 1d;
                Radio4.Opacity = 1d;
            }
            else
            {
                CoolerDb = null;
                Cooler.Content = FindResource("Coolerbw");
            }
        }

        private void CPU_Click(object sender, RoutedEventArgs e)
        {
            if (CPU.Content == FindResource("Cpubw"))
            {
                Menu.Width = 500;
                CPUData.Opacity = 1d;
                Radio1.Opacity = 1d;
                Radio2.Opacity = 1d;
                Radio3.Opacity = 1d;
                Radio4.Opacity = 1d;
            }
            else
            {
                CPUDb = null;
                CPU.Content = FindResource("Cpubw");
            }
        }

        private void Video_Click(object sender, RoutedEventArgs e)
        {
            if (Video.Content == FindResource("Videobw"))
            {
                Menu.Width = 500;
                VideoData.Opacity = 1d;
                Radio1.Opacity = 1d;
                Radio2.Opacity = 1d;
                Radio3.Opacity = 1d;
                Radio4.Opacity = 1d;
            }
            else
            {
                VideoDb = null;
                Video.Content = FindResource("Videobw");
            }
        }

        private void Oper_Click(object sender, RoutedEventArgs e)
        {
            if (Oper.Content == FindResource("Operbw"))
            {
                Menu.Width = 500;
                OperData.Opacity = 1d;
                Radio1.Opacity = 1d;
                Radio2.Opacity = 1d;
                Radio3.Opacity = 1d;
                Radio4.Opacity = 1d;
            }
            else
            {
                OperDb = null;
                Oper.Content = FindResource("Operbw");
            }
        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            if (Power.Content == FindResource("Powerbw"))
            {
                Menu.Width = 500;
                PowerData.Opacity = 1d;
                Radio1.Opacity = 1d;
                Radio2.Opacity = 1d;
                Radio3.Opacity = 1d;
                Radio4.Opacity = 1d;
            }
            else
            {
                PowerDb = null;
                Power.Content = FindResource("Powerbw");
            }
        }

        private void Hard_Click(object sender, RoutedEventArgs e)
        {
            if (Hard.Content == FindResource("Hardbw"))
            {
                Menu.Width = 500;
                HardData.Opacity = 1d;
                Radio1.Opacity = 1d;
                Radio2.Opacity = 1d;
                Radio3.Opacity = 1d;
                Radio4.Opacity = 1d;
            }
            else
            {
                HardDb = null;
                Hard.Content = FindResource("Hardbw");
            }
        }

        private void Mother_Click(object sender, RoutedEventArgs e)
        {
            if (Mother.Content == FindResource("Motherbw"))
            {
                Menu.Width = 500;
                MotherData.Opacity = 1d;
                Radio1.Opacity = 1d;
                Radio2.Opacity = 1d;
                Radio3.Opacity = 1d;
                Radio4.Opacity = 1d;
            }
            else
            {
                MotherDb = null;
                Mother.Content = FindResource("Motherbw");
            }
        }

        private void Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            if (CoolerData.Opacity == 1d)
            {
                if (Radio1.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select cooler_model from Coolers where cooler_id=1";
                    CoolerDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio2.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select cooler_model from Coolers where cooler_id=2";
                    CoolerDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio3.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select cooler_model from Coolers where cooler_id=3";
                    CoolerDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio4.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select cooler_model from Coolers where cooler_id=4";
                    CoolerDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
            }
            if (CPUData.Opacity == 1d)
            {
                if (Radio1.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select cpu_model from CPUs where cpu_id=1";
                    CPUDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio2.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select cpu_model from CPUs where cpu_id=2";
                    CPUDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio3.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select cpu_model from CPUs where cpu_id=3";
                    CPUDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio4.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select cpu_model from CPUs where cpu_id=4";
                    CPUDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
            }
            if (VideoData.Opacity == 1d)
            {
                if (Radio1.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select video_model from Videos where video_id=1";
                    VideoDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio2.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select video_model from Videos where video_id=2";
                    VideoDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio3.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select video_model from Videos where video_id=3";
                    VideoDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio4.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select video_model from Videos where video_id=4";
                    VideoDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
            }
            if (OperData.Opacity == 1d)
            {
                if (Radio1.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select oper_model from Opers where oper_id=1";
                    OperDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio2.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select oper_model from Opers where oper_id=2";
                    OperDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio3.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select oper_model from Opers where oper_id=3";
                    OperDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio4.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select oper_model from Opers where oper_id=4";
                    OperDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
            }
            if (PowerData.Opacity == 1d)
            {
                if (Radio1.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select power_model from Powers where power_id=1";
                    PowerDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio2.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select power_model from Powers where power_id=2";
                    PowerDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio3.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select power_model from Powers where power_id=3";
                    PowerDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio4.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select power_model from Powers where power_id=4";
                    PowerDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
            }
            if (HardData.Opacity == 1d)
            {
                if (Radio1.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select hard_model from Hards where hard_id=1";
                    HardDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio2.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select hard_model from Hards where hard_id=2";
                    HardDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio3.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select hard_model from Hards where hard_id=3";
                    HardDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio4.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select hard_model from Hards where hard_id=4";
                    HardDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
            }
            if (MotherData.Opacity == 1d)
            {
                if (Radio1.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select mother_model from Mothers where mother_id=1";
                    MotherDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio2.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select mother_model from Mothers where mother_id=2";
                    MotherDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio3.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select mother_model from Mothers where mother_id=3";
                    MotherDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
                if (Radio4.IsChecked == true)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "select mother_model from Mothers where mother_id=4";
                    MotherDb = ((string)cmd.ExecuteScalar());
                    connection.Close();
                }
            }
            Menu.Width = 30;
            CoolerData.Opacity = 0d;
            CPUData.Opacity = 0d;
            VideoData.Opacity = 0d;
            OperData.Opacity = 0d;
            PowerData.Opacity = 0d;
            HardData.Opacity = 0d;
            MotherData.Opacity = 0d;
            Radio1.Opacity = 0d;
            Radio2.Opacity = 0d;
            Radio3.Opacity = 0d;
            Radio4.Opacity = 0d;
            Radio1.IsChecked = false;
            Radio2.IsChecked = false;
            Radio3.IsChecked = false;
            Radio4.IsChecked = false;
        }

        private void CoolerData_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Coolers", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Coolers");

            CoolerData.ItemsSource = ds.Tables["Coolers"].DefaultView;
            con.Close();
        }

        private void Radio_Checked(object sender, RoutedEventArgs e)
        {
            if (CoolerData.Opacity == 1d)
            {
                Cooler.Content = FindResource("Coolercolor");
            }
            if (CPUData.Opacity == 1d)
            {
                CPU.Content = FindResource("Cpucolor");
            }
            if (VideoData.Opacity == 1d)
            {
                Video.Content = FindResource("Videocolor");
            }
            if (OperData.Opacity == 1d)
            {
                Oper.Content = FindResource("Opercolor");
            }
            if (PowerData.Opacity == 1d)
            {
                Power.Content = FindResource("Powercolor");
            }
            if (HardData.Opacity == 1d)
            {
                Hard.Content = FindResource("Hardcolor");
            }
            if (MotherData.Opacity == 1d)
            {
                Mother.Content = FindResource("Mothercolor");
            }
        }

        private void CPUData_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from CPUs", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "CPUs");

            CPUData.ItemsSource = ds.Tables["CPUs"].DefaultView;
            con.Close();
        }

        private void VideoData_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Videos", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Videos");

            VideoData.ItemsSource = ds.Tables["Videos"].DefaultView;
            con.Close();
        }

        private void OperData_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Opers", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Opers");

            OperData.ItemsSource = ds.Tables["Opers"].DefaultView;
            con.Close();
        }

        private void PowerData_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Powers", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Powers");

            PowerData.ItemsSource = ds.Tables["Powers"].DefaultView;
            con.Close();
        }

        private void HardData_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Hards", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Hards");

            HardData.ItemsSource = ds.Tables["Hards"].DefaultView;
            con.Close();
        }

        private void MotherData_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Mothers", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Mothers");

            MotherData.ItemsSource = ds.Tables["Mothers"].DefaultView;
            con.Close();
        }

        private void S1_Click(object sender, RoutedEventArgs e)
        {
                if (Home.Opacity == 1d)
                {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                SqlCommand cmd = new SqlCommand("Insert into Home (cooler, cpu, video, oper, power, hard, mother, price) values ('" + CoolerDb + "', '" + CPUDb + "', '" + VideoDb + "', '" + OperDb + "', '" + PowerDb + "', '" + HardDb + "', '" + MotherDb + "', '" + PriceDb + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
                }
                if (Work.Opacity == 1d)
                {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                SqlCommand cmd = new SqlCommand("Insert into Work (cooler, cpu, video, oper, power, hard, mother, price) values ('" + CoolerDb + "', '" + CPUDb + "', '" + VideoDb + "', '" + OperDb + "', '" + PowerDb + "', '" + HardDb + "', '" + MotherDb + "', '" + PriceDb + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
            }
                if (Game.Opacity == 1d)
                {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                SqlCommand cmd = new SqlCommand("Insert into Game (cooler, cpu, video, oper, power, hard, mother, price) values ('" + CoolerDb + "', '" + CPUDb + "', '" + VideoDb + "', '" + OperDb + "', '" + PowerDb + "', '" + HardDb + "', '" + MotherDb + "', '" + PriceDb + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Admin_choose win = new Admin_choose();
            win.Show();
            this.Close();
        }

        private void UserChange_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            if(Work.Opacity == 0.7d && Game.Opacity == 0.7d)
            {
                Home.Opacity = 1d;
            }
            else
            {
                Work.Opacity = 0.7d;
                Game.Opacity = 0.7d;
                Home.Opacity = 1d;
            }
        }

        private void Work_Click(object sender, RoutedEventArgs e)
        {
            if (Home.Opacity == 0.7d && Game.Opacity == 0.7d)
            {
                Work.Opacity = 1d;
            }
            else
            {
                Home.Opacity = 0.7d;
                Game.Opacity = 0.7d;
                Work.Opacity = 1d;
            }
        }

        private void Game_Click(object sender, RoutedEventArgs e)
        {
            if (Work.Opacity == 0.7d && Home.Opacity == 0.7d)
            {
                Game.Opacity = 1d;
            }
            else
            {
                Work.Opacity = 0.7d;
                Home.Opacity = 0.7d;
                Game.Opacity = 1d;
            }
        }
    }
}
