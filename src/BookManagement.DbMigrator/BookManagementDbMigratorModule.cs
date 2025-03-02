using BookManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BookManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookManagementEntityFrameworkCoreModule),
    typeof(BookManagementApplicationContractsModule)
    )]
public class BookManagementDbMigratorModule : AbpModule
{
}
