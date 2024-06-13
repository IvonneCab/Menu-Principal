using CONVERSIONMEXejercicio6;
using LANGOSTAEJERCICIO5;

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

    private void Butonexe5_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Langosta());
    }

    private void Butonexe6_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Conversion());
    }
}