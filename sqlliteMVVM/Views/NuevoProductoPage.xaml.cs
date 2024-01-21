using sqlliteMVVM.ViewModels;

namespace sqlliteMVVM.Views;

public partial class NuevoProductoPage : ContentPage
{
    public NuevoProductoPage()
    {
        InitializeComponent();
        BindingContext = new NuevoProductoViewModel();
    }
}