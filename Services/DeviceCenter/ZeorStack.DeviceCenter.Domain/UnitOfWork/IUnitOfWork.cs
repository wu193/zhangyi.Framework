using System.Threading;
using System.Threading.Tasks;

namespace ZeorStack.DeviceCenter.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}