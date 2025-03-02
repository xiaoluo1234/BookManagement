using BookManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BookManagement.Blazor.WebApp.Tiered.Client;

public abstract class BookManagementComponentBase : AbpComponentBase
{
    protected BookManagementComponentBase()
    {
        LocalizationResource = typeof(BookManagementResource);
    }
}
