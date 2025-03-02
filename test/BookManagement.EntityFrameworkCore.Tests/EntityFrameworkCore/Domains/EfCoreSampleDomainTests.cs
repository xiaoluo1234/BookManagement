using BookManagement.Samples;
using Xunit;

namespace BookManagement.EntityFrameworkCore.Domains;

[Collection(BookManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookManagementEntityFrameworkCoreTestModule>
{

}
