namespace HybridWebViewReact;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void Message(object sender, HybridWebView.HybridWebViewRawMessageReceivedEventArgs e)
    {
        var m = e.Message;
        await Dispatcher.DispatchAsync(async () =>
        {
            await DisplayAlert("Message", m, "OK");
        });
    }
}