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

namespace RejsNice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Timer i ComboBox
            HourBox.Items.Add("8");
            HourBox.Items.Add("9");
            HourBox.Items.Add("10");
            HourBox.Items.Add("11");
            HourBox.Items.Add("12");
            HourBox.Items.Add("13");
            HourBox.Items.Add("14");
            HourBox.Items.Add("15");
            HourBox.Items.Add("16");
            HourBox.Items.Add("17");
            HourBox.Items.Add("18");
            HourBox.Items.Add("19");
            HourBox.Items.Add("20");
            HourBox.Items.Add("21");
            HourBox.Items.Add("22");
            HourBox.Items.Add("23");
            HourBox.Items.Add("00");
            HourBox.Items.Add("1");
            HourBox.Items.Add("2");
            HourBox.Items.Add("3");
            HourBox.Items.Add("4");
            HourBox.Items.Add("5");
            HourBox.Items.Add("6");
            HourBox.Items.Add("7");

            //Minutter i ComboBox
            MinuteBox.Items.Add("00");
            MinuteBox.Items.Add("15");
            MinuteBox.Items.Add("30");
            MinuteBox.Items.Add("45");


        }

    }
    
}
