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
using System.Windows.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace CourseWork
{
    /// <summary>
    /// Логика взаимодействия для Templates.xaml
    /// </summary>
    public partial class Templates : Window
    {
        public string CoolerDb;
        public string CPUDb;
        public string VideoDb;
        public string OperDb;
        public string PowerDb;
        public string HardDb;
        public string MotherDb;
        public string PriceDb;

        public Templates()
        {
            InitializeComponent();

            CreateParalaxBackground();
            CreateParalaxBackground2();
            CreateParalax();

            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 30);
            dispatcherTimer.Tick += UpdateParalaxBackground;
            dispatcherTimer.Tick += UpdateParalaxBackground2;
            dispatcherTimer.Tick += UpdateParalax;
            dispatcherTimer.Start();
        }

        private void D1_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DomEl.Opacity = .75d;
        }

        private void D1_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DomEl.Opacity = .25d;
        }

        private void D1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Radio1.Opacity = 1d;
            Radio2.Opacity = 1d;
            Radio3.Opacity = 1d;
            HomeData.Opacity = 1d;
            HomeData.Height = 380;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Home", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Home");

            HomeData.ItemsSource = ds.Tables["Home"].DefaultView;
            con.Close();
        }

        private void W1_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            WorkEl.Opacity = .75d;
        }

        private void W1_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            WorkEl.Opacity = .25d;
        }

        private void W1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Radio1.Opacity = 1d;
            Radio2.Opacity = 1d;
            Radio3.Opacity = 1d;
            WorkData.Opacity = 1d;
            WorkData.Height = 380;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Work", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Work");

            WorkData.ItemsSource = ds.Tables["Work"].DefaultView;
            con.Close();
        }

        private void G1_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            GameEl.Opacity = .75d;
        }

        private void G1_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            GameEl.Opacity = .25d;
        }

        private void G1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Radio1.Opacity = 1d;
            Radio2.Opacity = 1d;
            Radio3.Opacity = 1d;
            GameData.Opacity = 1d;
            GameData.Height = 380;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Game", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Game");

            GameData.ItemsSource = ds.Tables["Game"].DefaultView;
            con.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            choose win = new choose();
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
            if (HomeData.Opacity == 1d || WorkData.Opacity == 1d || GameData.Opacity == 1d)
            {
                if (HomeData.Opacity == 1d)
                {
                    if (Radio1.IsChecked == true)
                    {
                        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "select cooler from Home where id_temp=1";
                        CoolerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select cpu from Home where id_temp=1";
                        CPUDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select video from Home where id_temp=1";
                        VideoDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select oper from Home where id_temp=1";
                        OperDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select power from Home where id_temp=1";
                        PowerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select hard from Home where id_temp=1";
                        HardDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select mother from Home where id_temp=1";
                        MotherDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select price from Home where id_temp=1";
                        PriceDb = ((string)cmd.ExecuteScalar());
                        string path = "template.txt";
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine("Cooler: " + CoolerDb);
                        sw.WriteLine("CPU: " + CPUDb);
                        sw.WriteLine("Video: " + VideoDb);
                        sw.WriteLine("Oper: " + OperDb);
                        sw.WriteLine("Power: " + PowerDb);
                        sw.WriteLine("Hard: " + HardDb);
                        sw.WriteLine("Mother: " + MotherDb);
                        sw.WriteLine("Price: " + PriceDb);
                        sw.Close();
                        Process.Start("notepad.exe", path);
                        connection.Close();
                    }
                    if (Radio2.IsChecked == true)
                    {
                        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "select cooler from Home where id_temp=2";
                        CoolerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select cpu from Home where id_temp=2";
                        CPUDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select video from Home where id_temp=2";
                        VideoDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select oper from Home where id_temp=2";
                        OperDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select power from Home where id_temp=2";
                        PowerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select hard from Home where id_temp=2";
                        HardDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select mother from Home where id_temp=2";
                        MotherDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select price from Home where id_temp=2";
                        PriceDb = ((string)cmd.ExecuteScalar());
                        string path = "template.txt";
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine("Cooler: " + CoolerDb);
                        sw.WriteLine("CPU: " + CPUDb);
                        sw.WriteLine("Video: " + VideoDb);
                        sw.WriteLine("Oper: " + OperDb);
                        sw.WriteLine("Power: " + PowerDb);
                        sw.WriteLine("Hard: " + HardDb);
                        sw.WriteLine("Mother: " + MotherDb);
                        sw.WriteLine("Price: " + PriceDb);
                        sw.Close();
                        Process.Start("notepad.exe", path);
                        connection.Close();
                    }
                    if (Radio3.IsChecked == true)
                    {
                        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "select cooler from Home where id_temp=3";
                        CoolerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select cpu from Home where id_temp=3";
                        CPUDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select video from Home where id_temp=3";
                        VideoDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select oper from Home where id_temp=3";
                        OperDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select power from Home where id_temp=3";
                        PowerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select hard from Home where id_temp=3";
                        HardDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select mother from Home where id_temp=3";
                        MotherDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select price from Home where id_temp=3";
                        PriceDb = ((string)cmd.ExecuteScalar());
                        string path = "template.txt";
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine("Cooler: " + CoolerDb);
                        sw.WriteLine("CPU: " + CPUDb);
                        sw.WriteLine("Video: " + VideoDb);
                        sw.WriteLine("Oper: " + OperDb);
                        sw.WriteLine("Power: " + PowerDb);
                        sw.WriteLine("Hard: " + HardDb);
                        sw.WriteLine("Mother: " + MotherDb);
                        sw.WriteLine("Price: " + PriceDb);
                        sw.Close();
                        Process.Start("notepad.exe", path);
                        connection.Close();
                    }
                    HomeData.Opacity = 0d;
                    HomeData.Height = 30;
                }
                if (WorkData.Opacity == 1d)
                {
                    if (Radio1.IsChecked == true)
                    {
                        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "select cooler from Work where id_temp=1";
                        CoolerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select cpu from Work where id_temp=1";
                        CPUDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select video from Work where id_temp=1";
                        VideoDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select oper from Work where id_temp=1";
                        OperDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select power from Work where id_temp=1";
                        PowerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select hard from Work where id_temp=1";
                        HardDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select mother from Work where id_temp=1";
                        MotherDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select price from Work where id_temp=1";
                        PriceDb = ((string)cmd.ExecuteScalar());
                        string path = "template.txt";
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine("Cooler: " + CoolerDb);
                        sw.WriteLine("CPU: " + CPUDb);
                        sw.WriteLine("Video: " + VideoDb);
                        sw.WriteLine("Oper: " + OperDb);
                        sw.WriteLine("Power: " + PowerDb);
                        sw.WriteLine("Hard: " + HardDb);
                        sw.WriteLine("Mother: " + MotherDb);
                        sw.WriteLine("Price: " + PriceDb);
                        sw.Close();
                        Process.Start("notepad.exe", path);
                        connection.Close();
                    }
                    if (Radio2.IsChecked == true)
                    {
                        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "select cooler from Work where id_temp=2";
                        CoolerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select cpu from Work where id_temp=2";
                        CPUDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select video from Work where id_temp=2";
                        VideoDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select oper from Work where id_temp=2";
                        OperDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select power from Work where id_temp=2";
                        PowerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select hard from Work where id_temp=2";
                        HardDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select mother from Work where id_temp=2";
                        MotherDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select price from Work where id_temp=2";
                        PriceDb = ((string)cmd.ExecuteScalar());
                        string path = "template.txt";
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine("Cooler: " + CoolerDb);
                        sw.WriteLine("CPU: " + CPUDb);
                        sw.WriteLine("Video: " + VideoDb);
                        sw.WriteLine("Oper: " + OperDb);
                        sw.WriteLine("Power: " + PowerDb);
                        sw.WriteLine("Hard: " + HardDb);
                        sw.WriteLine("Mother: " + MotherDb);
                        sw.WriteLine("Price: " + PriceDb);
                        sw.Close();
                        Process.Start("notepad.exe", path);
                        connection.Close();
                    }
                    if (Radio3.IsChecked == true)
                    {
                        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "select cooler from Work where id_temp=3";
                        CoolerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select cpu from Work where id_temp=3";
                        CPUDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select video from Work where id_temp=3";
                        VideoDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select oper from Work where id_temp=3";
                        OperDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select power from Work where id_temp=3";
                        PowerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select hard from Work where id_temp=3";
                        HardDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select mother from Work where id_temp=3";
                        MotherDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select price from Work where id_temp=3";
                        PriceDb = ((string)cmd.ExecuteScalar());
                        string path = "template.txt";
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine("Cooler: " + CoolerDb);
                        sw.WriteLine("CPU: " + CPUDb);
                        sw.WriteLine("Video: " + VideoDb);
                        sw.WriteLine("Oper: " + OperDb);
                        sw.WriteLine("Power: " + PowerDb);
                        sw.WriteLine("Hard: " + HardDb);
                        sw.WriteLine("Mother: " + MotherDb);
                        sw.WriteLine("Price: " + PriceDb);
                        sw.Close();
                        Process.Start("notepad.exe", path);
                        connection.Close();
                    }
                    WorkData.Opacity = 0d;
                    WorkData.Height = 30;
                }
                if (GameData.Opacity == 1d)
                {
                    if (Radio1.IsChecked == true)
                    {
                        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "select cooler from Game where id_temp=1";
                        CoolerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select cpu from Game where id_temp=1";
                        CPUDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select video from Game where id_temp=1";
                        VideoDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select oper from Game where id_temp=1";
                        OperDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select power from Game where id_temp=1";
                        PowerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select hard from Game where id_temp=1";
                        HardDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select mother from Game where id_temp=1";
                        MotherDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select price from Game where id_temp=1";
                        PriceDb = ((string)cmd.ExecuteScalar());
                        string path = "template.txt";
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine("Cooler: " + CoolerDb);
                        sw.WriteLine("CPU: " + CPUDb);
                        sw.WriteLine("Video: " + VideoDb);
                        sw.WriteLine("Oper: " + OperDb);
                        sw.WriteLine("Power: " + PowerDb);
                        sw.WriteLine("Hard: " + HardDb);
                        sw.WriteLine("Mother: " + MotherDb);
                        sw.WriteLine("Price: " + PriceDb);
                        sw.Close();
                        Process.Start("notepad.exe", path);
                        connection.Close();
                    }
                    if (Radio2.IsChecked == true)
                    {
                        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "select cooler from Game where id_temp=2";
                        CoolerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select cpu from Game where id_temp=2";
                        CPUDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select video from Game where id_temp=2";
                        VideoDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select oper from Game where id_temp=2";
                        OperDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select power from Game where id_temp=2";
                        PowerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select hard from Game where id_temp=2";
                        HardDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select mother from Game where id_temp=2";
                        MotherDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select price from Game where id_temp=2";
                        PriceDb = ((string)cmd.ExecuteScalar());
                        string path = "template.txt";
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine("Cooler: " + CoolerDb);
                        sw.WriteLine("CPU: " + CPUDb);
                        sw.WriteLine("Video: " + VideoDb);
                        sw.WriteLine("Oper: " + OperDb);
                        sw.WriteLine("Power: " + PowerDb);
                        sw.WriteLine("Hard: " + HardDb);
                        sw.WriteLine("Mother: " + MotherDb);
                        sw.WriteLine("Price: " + PriceDb);
                        sw.Close();
                        Process.Start("notepad.exe", path);
                        connection.Close();
                    }
                    if (Radio3.IsChecked == true)
                    {
                        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-47HS55Q\SQLEXPRESS;Trusted_Connection=Yes;DataBase=CW;");
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "select cooler from Game where id_temp=3";
                        CoolerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select cpu from Game where id_temp=3";
                        CPUDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select video from Game where id_temp=3";
                        VideoDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select oper from Game where id_temp=3";
                        OperDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select power from Game where id_temp=3";
                        PowerDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select hard from Game where id_temp=3";
                        HardDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select mother from Game where id_temp=3";
                        MotherDb = ((string)cmd.ExecuteScalar());
                        cmd.CommandText = "select price from Game where id_temp=3";
                        PriceDb = ((string)cmd.ExecuteScalar());
                        string path = "template.txt";
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine("Cooler: " + CoolerDb);
                        sw.WriteLine("CPU: " + CPUDb);
                        sw.WriteLine("Video: " + VideoDb);
                        sw.WriteLine("Oper: " + OperDb);
                        sw.WriteLine("Power: " + PowerDb);
                        sw.WriteLine("Hard: " + HardDb);
                        sw.WriteLine("Mother: " + MotherDb);
                        sw.WriteLine("Price: " + PriceDb);
                        sw.Close();
                        Process.Start("notepad.exe", path);
                        connection.Close();
                    }
                    GameData.Opacity = 0d;
                    GameData.Height = 30;
                }
                Radio1.Opacity = 0d;
                Radio2.Opacity = 0d;
                Radio3.Opacity = 0d;
            }
            else
            {
                this.Close();
            }
        }

        #region
        public int count = 50;
        public int maxTranform = 1;
        public float minDistantion = 50;
        public float minDistantionBackground = 60;
        public float minDistantionBackground2 = 70;
        public int maxSize = 5;
        public class ellipseInfo
        {
            public int x { get; set; }
            public int y { get; set; }
            public Ellipse ellipse { get; set; }
            public List<Line> lines = new List<Line>();
        }

        public List<ellipseInfo> allEllipse = new List<ellipseInfo>();
        public List<ellipseInfo> allEllipseBackground = new List<ellipseInfo>();
        public List<ellipseInfo> allEllipseBackground2 = new List<ellipseInfo>();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private void UpdateParalax(object sender, EventArgs e)
        {
            Random random = new Random();

            allEllipse[count].x = (int)Mouse.GetPosition(canvas).X;
            allEllipse[count].y = (int)Mouse.GetPosition(canvas).Y;

            for (int i = 0; i < allEllipse.Count; i++)
            {

                if (i < count)
                {

                    if (allEllipse[i].x < 20)
                    {

                        allEllipse[i].x += random.Next(0, maxTranform);
                    }
                    else if (allEllipse[i].x > Width - 20)
                    {

                        allEllipse[i].x += random.Next(-maxTranform, 0);
                    }
                    else

                        allEllipse[i].x += random.Next(-maxTranform, maxTranform + 1);


                    if (allEllipse[i].y < 20)
                    {

                        allEllipse[i].y += random.Next(0, maxTranform);
                    }
                    else if (allEllipse[i].y > Height - 20)
                    {

                        allEllipse[i].y += random.Next(-maxTranform, 0);
                    }
                    else

                        allEllipse[i].y += random.Next(-maxTranform, maxTranform + 1);
                }

                Canvas.SetLeft(allEllipse[i].ellipse, allEllipse[i].x);
                Canvas.SetTop(allEllipse[i].ellipse, allEllipse[i].y);


                for (int j = 0; j < allEllipse[i].lines.Count; j++)
                {
                    canvas.Children.Remove(allEllipse[i].lines[j]);
                    allEllipse[i].lines.Remove(allEllipse[i].lines[j]);
                }

                for (int j = i + 1; j < allEllipse.Count; j++)
                {
                    double x1 = allEllipse[i].x + allEllipse[i].ellipse.Width / 2;
                    double y1 = allEllipse[i].y + allEllipse[i].ellipse.Width / 2;

                    double x2 = allEllipse[j].x + allEllipse[j].ellipse.Width / 2;
                    double y2 = allEllipse[j].y + allEllipse[j].ellipse.Width / 2;

                    double distantion = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                    if (distantion < minDistantion)
                    {
                        Line line = new Line();
                        line.X1 = x1;
                        line.Y1 = y1;
                        line.X2 = x2;
                        line.Y2 = y2;
                        line.Stroke = new SolidColorBrush(Colors.Blue);
                        line.StrokeThickness = 0.5;

                        canvas.Children.Add(line);
                        allEllipse[i].lines.Add(line);
                    }
                }
            }
        }

        private void UpdateParalaxBackground(object sender, EventArgs e)
        {
            Random random = new Random();

            allEllipseBackground[count].x = (int)Mouse.GetPosition(canvas).X;
            allEllipseBackground[count].y = (int)Mouse.GetPosition(canvas).Y;

            for (int i = 0; i < allEllipseBackground.Count; i++)
            {

                if (i < count)
                {
                    if (allEllipseBackground[i].x < 20)
                    {
                        allEllipseBackground[i].x += random.Next(0, maxTranform);
                    }
                    else if (allEllipseBackground[i].x > Width - 20)
                    {
                        allEllipseBackground[i].x += random.Next(-maxTranform, 0);
                    }
                    else
                        allEllipseBackground[i].x += random.Next(-maxTranform, maxTranform + 1);

                    if (allEllipseBackground[i].y < 20)
                    {
                        allEllipseBackground[i].y += random.Next(0, maxTranform);
                    }
                    else if (allEllipseBackground[i].y > Height - 20)
                    {
                        allEllipseBackground[i].y += random.Next(-maxTranform, 0);
                    }
                    else
                        allEllipseBackground[i].y += random.Next(-maxTranform, maxTranform + 1);
                }


                Canvas.SetLeft(allEllipseBackground[i].ellipse, allEllipseBackground[i].x);
                Canvas.SetTop(allEllipseBackground[i].ellipse, allEllipseBackground[i].y);


                for (int j = 0; j < allEllipseBackground[i].lines.Count; j++)
                {
                    canvas.Children.Remove(allEllipseBackground[i].lines[j]);
                    allEllipseBackground[i].lines.Remove(allEllipseBackground[i].lines[j]);
                }

                for (int j = i + 1; j < allEllipse.Count; j++)
                {
                    double x1 = allEllipseBackground[i].x + allEllipseBackground[i].ellipse.Width / 2;
                    double y1 = allEllipseBackground[i].y + allEllipseBackground[i].ellipse.Width / 2;

                    double x2 = allEllipseBackground[j].x + allEllipseBackground[j].ellipse.Width / 2;
                    double y2 = allEllipseBackground[j].y + allEllipseBackground[j].ellipse.Width / 2;

                    double distantion = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                    if (distantion < minDistantionBackground)
                    {
                        Line line = new Line();
                        line.X1 = x1;
                        line.Y1 = y1;
                        line.X2 = x2;
                        line.Y2 = y2;
                        line.Stroke = new SolidColorBrush(Colors.LightGray);
                        line.StrokeThickness = 0.5;

                        canvas.Children.Add(line);
                        allEllipseBackground[i].lines.Add(line);
                    }
                }
            }
        }

        private void UpdateParalaxBackground2(object sender, EventArgs e)
        {
            Random random = new Random();

            allEllipseBackground2[count].x = (int)Mouse.GetPosition(canvas).X;
            allEllipseBackground2[count].y = (int)Mouse.GetPosition(canvas).Y;

            for (int i = 0; i < allEllipseBackground2.Count; i++)
            {

                if (i < count)
                {
                    if (allEllipseBackground2[i].x < 20)
                    {
                        allEllipseBackground2[i].x += random.Next(0, maxTranform);
                    }
                    else if (allEllipseBackground2[i].x > Width - 20)
                    {
                        allEllipseBackground2[i].x += random.Next(-maxTranform, 0);
                    }
                    else
                        allEllipseBackground2[i].x += random.Next(-maxTranform, maxTranform + 1);

                    if (allEllipseBackground2[i].y < 20)
                    {
                        allEllipseBackground2[i].y += random.Next(0, maxTranform);
                    }
                    else if (allEllipseBackground2[i].y > Height - 20)
                    {
                        allEllipseBackground2[i].y += random.Next(-maxTranform, 0);
                    }
                    else
                        allEllipseBackground2[i].y += random.Next(-maxTranform, maxTranform + 1);
                }


                Canvas.SetLeft(allEllipseBackground2[i].ellipse, allEllipseBackground2[i].x);
                Canvas.SetTop(allEllipseBackground2[i].ellipse, allEllipseBackground2[i].y);


                for (int j = 0; j < allEllipseBackground2[i].lines.Count; j++)
                {
                    canvas.Children.Remove(allEllipseBackground2[i].lines[j]);
                    allEllipseBackground2[i].lines.Remove(allEllipseBackground2[i].lines[j]);
                }

                for (int j = i + 1; j < allEllipse.Count; j++)
                {
                    double x1 = allEllipseBackground2[i].x + allEllipseBackground2[i].ellipse.Width / 2;
                    double y1 = allEllipseBackground2[i].y + allEllipseBackground2[i].ellipse.Width / 2;

                    double x2 = allEllipseBackground2[j].x + allEllipseBackground2[j].ellipse.Width / 2;
                    double y2 = allEllipseBackground2[j].y + allEllipseBackground2[j].ellipse.Width / 2;

                    double distantion = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                    if (distantion < minDistantionBackground2)
                    {
                        Line line = new Line();
                        line.X1 = x1;
                        line.Y1 = y1;
                        line.X2 = x2;
                        line.Y2 = y2;
                        line.Stroke = new SolidColorBrush(Colors.Gray);
                        line.StrokeThickness = 0.5;

                        canvas.Children.Add(line);
                        allEllipseBackground2[i].lines.Add(line);
                    }
                }
            }
        }

        public void CreateParalax()
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                ellipseInfo newElement = new ellipseInfo();
                newElement.x = random.Next(20, (int)Width - 20);
                newElement.y = random.Next(20, (int)Height - 20);

                Ellipse ellipse = new Ellipse();
                Canvas.SetLeft(ellipse, newElement.x);
                Canvas.SetTop(ellipse, newElement.y);

                int widthEllips = random.Next(3, maxSize);

                ellipse.Width = widthEllips;
                ellipse.Height = widthEllips;
                ellipse.Fill = new SolidColorBrush(Colors.Blue);

                newElement.ellipse = ellipse;
                canvas.Children.Add(newElement.ellipse);
                allEllipse.Add(newElement);

            }

            ellipseInfo mouseElement = new ellipseInfo();
            mouseElement.x = (int)Mouse.GetPosition(canvas).X;
            mouseElement.y = (int)Mouse.GetPosition(canvas).Y;

            Ellipse mouseEllipse = new Ellipse();
            mouseEllipse.Width = 2;
            mouseEllipse.Height = 2;
            Canvas.SetLeft(mouseEllipse, mouseElement.x);
            Canvas.SetTop(mouseEllipse, mouseElement.y);

            mouseElement.ellipse = mouseEllipse;
            canvas.Children.Add(mouseElement.ellipse);
            allEllipse.Add(mouseElement);
        }

        public void CreateParalaxBackground()
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                ellipseInfo newElement = new ellipseInfo();
                newElement.x = random.Next(20, (int)Width - 20);
                newElement.y = random.Next(20, (int)Height - 20);

                Ellipse ellipse = new Ellipse();
                Canvas.SetLeft(ellipse, newElement.x);
                Canvas.SetTop(ellipse, newElement.y);

                int widthEllips = random.Next(3, maxSize);

                ellipse.Width = widthEllips;
                ellipse.Height = widthEllips;
                ellipse.Fill = new SolidColorBrush(Colors.LightGray);

                newElement.ellipse = ellipse;
                canvas.Children.Add(newElement.ellipse);
                allEllipseBackground.Add(newElement);

            }

            ellipseInfo mouseElement = new ellipseInfo();
            mouseElement.x = (int)Mouse.GetPosition(canvas).X;
            mouseElement.y = (int)Mouse.GetPosition(canvas).Y;

            Ellipse mouseEllipse = new Ellipse();
            mouseEllipse.Width = 2;
            mouseEllipse.Height = 2;
            Canvas.SetLeft(mouseEllipse, mouseElement.x);
            Canvas.SetTop(mouseEllipse, mouseElement.y);

            mouseElement.ellipse = mouseEllipse;
            canvas.Children.Add(mouseElement.ellipse);
            allEllipseBackground.Add(mouseElement);
        }

        public void CreateParalaxBackground2()
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                ellipseInfo newElement = new ellipseInfo();
                newElement.x = random.Next(20, (int)Width - 20);
                newElement.y = random.Next(20, (int)Height - 20);

                Ellipse ellipse = new Ellipse();
                Canvas.SetLeft(ellipse, newElement.x);
                Canvas.SetTop(ellipse, newElement.y);

                int widthEllips = random.Next(3, maxSize);

                ellipse.Width = widthEllips;
                ellipse.Height = widthEllips;
                ellipse.Fill = new SolidColorBrush(Colors.Gray);

                newElement.ellipse = ellipse;
                canvas.Children.Add(newElement.ellipse);
                allEllipseBackground2.Add(newElement);

            }

            ellipseInfo mouseElement = new ellipseInfo();
            mouseElement.x = (int)Mouse.GetPosition(canvas).X;
            mouseElement.y = (int)Mouse.GetPosition(canvas).Y;

            Ellipse mouseEllipse = new Ellipse();
            mouseEllipse.Width = 2;
            mouseEllipse.Height = 2;
            Canvas.SetLeft(mouseEllipse, mouseElement.x);
            Canvas.SetTop(mouseEllipse, mouseElement.y);

            mouseElement.ellipse = mouseEllipse;
            canvas.Children.Add(mouseElement.ellipse);
            allEllipseBackground2.Add(mouseElement);
        }
        #endregion
    }
}
