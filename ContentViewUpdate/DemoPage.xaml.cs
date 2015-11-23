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

        void UpdateContent (object sender, EventArgs e)
        {            
            this.testContent.Content = new Label { Text = $"Hello {count++}" };

            this.testContent.IsVisible = true;
        }

        void HideContent (object sender, EventArgs e)
        {
            this.testContent.IsVisible = false;
        }

    }
}

