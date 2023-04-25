namespace pt_AB_New_TEST.NorthwindCloudApp
{
    public class MockNorthwindCloudAppService : INorthwindCloudAppService
    {
        public Task<List<Customer>> GetCustomer()
        {
            return Task.FromResult<List<Customer>>(new());
        }
    }
}