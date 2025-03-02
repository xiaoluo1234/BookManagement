using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Arim.Ims.Equipments.EntityFrameworkCore;
using Arim.Ims.Equipments.EquipmentTypes.Exceptions;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace BookManagement.EquipmentTypes;

/// <summary>
/// 【设备类型】仓储
/// </summary>
public class EquipmentTypeRepository(IDbContextProvider<IBookManagementDbContext> dbContextProvider)
    : EfCoreRepository<IBookManagementDbContext, EquipmentType, Guid>(dbContextProvider), 
        IEquipmentTypeRepository
{
    public override async Task<IQueryable<EquipmentType>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }

    public override async Task<EquipmentType> GetAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = new())
    {
        var entity = await FindAsync(id, includeDetails, GetCancellationToken(cancellationToken));
        return entity switch
        {
            null => throw new EquipmentTypeNotFoundException(id),
            _ => entity
        };
    }

    public new async Task<EquipmentType> GetAsync(Expression<Func<EquipmentType, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = new())
    {
        var entity = await FindAsync(predicate, includeDetails, GetCancellationToken(cancellationToken));
        return entity switch
        {
            null => throw new EquipmentTypeNotFoundException(),
        _ => entity
        };
    }
}