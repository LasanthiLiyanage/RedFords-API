using RadFordsMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RadFordsMobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}