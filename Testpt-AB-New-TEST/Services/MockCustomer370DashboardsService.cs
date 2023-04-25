namespace pt_AB_New_TEST.Customer370Dashboards
{
    public class MockCustomer370DashboardsService : ICustomer370DashboardsService
    {
        public Task<List<DashboardsType>> GetDashboards()
        {
            return Task.FromResult<List<DashboardsType>>(new());
        }
    }
}