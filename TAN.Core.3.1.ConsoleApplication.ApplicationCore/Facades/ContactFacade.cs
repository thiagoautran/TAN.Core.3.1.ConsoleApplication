using System.Threading.Tasks;
using TAN.Core._3._1.ConsoleApplication.ApplicationCore.Interfaces;

namespace TAN.Core._3._1.ConsoleApplication.ApplicationCore.Facades
{
    public class ContactFacade : IContactFacade
    {
        private readonly IContactService _contactService;

        public ContactFacade(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task AddAsync()
        {
            await _contactService.ValidateAsync();
            await _contactService.AddAsync();
        }
    }
}