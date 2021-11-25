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
using System.Windows.Threading;
namespace Countdown
{
    /// <summary>
    /// Interaction logic for justdancetrailer.xaml
    /// </summary>
    public partial class justdancetrailer : Window
    {
        private readonly DispatcherTimer Timer = new DispatcherTimer();
        private readonly DateTime daysLeft;

        public justdancetrailer()
        {
            InitializeComponent();

            daysLeft = DateTime.Parse("1/02/2022 12:00:00 AM");

            Timer.Interval = TimeSpan.FromSeconds(1.0); ;
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan t = daysLeft.Subtract(DateTime.Now);
            if (t.Seconds >= 0)
            {
                string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds until launch.",
                    t.Days, t.Hours, t.Minutes, t.Seconds);



                textBlock.Text = countDown;

                daysLeft.AddSeconds(-1);
            }
            else
            {
                Timer.Stop();
            }
        }

        private void trailer_play(object sender, RoutedEventArgs e)
        {
            trailer.Play();
        }

        private void trailer_stop(object sender, RoutedEventArgs e)
        {
            trailer.Stop();
            trailer.Close();
        }

        private void trailer_pause(object sender, RoutedEventArgs e)
        {
            trailer.Pause();

        }
        private void ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            trailer.Volume = e.NewValue;
        }


    }
}
