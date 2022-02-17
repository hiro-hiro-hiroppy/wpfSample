using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpfSample
{
    /// <summary>
    /// _002_Grid.xaml の相互作用ロジック
    /// </summary>
    public partial class _002_Grid : Window
    {
        public _002_Grid()
        {
            InitializeComponent();

            ResultLabel.Content = "12345";
        }
    }
}
