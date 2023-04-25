using Bunit;
using Microsoft.Extensions.DependencyInjection;
using pt_AB_New_TEST.Pages;
using pt_AB_New_TEST.PtTEST;

namespace Testpt_AB_New_TEST
{
	public class TestView_1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule));
			ctx.Services.AddScoped<IPtTESTService>(sp => new MockPtTESTService());
			var componentUnderTest = ctx.RenderComponent<View_1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}