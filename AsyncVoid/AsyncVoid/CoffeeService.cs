using System.Threading.Tasks;

namespace AsyncVoid
{
    public class CoffeeService
    {
        public async Task PrepareCoffeeAsync()
        {
            /// Asynchronously prepare an awesome coffee
            await Task.Delay(2000);
        }
    }
}
