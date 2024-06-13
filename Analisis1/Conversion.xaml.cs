namespace CONVERSIONMEXejercicio6;

public partial class Conversion : ContentPage
{
	public Conversion()
	{
		InitializeComponent();
	}

    private void Buttonla_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(pesos.Text, out double mexicanosPesos))
        {
            // Tipo de cambio actual (ejemplo)
            double exchangeRate = 0.050;

            double dollars = mexicanosPesos * exchangeRate;
            conversion.Text = $"Usted puede adquirir ${dollars.ToString("0.00")} USD.";
        }

    }
}