using ProjectMangament.Model;

namespace ProjectMangament.Services
{
    public interface IProjectService
    {
        Task<List<Projects> >GetAllProjects();
        Task<Projects> GetProjectsById(int Id);
        Task<int>AddProject(Projects project);
        Task<Projects>UpdateProject(Projects project);   
        Task<int>DeleteProject(int Id);
    }
}
