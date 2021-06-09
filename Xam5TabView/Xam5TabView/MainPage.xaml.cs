using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.CommunityToolkit.UI.Views;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xam5TabView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            GenerateUI();
            OpenToSecondTab();
        }

        void GenerateUI()
        {
            var firstTabViewItem = new TabViewItem()
            {
                Text = "index 0",
                Content = new Label() { Text = "Tab index 0 content" },
                Padding = new Thickness(15, 0)
            };

            uiTabView.TabItems.Add(firstTabViewItem);

            var secondTabViewItem = new TabViewItem()
            {
                Text = "index 1",
                Content = new Label() { Text = "Tab index 1 content" },
                Padding = new Thickness(15, 0)
            };

            uiTabView.TabItems.Add(secondTabViewItem);

            var thirdTabViewItem = new TabViewItem()
            {
                Text = "index 2",
                Content = new Label() { Text = "Tab index 2 content" },
                Padding = new Thickness(15, 0)
            };

            uiTabView.TabItems.Add(thirdTabViewItem);
        }

        void OpenToSecondTab() => uiTabView.SelectedIndex = 1;
    }
}

