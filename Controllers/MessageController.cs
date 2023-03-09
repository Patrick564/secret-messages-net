using SecretMessagesNet.Models;
using SecretMessagesNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace SecretMessagesNet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MessageController : ControllerBase
{
    public MessageController() { }

    [HttpGet]
    public ActionResult<List<Message>> GetAll() =>
        MessageService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Message> Get(int id)
    {
        var message = MessageService.Get(id);

        if (message is null)
            return NotFound();

        return message;
    }
}
