using Microsoft.Extensions.Localization;
using BookManagement.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BookManagement.Blazor.WebApp.Tiered.Client;

[Dependency(ReplaceServices = true)]
public class BookManagementBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BookManagementResource> _localizer;

    public BookManagementBrandingProvider(IStringLocalizer<BookManagementResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
