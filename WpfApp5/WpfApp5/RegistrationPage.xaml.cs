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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            ListBox1.Items.Add("Преподаватель");
            ListBox1.Items.Add("Студент");
            ListBox2.Items.Add("163");
            ListBox2.Items.Add("258");
            ListBox2.Items.Add("319");
            ListBox2.Items.Add("464");
            ListBox2.Items.Add("351");
        }

        private void OnAuthorozationUp(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.AuthorizationPage);
        }
    }
}
