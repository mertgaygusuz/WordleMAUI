using WordleApp.ViewModel;

namespace WordleApp;

public partial class MainPage : ContentPage
{
	public MainPage(GameViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

	}
}

