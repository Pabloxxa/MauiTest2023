namespace MauiTest;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
    }

    void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnotherPage());
    }
}