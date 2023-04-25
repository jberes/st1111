namespace pt_AB_New_TEST.ProjectTracker
{
    public class MockProjectTrackerService : IProjectTrackerService
    {
        public Task<List<sp_Select_ProjectsResult>> Getsp_Select_ProjectsResult()
        {
            return Task.FromResult<List<sp_Select_ProjectsResult>>(new());
        }
    }
}