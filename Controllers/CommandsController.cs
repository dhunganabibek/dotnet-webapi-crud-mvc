using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;


namespace Commander.Controllers
{

    // api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly MockCommanderRepo _respository = new MockCommanderRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _respository.GetAppCommands();
            return Ok(commandItems);

        }


        //GET api/commands/5
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _respository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}