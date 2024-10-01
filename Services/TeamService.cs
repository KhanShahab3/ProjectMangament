using Microsoft.EntityFrameworkCore;
using ProjectMangament.Model;
using ProjectMangament.ProjectDbContext;

namespace ProjectMangament.Services
{
    public class TeamService:ITeamService
    {
        private readonly ApplicationDbContext _context;
        public TeamService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Teams>> GetAllTeams()
        {
            try
            {
                var result = await _context.Teams.ToListAsync();
                if (result.Count<=0)
                {
                    throw new Exception("Not found");
                }
                else
                {
                    return result;
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<Teams> GetTeamsById(int id)
        {
            var team= await _context.Teams.FindAsync(id);
            if(team == null)
            {
                throw new Exception("not found");
            }
            else
            {
                return team;
            }
        }
        public async Task<int> DeleteTeam(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            if(team == null)
            {
                throw new Exception("not found");

            }
            else
            {
                 _context.Remove(team);
                return await _context.SaveChangesAsync();   
            }

        }
        public async Task<int> AddTeam(Teams team)
        {
            _context.Add(team); 
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateTeam(Teams team)
        {
            _context.Teams.Update(team); 
            return await _context.SaveChangesAsync();
        }
    }
}
