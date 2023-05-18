namespace MauiTest;

public partial class InputControlsDemo : ContentPage
{
	public InputControlsDemo()
	{
		InitializeComponent();
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		labelSlider.Text = slider.Value.ToString();
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        labelStepper.Text = stepper.Value.ToString();
    }

    //private void RadioButton_CheckedChanged(object sender, ValueChangedEventArgs e)
    //{
    //    dynamic control = sender;
    //    DisplayAlert("Test", "Radio button has changed to " + control.Content.ToString(), "Ok");
    //}
}