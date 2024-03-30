using _21._102_Zotochkina_02.Entity;
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

namespace _21._102_Zotochkina_02
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Entities db = new Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchQuery = SearchTextBox.Text;
            var query = from teacher in db.Teachers
                        where teacher.LastName.Contains(searchQuery)
                        select teacher;

            if (SortComboBox.SelectedIndex == 0) // Сортировка по имени преподавателя (убывание)
            {
                query = query.OrderByDescending(t => t.FirstName);
            }
            else if (SortComboBox.SelectedIndex == 1) // Сортировка по названию специальности (возрастание)
            {
                query = query.OrderBy(t => t.Speciality.Title);
            }

            if (query.Any())
            {
                LoadData.ItemsSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Результаты поиска отсутствуют.");
            }
        }
    }
}