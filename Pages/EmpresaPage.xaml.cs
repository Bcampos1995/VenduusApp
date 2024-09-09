namespace VenduusApp;

public partial class EmpresaPage : ContentPage
{
    public EmpresaPage()
    {
        InitializeComponent();
        empresaPicker.Items.Add("EMPRESA 1");
        empresaPicker.Items.Add("EMPRESA 2");
        empresaPicker.Items.Add("EMPRESA 3");
        empresaPicker.Items.Add("EMPRESA 4");
        empresaPicker.Items.Add("EMPRESA 5");
        empresaPicker.Items.Add("EMPRESA 6");
    }

    private async void OnSelectButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell();
    }
}