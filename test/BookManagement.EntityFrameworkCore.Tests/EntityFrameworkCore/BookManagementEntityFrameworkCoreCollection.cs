using Xunit;

namespace BookManagement.EntityFrameworkCore;

[CollectionDefinition(BookManagementTestConsts.CollectionDefinitionName)]
public class BookManagementEntityFrameworkCoreCollection : ICollectionFixture<BookManagementEntityFrameworkCoreFixture>
{

}
