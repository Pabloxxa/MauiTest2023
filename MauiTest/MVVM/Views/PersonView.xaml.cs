using MauiTest.MVVM.Models;

namespace MauiTest.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		var person = new Person()
		{
			Name = "Juan Ossa",
			Age = 38
		};

		BindingContext = person;
	}
}