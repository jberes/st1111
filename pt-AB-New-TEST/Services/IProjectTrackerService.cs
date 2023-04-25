namespace pt_AB_New_TEST.ProjectTracker
{
    public interface IProjectTrackerService
    {
        Task<List<sp_Select_ProjectsResult>> Getsp_Select_ProjectsResult();
    }
}