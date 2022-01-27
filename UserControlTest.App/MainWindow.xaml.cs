using System;
using System.Windows;
using System.Windows.Controls;
using UserControlTest.WPF_Lib;

namespace UserControlTest.App
{
    public partial class MainWindow : Window
    {
        private int _count;
        public MainWindow()
        {
            InitializeComponent();
            BuildCardsPanel();
            _count = 0;
            Output.Content = $"Count = {_count}";
        }

        private void BuildCardsPanel()
        {
            for (int i = 0; i < 10; i++)
            {
                Panel.Children.Add(new Card
                {
                    Title = $"Title #{i}",
                    Annotation = $"Annotation {Title}",
                    Price = i,
                    MoreAction = MoreNews
                });
            }
        }

        private void MoreNews(object sender, EventArgs e)
        {
            var card = ((sender as Button)?.Parent as StackPanel)?.Parent as Card;
            if (card != null) _count += card.Price;
            Output.Content = $"Count = {_count}";
        }
    }
}