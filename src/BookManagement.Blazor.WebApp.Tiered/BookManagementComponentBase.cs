using BookManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BookManagement.Blazor.WebApp.Tiered;

public abstract class BookManagementComponentBase : AbpComponentBase
{
    protected BookManagementComponentBase()
    {
        LocalizationResource = typeof(BookManagementResource);
    }
}
