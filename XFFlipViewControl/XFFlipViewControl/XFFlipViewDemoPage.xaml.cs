﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFFlipViewControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XFFlipViewDemoPage : ContentPage
    {
        public XFFlipViewDemoPage()
        {
            InitializeComponent();

            TimerRunner();
        }

        private void flipItButonControl_OnClicked(object sender, EventArgs e)
        {
            XFFlipViewControl1.IsFlipped = !XFFlipViewControl1.IsFlipped;
        }

        private void TimerRunner()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1),
                () =>
                {
                    frontViewTimeLabel.Text = $"Timestamp: {DateTime.Now}";

                    backViewTimeLabel.Text = $"Timestamp: {DateTime.Now}";

                    return true;
                });
        }
    }
}