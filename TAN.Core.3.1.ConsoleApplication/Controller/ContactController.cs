using System;
using System.Threading.Tasks;
using TAN.Core._3._1.ConsoleApplication.ApplicationCore.Interfaces;

namespace TAN.Core._3._1.ConsoleApplication.Controller
{
    public class ContactController : IContactController
    {
        private readonly IContactFacade _contactFacade;

        public ContactController(IContactFacade contactFacadee)
        {
            _contactFacade = contactFacadee;
        }

        public async Task AddAsync()
        {
            try
            {
                await _contactFacade.AddAsync();
            }
            catch(Exception ex)
            {

            }
        }
    }
}