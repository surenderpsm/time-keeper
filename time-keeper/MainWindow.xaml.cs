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

namespace time_keeper
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
        private Task currentTask;
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            currentTask = new Task();
            Start.IsEnabled = false;
            End.IsEnabled = true;
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            string description = "Hello", category = "Fitness";
            Start.IsEnabled = true;
            End.IsEnabled = false;
            currentTask.EndTask(description, category);
            TimeSpan time = currentTask.getElapsed();
            Stopwatch.Text = time.Hours.ToString() + ":" + time.Minutes.ToString() + ":" + time.Seconds.ToString();
            Database.addtoDB(currentTask);
        }
    }
}
