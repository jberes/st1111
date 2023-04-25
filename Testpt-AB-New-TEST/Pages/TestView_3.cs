using Bunit;
using Microsoft.Extensions.DependencyInjection;
using pt_AB_New_TEST.Pages;
using pt_AB_New_TEST.Customer370Dashboards;

namespace Testpt_AB_New_TEST
{
	public class TestView_3
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbAvatarModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule));
			ctx.Services.AddScoped<ICustomer370DashboardsService>(sp => new MockCustomer370DashboardsService());
			var componentUnderTest = ctx.RenderComponent<View_3>();
			Assert.NotNull(componentUnderTest);
		}
	}
}