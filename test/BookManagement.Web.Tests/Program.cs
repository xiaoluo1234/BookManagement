using Microsoft.AspNetCore.Builder;
using BookManagement;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();

builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("BookManagement.Web.csproj");
await builder.RunAbpModuleAsync<BookManagementWebTestModule>(applicationName: "BookManagement.Web" );

public partial class Program
{
}
