using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutExercise2 : ContentPage
    {
        public AbsoluteLayoutExercise2()
        {
            InitializeComponent();

            var imageSource = new UriImageSource { Uri = new Uri("https://www.jquery-az.com/wp-content/uploads/2015/12/2.1-HTML-img-src.jpg") };
            imageSource.CachingEnabled = false;
            imageSource.CacheValidity = TimeSpan.FromHours(1);
           // image.Source = imageSource;


        }
    }
}