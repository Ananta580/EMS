using EMS.Entities;
using EMS.Infrastructure.Repository;
using EMS.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IRepository<Project> Repository = null;
        public ProjectController(IRepository<Project> repository)
        {
            Repository = repository;
        }
        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            try
            {
                var projects = Repository.GetAll();
                return Ok(new ApiResult(true, "Projects Loaded Successfully", projects));
            }
            catch(Exception exception)
            {
                return Ok(new ApiResult(false, "Error:Project Loads", exception));
            }
        }
        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> AddProject([FromBody]Project project)
        {
            try
            {
                if (project.Id == Guid.Empty)
                {
                    project.Id = Guid.NewGuid();
                    await Repository.AddAsync(project);
                    return Ok(new ApiResult(true, "Project Added Successfully"));
                }
                else
                {
                    await Repository.UpdateAsync(project);
                    return Ok(new ApiResult(true, "Project Added Successfully"));
                }
            }
            catch (Exception exception)
            {
                return Ok(new ApiResult(false, "Error:Project Add", exception));
            }
        }
    }
}
