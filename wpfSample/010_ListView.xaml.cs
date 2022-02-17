using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using wpfSample.Objects;

namespace wpfSample
{
    /// <summary>
    /// _010_ListView.xaml の相互作用ロジック
    /// </summary>
    public partial class _010_ListView : Window
    {
        // ObservableCollectionで変更を通知できる
        private ObservableCollection<Customer> _customers = new ObservableCollection<Customer>();
        private int _index = 0;

        public _010_ListView()
        {
            InitializeComponent();

            _customers.Add(new Customer { Id = ++_index, Name = "name" + _index, Phone = "phone" + _index });
            _customers.Add(new Customer { Id = ++_index, Name = "name" + _index, Phone = "phone" + _index });
            _customers.Add(new Customer { Id = ++_index, Name = "name" + _index, Phone = "phone" + _index });

            CustomerListView.ItemsSource = _customers;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            _customers.Add(new Customer { Id = ++_index, Name = "name" + _index, Phone = "phone" + _index });
            CustomerListView.ItemsSource = _customers;
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }
    }
}
