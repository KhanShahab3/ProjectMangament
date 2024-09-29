using Microsoft.IdentityModel.Tokens;
using ProjectMangament.Model;
using ProjectMangament.ProjectDbContext;

namespace ProjectMangament.Services
{
    public class ProjectService:IProjectService
    {
        private readonly ApplicationDbContext _context;
        public ProjectService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Projects>> GetAllProjects()
        {
            var result = _context.Projects.ToList();
            return result;

        }
        public async Task<int> AddProject(Projects projects)
        {
            _context.Projects.Add(projects);
            var project= await _context.SaveChangesAsync();
            return project;
        }
        public async Task<Projects> GetProjectsById(int id)
        {
           var project= await _context.Projects.FindAsync(id);
            if(project == null)
            {
                throw new Exception("Not found");
            }
            else
            {
                return project;
            }
        }
        public async Task<Projects> UpdateProject(Projects project) {
            _context.Projects.Update(project);
           await _context.SaveChangesAsync();
            return project;
         
            
                
                
                }
      public async Task<int> DeleteProject(int Id)
        {
            var project =await _context.Projects.FindAsync(Id);
            if (project != null)
            {
              _context.Remove(project);
                return await _context.SaveChangesAsync();
            }
            else
            {
                return 0;
            }


        }
    }
}
