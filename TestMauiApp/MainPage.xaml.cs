using System.ComponentModel;

namespace TestMauiApp;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    public MainPage()
    {
        InitializeComponent();
    }

    public new event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void NotifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public bool IsFrameEnabled { get; set; }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Console.WriteLine("Here");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        IsFrameEnabled = !IsFrameEnabled;
        NotifyPropertyChanged(nameof(IsFrameEnabled));
    }
}
