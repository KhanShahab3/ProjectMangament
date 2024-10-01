using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectMangament.Model;
using ProjectMangament.Services;

namespace ProjectMangament.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Teams>>> GetAllTeams()
        {
            try
            {
                var teams = await _teamService.GetAllTeams();
                if(teams.Count<=0)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(teams);
                }
                    
                
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Teams>>GetTeamById(int id)
        {
            return await _teamService.GetTeamsById(id);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult>UpdateTeam(int id,Teams teams)
        {
            if (id != teams.Id)
            {
                return BadRequest("Inavalid Id");
            }
            await _teamService.UpdateTeam(teams);
            return Ok(teams);
        }
        [HttpPost]
        public async Task<ActionResult>AddTeam(Teams teams)
        {
            await _teamService.AddTeam(teams);
            return Ok(teams);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult>DeleteTeam(int id)
        {
            await _teamService.DeleteTeam(id);
            return Ok("Deleted........!");
        }
    }
}
