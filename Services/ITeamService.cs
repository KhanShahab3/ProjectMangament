using ProjectMangament.Model;

namespace ProjectMangament.Services
{
    public interface ITeamService
    {
        Task<List<Teams>>GetAllTeams();
        Task<Teams> GetTeamsById(int id);
        Task<int>DeleteTeam(int id);
        Task<int> AddTeam(Teams team);
        Task<Teams> UpdateTeam(Teams team);

    }
}
