namespace VenduusApp;

public partial class IncluirPedidoPage : ContentPage
{
	public IncluirPedidoPage()
	{
		InitializeComponent();
	}

    private async void OnCancelarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void OnSalvarButtonClicked(object sender, EventArgs e)
    {
        // L�gica para salvar o pedido
    }
}