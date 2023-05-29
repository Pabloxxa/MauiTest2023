namespace MauiTest.BindingDemo;

public partial class BindingDemoTest : ContentPage
{
    public BindingDemoTest()
    {
        InitializeComponent();
    }

    private void btnOk_Clicked(object sender, EventArgs e)
    {
        var person = new Person()
        {
            Name = "Juan Ossa",
            Phone = "3243668217",
            Address = "Barbosa, Antioquia"
        };

        //var personBinding = new Binding();
        //personBinding.Source = person;
        //personBinding.Path = "Name";

        lblName.BindingContext= person;
        lblName.SetBinding(Label.TextProperty, "Name");
        BindingContext = person;

    }
}