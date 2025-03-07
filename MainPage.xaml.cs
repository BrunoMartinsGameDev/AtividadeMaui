namespace AtividadeMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnBtnClicked(object sender, EventArgs e)
	{
		await DisplayAlert("Aviso!", "Com Grandes poderes vem grandes responsabilidades!", "OK");
	}
	private async void OnNavigateClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new AboutPage());
	}
}

