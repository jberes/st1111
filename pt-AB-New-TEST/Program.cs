using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using pt_AB_New_TEST;
using pt_AB_New_TEST.PtTEST;
using pt_AB_New_TEST.ProjectTracker;
using pt_AB_New_TEST.Customer370Dashboards;
using pt_AB_New_TEST.NorthwindCloudApp;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IPtTESTService>(sp => new PtTESTService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<IProjectTrackerService>(sp => new ProjectTrackerService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<ICustomer370DashboardsService>(sp => new Customer370DashboardsService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<INorthwindCloudAppService>(sp => new NorthwindCloudAppService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbGridModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbCardModule)
    );
}