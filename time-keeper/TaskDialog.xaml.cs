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

namespace time_keeper
{
    /// <summary>
    /// Interaction logic for TaskDialog.xaml
    /// </summary>
    public partial class TaskDialog : Window
    {
        Task currentTask { get; set; }
        public TaskDialog(Task task)
        {
            InitializeComponent();
            TimeElapsed.Text = task.getTime();
            currentTask = task;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if(DescriptionTextBox.Text != "" && CategoryTextBox.Text != "")
            {
                currentTask.setDetails(CategoryTextBox.Text, DescriptionTextBox.Text);
            }
            this.Close();            
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
