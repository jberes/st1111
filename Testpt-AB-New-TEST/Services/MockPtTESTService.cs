namespace pt_AB_New_TEST.PtTEST
{
    public class MockPtTESTService : IPtTESTService
    {
        public Task<List<Tasks>> GetTasks()
        {
            return Task.FromResult<List<Tasks>>(new());
        }

        public Task<Tasks> PostTasks(object data, string contentType)
        {
            return Task.FromResult<Tasks>(new());
        }

        public Task<List<Tasks>> DeleteTasks(string id)
        {
            return Task.FromResult<List<Tasks>>(new());
        }

        public Task<Tasks> PutTasks(object data, string contentType)
        {
            return Task.FromResult<Tasks>(new());
        }
    }
}