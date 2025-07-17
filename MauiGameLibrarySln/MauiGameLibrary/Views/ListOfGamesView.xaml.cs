namespace MauiGameLibrary.Views;

public partial class ListOfGamesView : ContentPage
{
	public ListOfGamesView(ListOfGamesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}