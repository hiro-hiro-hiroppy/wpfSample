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
    /// _022_TabControl.xaml の相互作用ロジック
    /// </summary>
    public partial class _022_TabControl : Window
    {
        public _022_TabControl()
        {
            InitializeComponent();

            MyTabControl.SelectedIndex = 1;
        }
    }
}
