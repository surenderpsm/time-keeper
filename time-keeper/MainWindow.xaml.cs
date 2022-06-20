using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
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
            LoadTasks();
        }
        private Task currentTask;
        private DispatcherTimer timer = new DispatcherTimer();
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            currentTask = new Task();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer;
            timer.Start();
            Start.IsEnabled = false;
            End.IsEnabled = true;
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            currentTask.EndTask();
            timer.Stop();
            Start.IsEnabled = true;
            End.IsEnabled = false;
            Stopwatch.Text = currentTask.getTime();
            string description = "Hello", category = "Fitness";
            var dialog = new TaskDialog(currentTask);
            dialog.Owner = this;
            dialog.ShowDialog();
            Database.addtoDB(currentTask);
            Stopwatch.Text = "00:00:00";
            LoadTasks();
        }

        private void LoadTasks()
        {
            LogDatagrid.ItemsSource = Database.getAllTasks();
        }

        private void Timer(object sender, EventArgs e)
        {
            Stopwatch.Text = Utility.DisplayFormat(DateTime.Now - currentTask.Start);
        }
    }
}

