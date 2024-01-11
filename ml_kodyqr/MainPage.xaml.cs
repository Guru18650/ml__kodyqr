
using System.IO;

namespace ml_kodyqr
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           string dane = tEntry.Text;
           img.Source = $"https://api.qrserver.com/v1/create-qr-code/?size=500x500&data={dane}";

        }

       


    }
}