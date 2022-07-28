using AcessoRCG.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AcessoRCG.Views
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