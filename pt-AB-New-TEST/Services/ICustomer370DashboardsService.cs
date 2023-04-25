namespace pt_AB_New_TEST.Customer370Dashboards
{
    public interface ICustomer370DashboardsService
    {
        Task<List<DashboardsType>> GetDashboards();
    }
}