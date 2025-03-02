using Volo.Abp.Modularity;

namespace BookManagement;

public abstract class BookManagementApplicationTestBase<TStartupModule> : BookManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
