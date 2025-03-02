using Volo.Abp.Modularity;

namespace BookManagement;

[DependsOn(
    typeof(BookManagementDomainModule),
    typeof(BookManagementTestBaseModule)
)]
public class BookManagementDomainTestModule : AbpModule
{

}
