using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace AsyncVoid
{
	public class MainViewModel : ViewModelBase
    {
		private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            private set => Set(ref _isBusy, value);
        }

		public IAsyncCommand Submit { get; private set; }
      
        public MainViewModel()
        {
			Submit = new AsyncCommand(ExecuteSubmitAsync, CanExecuteSubmit);
        }

        private async Task ExecuteSubmitAsync()
        {
			try
			{
				IsBusy = true;
				var coffeeService = new CoffeeService();
				await coffeeService.PrepareCoffeeAsync();
			}
			finally
			{
				IsBusy = false;
			}
        }

        private bool CanExecuteSubmit()
        {
			return !IsBusy;
        }
    }
}
