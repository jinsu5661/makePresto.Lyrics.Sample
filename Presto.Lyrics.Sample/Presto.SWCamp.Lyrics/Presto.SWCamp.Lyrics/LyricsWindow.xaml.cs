using Presto.SDK;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

namespace Presto.SWCamp.Lyrics
{
    /// <summary>
    /// LyricsWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LyricsWindow : Window
    {
     
        private SortedList<TimeSpan, string> _lyrice = new SortedList<TimeSpan, string>();

        public LyricsWindow()
        {
            InitializeComponent();

            string path = @"C:\Users\cbnu\Desktop\makePresto.Lyrics.Sample\Presto.Lyrics.Sample\Musics\";
           // string Text = "{Binding Player.CurrentMusic.Title}";

            // var lines = File.ReadAllLines(path + Text);
            var lines = File.ReadAllLines(path + "볼빨간사춘기 - 여행.LRC");

            //for (int i = 3; i <= lines.Length; i++)
            foreach (string line in lines)
            {
                var splitData = line.Split(']');
                var time = TimeSpan.ParseExact("00:04.98", @"mm\:ss\.ff", CultureInfo.InvariantCulture);

                while(line != null) { 
                    testLytics.Text = line;
                }
                // Console.WriteLine("\t" + splitData);
            }
       
            /*  
            for (int i = 3; i <= lines.Length; i++)
            {
                var splitData = lines[i].Split(']');
                var time = TimeSpan.ParseExact("00:04.98", @"mm\:ss\.ff", CultureInfo.InvariantCulture);
            }
            */

            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(1)
            };
 
            timer.Tick += Timer_Tick;
            timer.Start();


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
         //   testLytics.Text = PrestoSDK.PrestoService.Player.Position.ToString();

        }
    }
}
