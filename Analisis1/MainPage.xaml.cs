namespace Analisis1
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
          

            for (int i = 0; i <= 100; i += 2)
            {
               entry1.Text = entry1.Text + " " + i + "";
            }

           
        }
      
            
           
        

    }

}
