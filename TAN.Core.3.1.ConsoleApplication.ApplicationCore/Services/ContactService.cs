using System.Threading.Tasks;
using TAN.Core._3._1.ConsoleApplication.ApplicationCore.Interfaces;

namespace TAN.Core._3._1.ConsoleApplication.ApplicationCore.Services
{
    public class ContactService : IContactService
    {
        private readonly string _param1;

        public ContactService(string param1)
        {
            _param1 = param1;
        }

        public async Task ValidateAsync()
        {

        }

        public async Task AddAsync()
        {

        }
    }
}