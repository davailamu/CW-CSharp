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

namespace CourseWork
{
    /// <summary>
    /// Логика взаимодействия для choose.xaml
    /// </summary>
    public partial class choose : Window
    {
        public choose()
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

        private void A1_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Assembly.Opacity = .75d;
        }

        private void A1_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Assembly.Opacity = .25d;
        }

        private void A1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Assembly.Opacity = 1.0d;
            Assembly win = new Assembly();
            this.Close();
            win.Show();
        }

        private void T1_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Template.Opacity = .75d;
        }

        private void T1_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Template.Opacity = .25d;
        }

        private void T1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Template.Opacity = 1.0d;
            Templates win = new Templates();
            this.Close();
            win.Show();
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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
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
    }
}
