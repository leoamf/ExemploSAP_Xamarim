using Xamarin.Forms;

#if __IOS__
using UIKit;
#elif __ANDROID__
using Android.OS;
#endif

namespace ExemploSAP_Xamarim
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            #if __IOS__
                UIDevice devide =new UIDevice();
                lblInfo.Text = devide.Model;
            #elif __ANDROID__ 
                lblInfo.Text = Build.Manufacturer;
            #endif 
        }
    }
}
