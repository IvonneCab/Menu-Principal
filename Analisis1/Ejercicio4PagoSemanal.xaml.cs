namespace Analisis1;

public partial class Ejercicio4PagoSemanal : ContentPage
{
	public Ejercicio4PagoSemanal()
	{
		InitializeComponent();
	}

    private void CounterBtn_Clicked_1(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Entry1.Text) && !string.IsNullOrEmpty(Entry2.Text) && !String.IsNullOrEmpty(Entry3.Text)) ;
        {
            double horat, PagoH, total;
            horat = Convert.ToDouble(Entry1.Text);
            PagoH = Convert.ToDouble(Entry2.Text);

            total = (horat * PagoH);
            Entry3.Text = "El pago semanal de un empleado por hora es: " + total.ToString();
        }
    }
}