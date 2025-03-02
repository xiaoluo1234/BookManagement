using BookManagement.Equipments.Exception;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace BookManagement.Equipments;

/// <summary>
/// 【设备定义 定义一个设备】仓储
/// </summary>
public class EquipmentRepository(IDbContextProvider<IEquipmentsDbContext> dbContextProvider)
    : EfCoreRepository<IEquipmentsDbContext, Equipment, Guid>(dbContextProvider), 
        IEquipmentRepository
{
    public override async Task<IQueryable<Equipment>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }

    public override async Task<Equipment> GetAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = new())
    {
        var entity = await FindAsync(id, includeDetails, GetCancellationToken(cancellationToken));
        return entity switch
        {
            null => throw new EquipmentNotFoundException(id),
            _ => entity
        };
    }

    public new async Task<Equipment> GetAsync(Expression<Func<Equipment, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = new())
    {
        var entity = await FindAsync(predicate, includeDetails, GetCancellationToken(cancellationToken));
        return entity switch
        {
            null => throw new EquipmentNotFoundException(),
        _ => entity
        };
    }
}