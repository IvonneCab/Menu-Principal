namespace Analisis1;

public partial class Menu_Principal : ContentPage
{
	public Menu_Principal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}