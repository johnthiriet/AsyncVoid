using System;
using Xamarin.Forms;

namespace AsyncVoid
{
	public partial class MainPage : ContentPage
	{
		public MainViewModel ViewModel { get; private set; }

        public MainPage()
		{
			InitializeComponent();

			BindingContext = ViewModel = new MainViewModel();
		}

        public void OnPrepareButtonClick(object sender, EventArgs e)
        {
			IErrorHandler errorHandler = null; // Get an instance somewhere
			ViewModel.Submit.ExecuteAsync().FireAndForgetSafeAsync(errorHandler);
        }
    }
}
