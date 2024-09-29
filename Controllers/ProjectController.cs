using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectMangament.Model;
using ProjectMangament.Services;

namespace ProjectMangament.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Projects>>> GetAllProjects()
        {
            try
            {
                var projects = await _projectService.GetAllProjects();
                if (projects.Count == 0)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(projects);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Projects>>GetProjectById(int id)
        {
            try
            {
                var project = await _projectService.GetProjectsById(id);
                if(project == null) {
                    return NoContent();
                
                }
                else
                {
                    return Ok(project);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult>AddProject(Projects projects)
        {
            try
            {
                var result = await _projectService.AddProject(projects);
                if (result == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(result);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoveProject(int id)
        {
            try
            {
               await  _projectService.DeleteProject(id);
                return Ok("Deleted");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Projects>> UpdateProject(int id,Projects projects)
       
        {
            if (id != projects.Id)
            {
                return BadRequest();
            }
            else
            {
              await  _projectService.UpdateProject(projects);
                return Ok(projects);
            }


        }
    }
}
