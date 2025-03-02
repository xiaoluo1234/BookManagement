using BookManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BookManagement.Blazor.Client;

public abstract class BookManagementComponentBase : AbpComponentBase
{
    protected BookManagementComponentBase()
    {
        LocalizationResource = typeof(BookManagementResource);
    }
}
