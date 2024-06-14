
using System.Diagnostics;
namespace Analisis1;

public partial class ejercicio2 : ContentPage
{
    private readonly progressArc _progressArc;

    private DateTime _startTime;

    private readonly int _duration = 11;

    private double _progress;

    private CancellationTokenSource _cancellationTokenSource = new();
    public ejercicio2()
	{
		InitializeComponent();
        _progressArc = new progressArc();

    }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ProgressButton.Text = "\uf144";

            ProgressView.Drawable = _progressArc;
        }



        private async void UpdateArc()
        {
            while (!_cancellationTokenSource.Token.IsCancellationRequested)

            {


                TimeSpan elapseddTime = DateTime.Now - _startTime;
                int secondsRemaining = (int)(_duration - elapseddTime.TotalSeconds);
                ProgressButton.Text = $"{secondsRemaining}";
                _progress = Math.Ceiling(elapseddTime.TotalSeconds);
                _progress %= _duration;
                _progressArc.Progress = _progress / _duration;
                ProgressView.Invalidate();

                if (secondsRemaining == 0)
                {
                    _cancellationTokenSource.Cancel();
                    return;
                }

                await Task.Delay(500);
            }
            ResetView();
        }

        private void ResetView()

        {
            _progress = 0;
            _progressArc.Progress = 100;
            ProgressView.Invalidate();
            ProgressButton.Text = "\uf144";

        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();

            UpdateArc();
        }

        private void ProgressButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ProgressButton_Clicked_1(object sender, EventArgs e)
        {

        }

        private void ProgressButton_Clicked_2(object sender, EventArgs e)
        {
            _startTime = DateTime.Now;
            _cancellationTokenSource = new CancellationTokenSource();
            UpdateArc();
        }

    public class progressArc : IDrawable
    {
        public double Progress { get; set; } = 100;

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            var endAngle = 90 - (int)Math.Round(Progress * 360, MidpointRounding.AwayFromZero);


            canvas.StrokeColor = Color.FromRgba("6599ff");
            canvas.StrokeSize = 4;
            Debug.WriteLine($"The rect width is {dirtyRect.Width} and height is {dirtyRect.Height}");
            canvas.DrawArc(5, 5, (dirtyRect.Width - 10), (dirtyRect.Height - 10), 90, endAngle, false, false);
        }
    }
}