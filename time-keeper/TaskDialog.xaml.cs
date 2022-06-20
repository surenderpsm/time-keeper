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
                MessageBox.Show("The current task has been saved successfully!", "Task Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
                return;
            }
            MessageBox.Show("One or more fields are empty. Please fill all the information", "Missing Information", MessageBoxButton.OK, MessageBoxImage.Warning);         
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("This operation will delete the current Task. Do you wish to continue?", "Delete current Task?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;
            }         
        }
    }
}
