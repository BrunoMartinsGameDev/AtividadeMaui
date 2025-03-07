namespace AtividadeMaui;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();	
	}
	private async void OnVoltarClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}