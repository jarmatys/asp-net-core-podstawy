using Test_web_app.Models;
using Test_web_app.Services.Interfaces;

namespace Test_web_app.Services
{
    public class WarehouseService : IWarehouseService
    {
        public int Save(Product product)
        {
            // logika zapisująca do bazy
            return 1;
        }
    }
}
