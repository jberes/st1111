using Bunit;
using Microsoft.Extensions.DependencyInjection;
using pt_AB_New_TEST.Pages;
using pt_AB_New_TEST.ProjectTracker;
using pt_AB_New_TEST.Customer370Dashboards;
using pt_AB_New_TEST.NorthwindCloudApp;

namespace Testpt_AB_New_TEST
{
	public class TestView_2
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbCategoryChartModule));
			ctx.Services.AddScoped<IProjectTrackerService>(sp => new MockProjectTrackerService());
			ctx.Services.AddScoped<ICustomer370DashboardsService>(sp => new MockCustomer370DashboardsService());
			ctx.Services.AddScoped<INorthwindCloudAppService>(sp => new MockNorthwindCloudAppService());
			var componentUnderTest = ctx.RenderComponent<View_2>();
			Assert.NotNull(componentUnderTest);
		}
	}
}