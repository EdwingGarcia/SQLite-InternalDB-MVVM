using sqlliteMVVM.Models;
using sqlliteMVVM.ViewModels;

namespace sqlliteMVVM.Views;

public partial class EditarProductoPage : ContentPage
{
    public EditarProductoPage(Producto producto)
    {
        InitializeComponent();
        BindingContext = new EditarProductoViewModel(producto);
    }

}