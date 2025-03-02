using BookManagement.Samples;
using Xunit;

namespace BookManagement.EntityFrameworkCore.Applications;

[Collection(BookManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookManagementEntityFrameworkCoreTestModule>
{

}
