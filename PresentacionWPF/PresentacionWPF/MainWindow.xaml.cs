using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PresentacionWPF
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

        private void PersonalAddTask_Click(object sender, RoutedEventArgs e)
        {
            // Obtenemos el texto de la nueva tarea
            string taskText = PersonalNewTaskTextBox.Text;

            // Verificamos que el texto no esté vacío
            if (!string.IsNullOrEmpty(taskText))
            {
                // Creamos un nuevo TextBlock para mostrar la tarea
                TextBlock taskBlock = new TextBlock
                {
                    Text = taskText,
                    Margin = new Thickness(5)
                };

                // Agregamos el TextBlock al WrapPanel
                PersonalTaskWrapPanel.Children.Add(taskBlock);

                // Limpiamos el TextBox
                PersonalNewTaskTextBox.Clear();
            }
        }

        private void TrabajoAddTask_Click(object sender, RoutedEventArgs e)
        {
            // Obtenemos el texto de la nueva tarea
            string taskText = TrabajoNewTaskTextBox.Text;

            // Verificamos que el texto no esté vacío
            if (!string.IsNullOrEmpty(taskText))
            {
                // Creamos un nuevo TextBlock para mostrar la tarea
                TextBlock taskBlock = new TextBlock
                {
                    Text = taskText,
                    Margin = new Thickness(5)
                };

                // Agregamos el TextBlock al WrapPanel
                TrabajoTaskWrapPanel.Children.Add(taskBlock);

                // Limpiamos el TextBox
                TrabajoNewTaskTextBox.Clear();
            }
        }

    }
}