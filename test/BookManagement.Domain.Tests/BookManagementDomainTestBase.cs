using Volo.Abp.Modularity;

namespace BookManagement;

/* Inherit from this class for your domain layer tests. */
public abstract class BookManagementDomainTestBase<TStartupModule> : BookManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
