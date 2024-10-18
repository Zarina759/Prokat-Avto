using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
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
using прокат.авто.База_Данных;

namespace прокат.авто.Каршеринг
{
    /// <summary>
    /// Логика взаимодействия для CatalogAvtoPage.xaml
    /// </summary>
    public partial class CatalogAvtoPage : Page
    {
        public CatalogAvtoPage()
        {
            InitializeComponent();
            ListAvto.ItemsSource = AvtoProkatEntities2.GetContext().Автомобили.ToList();
            var marki = AvtoProkatEntities2.GetContext().МаркиАвтомобиля.OrderBy(p => p.НаименованиеМаркиАвто).ToList();
            marki.Insert(0, new МаркиАвтомобиля
            {
                НаименованиеМаркиАвто = "Все Марки"
            }
            );
            CmbMarki.ItemsSource = marki;
            CmbMarki.SelectedIndex = 0;
        }
        private void Page_IsVisibleChanged(object sender,DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
                AvtoProkatEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            ListAvto.ItemsSource = AvtoProkatEntities2.GetContext().Автомобили.OrderBy(p => p.Модель).ToList();        
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData()
        }

        private void CmbMarki_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData()
        }

        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData()
        }
        private void UpdateData()
        {
            var currentAvto = AvtoProkatEntities2.GetContext().Автомобили.OrderBy(p => p.Модель).ToList();

        }
    }
}
