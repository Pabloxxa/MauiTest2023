namespace MauiTest;

public partial class AnotherPage : ContentPage
{
	public AnotherPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}