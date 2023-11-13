using Lesson2.DataModels;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Lesson2.Pages
{
    public partial class TasksPage : Page
    {
        private Lesson2Entities1 context = new Lesson2Entities1();

        public TasksPage()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void LoadTasks()
        {
            var tasks = context.Tasks.Include("Importance").ToList(); // Используйте Include для загрузки связанных данных
            TasksDataGrid.ItemsSource = tasks;
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditTaskPage(null)); // null указывает на создание новой задачи
        }

        private void EditTask_Click(object sender, RoutedEventArgs e)
        {
            if (TasksDataGrid.SelectedItem is Tasks selectedTask)
            {
                NavigationService.Navigate(new AddEditTaskPage(selectedTask));
            }
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (TasksDataGrid.SelectedItem is Tasks selectedTask)
            {
                context.Tasks.Remove(selectedTask);
                context.SaveChanges();
                LoadTasks(); // Перезагрузить список задач
            }
        }
    }
}
