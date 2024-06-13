namespace LANGOSTAEJERCICIO5;

public partial class Langosta : ContentPage
{
	public Langosta()
	{
		InitializeComponent();
	}

    private void Buttonla_Clicked(object sender, EventArgs e)
    {
       

        if (int.TryParse(Langostaentry.Text, out int numerodepersonas))
        {
            double costopersona = 95.00;
            if (numerodepersonas > 200 &&  numerodepersonas <= 300)
            {
                costopersona = 85.00;
            }
            else if (numerodepersonas > 300)
            {
                costopersona = 75.00;
            }
            double totalCost = numerodepersonas * costopersona;
            Resultado.Text = totalCost.ToString();
        }

    }
}