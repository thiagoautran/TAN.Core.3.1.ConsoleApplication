using System.Threading.Tasks;

namespace TAN.Core._3._1.ConsoleApplication.ApplicationCore.Interfaces
{
    public interface IContactService
    {
        Task ValidateAsync();

        Task AddAsync();
    }
}