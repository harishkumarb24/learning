using System.Threading.Tasks;
using WpfDemo.Services;

namespace UnitTests.Mocks
{
    public class DataServiceMock : IDataService
    {
        public async Task<string> GetFullname()
        {
            await Task.Delay(1000);
            return "Adam";
        }
    }
}