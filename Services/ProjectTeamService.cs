using Microsoft.EntityFrameworkCore;
using ProjectMangament.Model;
using ProjectMangament.ProjectDbContext;

namespace ProjectMangament.Services
{
    public class ProjectTeamService:IProjectTeamService
    {
        private readonly ApplicationDbContext _context;
        public ProjectTeamService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProjectTeam>> GetProjectTeam()
        {
         var result=await _context.ProjectTeam.ToListAsync();
            return result;
        }
        public async Task<ProjectTeam> GetProjectTeamById(int id)
        {
            var team =await _context.ProjectTeam.FindAsync(id);
            if(team == null)
            {
                throw new Exception("Not Found");
            }
            return team;
           
        }
        public async Task<int> DeleteProjectTeam(int id)
        {
            var team = await _context.ProjectTeam.FindAsync(id);
            if(team == null)
            {
                throw new Exception("Not found");
            }
            else
            {
                _context.Remove(team);
                return await  _context.SaveChangesAsync();
            }
        }
        public async Task<int> UpdateProjectTeam(ProjectTeam team)
        {
            _context.ProjectTeam.Update(team);
            return await _context.SaveChangesAsync();

        }
        public async Task<int> AddProjectTeam(ProjectTeam team)
        {
            _context.ProjectTeam.Add(team);
            return await _context.SaveChangesAsync();
        }
    }
}
