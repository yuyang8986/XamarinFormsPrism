using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSamplePrism.Views.Studies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactProfilePage 
    {
        public ContactProfilePage()
        {
            InitializeComponent();
            InitialFontSize = NameLabelText.FontSize;
        }

        public double InitialFontSize { get; } 
        private void ScrollView_OnScrolled(object sender, ScrolledEventArgs e)
        {
            var sv = (sender as ScrollView);
            var percentScroll = sv.ScrollY / HeaderImage.Height; //(sv.ContentSize.Height - sv.Height);
            percentScroll = Math.Min(percentScroll, 1);
            HeaderImage.Opacity = (1 - percentScroll);
            HeaderImage.TranslationY = -sv.ScrollY;
            NameLabelText.FontSize = InitialFontSize * (1- percentScroll/7);
        }
    }
}