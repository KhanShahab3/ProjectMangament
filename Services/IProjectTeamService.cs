using ProjectMangament.Model;

namespace ProjectMangament.Services
{
    public interface IProjectTeamService
    {
        Task<List<ProjectTeam>> GetProjectTeam();
        Task<ProjectTeam>GetProjectTeamById(int id);
        Task<int>DeleteProjectTeam(int id);
        Task<int>UpdateProjectTeam(ProjectTeam team);
        Task<int>AddProjectTeam(ProjectTeam team);
    }
}
