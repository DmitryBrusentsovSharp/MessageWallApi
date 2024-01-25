using System.Collections.Generic;
using System.Linq;
using MessageWallApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageWallApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageWallController : ControllerBase
    {
        private ILogger _logger;

        public MessageWallController(ILogger<MessageWallController> logger) 
        {
            _logger = logger;
        }

        // GET: api/<MessageWallController?message=Test&id=4>
        [HttpGet]
        public IEnumerable<string> Get(string first = "", string last = "")
        {
            List<string> output = new List<string>
            {
                "Hello all",
                "How are you?"
            };

            if (string.IsNullOrWhiteSpace(first) == false && string.IsNullOrWhiteSpace(last) == false)
            {
                output.Clear();
                output.Add("Hello");
                output.Add(first);
                output.Add(last);
            }

            return output;
        }

        // GET api/<MessageWallController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MessageWallController>
        [HttpPost]
        public void Post([FromBody] MessageModel message)
        {
            _logger.LogInformation("Our message is {Message}", message.Message);
        }

        // PUT api/<MessageWallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessageWallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
