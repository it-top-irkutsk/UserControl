using System;
using System.Windows;
using System.Windows.Controls;

namespace UserControlTest.WPF_Lib
{
    public partial class Card : UserControl
    {
        public string Title { get; set; }
        public string Annotation { get; set; }

        public EventHandler MoreAction { get; set; }
        
        public int Price { get; set; }

        public Card()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void More_OnClick(object sender, RoutedEventArgs e)
        {
            MoreAction?.Invoke(sender, e);
        }
    }
}