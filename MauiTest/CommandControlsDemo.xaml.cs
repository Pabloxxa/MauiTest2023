namespace MauiTest;

public partial class CommandControlsDemo : ContentPage
{
	public CommandControlsDemo()
	{
		InitializeComponent();
	}

    private void btnTest_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Test", "This is a Demo", "Ok");
    } 
	private void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
		dynamic control = sender; 
		DisplayAlert("Test", "Radio button has changed to "+ control.Content.ToString(), "Ok");
    }
	private void SwipeItem_Invoked(object sender, EventArgs e)
	{
        dynamic control = sender;
        DisplayAlert("Test", "Swipe Item has Invoked", "Ok");
    }
}