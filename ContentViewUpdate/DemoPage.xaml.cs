using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ContentViewUpdate
{
    public partial class DemoPage : ContentPage
    {
        private int count = 0;

        public DemoPage()
        {
            InitializeComponent();
        }

        void ShowContent (object sender, EventArgs e)
        {   
            testContent.Content = new Label { Text = $"Hello {count++}" };

            testContent.Opacity = 0;
            testContent.IsVisible = true;

            testContent.FadeTo(1, 300);
        }

        void HideContent (object sender, EventArgs e)
        {
            this.testContent.IsVisible = false;
        }
    }
}

