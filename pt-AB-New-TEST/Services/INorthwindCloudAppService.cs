namespace pt_AB_New_TEST.NorthwindCloudApp
{
    public interface INorthwindCloudAppService
    {
        Task<List<Customer>> GetCustomer();
    }
}