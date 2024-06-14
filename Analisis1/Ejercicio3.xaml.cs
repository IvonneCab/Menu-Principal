﻿namespace Ejercicio3TablasdeMultiplicar
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Mostrartabla_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(Entry1.Text, out int number))
            {
                string table = "";
                for (int i =1;i <=10; i++)
                {
                    table += $"{number} x {i} = {number * i}\n";
                }
                DisplayAlert("Multiplicación table", table, "OK");
            }

        }
    }

}
