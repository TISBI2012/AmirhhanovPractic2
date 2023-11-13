using Lesson2.DataModels;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Lesson2.Pages
{
    public partial class AddEditTaskPage : Page
    {
        private readonly Tasks task;
        private readonly Lesson2Entities1 context = new Lesson2Entities1();

        public AddEditTaskPage(Tasks task = null)
        {
            InitializeComponent();
            this.task = task ?? new Tasks();
            this.DataContext = this.task;

            ImportanceComboBox.ItemsSource = context.Importance.ToList();
            ImportanceComboBox.DisplayMemberPath = "Name";
            ImportanceComboBox.SelectedValuePath = "Id";

            if (task != null)
            {
                ImportanceComboBox.SelectedValue = task.ImportanceId;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Валидация данных
            if (string.IsNullOrWhiteSpace(task.Description))
            {
                MessageBox.Show("Описание задачи обязательно.");
                return;
            }

            if (task.ImportanceId == 0)
            {
                MessageBox.Show("Выберите важность задачи.");
                return;
            }

            if (task.Id == 0)
            {
                context.Tasks.Add(task); // Добавление новой задачи
            }
            else
            {
                context.Entry(task).State = System.Data.Entity.EntityState.Modified; // Обновление существующей
            }

            context.SaveChanges();
            NavigationService.GoBack();
        }

        private void ReturnToTasks_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TasksPage());
        }

    }
}
