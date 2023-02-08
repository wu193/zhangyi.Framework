using System;
using System.Threading.Tasks;
using ZeorStack.DeviceCenter.Domain.Repositories;

namespace ZeorStack.DeviceCenter.Domain.Aggregates.BuyerAggregate
{
    //This is just the RepositoryContracts or Interface defined at the Domain Layer
    //as requisite for the Buyer Aggregate
    public interface IBuyerRepository : IRepository<Buyer>
    {
        Buyer Add(Buyer buyer);

        Buyer Update(Buyer buyer);

        Task<Buyer?> FindAsync(Guid userId);

        Task<Buyer?> FindByIdAsync(Guid id);
    }
}
