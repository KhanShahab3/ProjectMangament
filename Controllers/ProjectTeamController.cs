using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectMangament.Model;
using ProjectMangament.Services;

namespace ProjectMangament.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectTeamController : ControllerBase
    {
        private readonly IProjectTeamService _projectTeamService;
        public ProjectTeamController(IProjectTeamService projectTeamService)
        {
            _projectTeamService = projectTeamService;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProjectTeam>>> GetAllProjectTeam()
        {
         var projectTeams=   await _projectTeamService.GetProjectTeam();
            if (projectTeams.Count <= 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok(projectTeams);
            }
           
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectTeam>>GetProjectTeamById(int id)
        {
            var result = await _projectTeamService.GetProjectTeamById(id);
            if (result == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(result);
            }
        }
        [HttpPost]
        public async Task<ActionResult>AddProjectTeam(ProjectTeam projectTeam)
        {
            if (projectTeam == null)
            {
                return BadRequest();
            }
            await _projectTeamService.AddProjectTeam(projectTeam);
            return Ok("Created.....!");
        }
        [HttpPut("{id}")]
        public async Task<ActionResult>UpdateProjectTeam(int id, ProjectTeam projectTeam)
        {
          if(projectTeam.Id!== id)
            {
                return BadRequest();
            }
          await _projectTeamService.UpdateProjectTeam(projectTeam);
            return Ok("Updated......!");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult>DeleteProjectTeam(int id)
        {
            await _projectTeamService.DeleteProjectTeam(id);
            return Ok("Deleted.......!");
        }
    }
}
