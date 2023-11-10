using Microsoft.AspNetCore.Mvc;
using NetCore_Web_Api.Models;

namespace NetCore_Web_Api.Controllers
{
  [ApiController]
  [Route("client")]
  public class ClientController : ControllerBase
  {
    [HttpGet]
    [Route("list")]
    public dynamic listClient()
    {
      List<Client> clients = new List<Client>
      {
        new Client
        {
          id = "1",
          name = "Juan",
          age = "33",
          mail = "juan@mail.com"
        },
        new Client
        {
          id = "2",
          name = "Rodrigo",
          age = "23",
          mail = "rodrigo@mail.com"
        }
      };

      return clients;
    }

/*    [HttpPost]
    [Route("save")]
    public dynamic saveClient()
    {

    }*/

  }
}
