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

namespace Yamp3
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        
        public Window3()
        {
            InitializeComponent();
            usersList.ItemsSource = new List<Person>()
            {
                new Person{Name="Tom", Age=38},
                new Person{Name="Bob", Age=42},
                new Person{Name="Sam", Age=25}
            };
            usersList.DisplayMemberPath = "Name";
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
