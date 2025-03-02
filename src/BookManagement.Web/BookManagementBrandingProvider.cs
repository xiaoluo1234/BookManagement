using Microsoft.Extensions.Localization;
using BookManagement.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BookManagement.Web;

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
