using Microsoft.AspNetCore.Builder;
using Company.CommissionManager;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<CommissionManagerWebTestModule>();

public partial class Program
{
}
