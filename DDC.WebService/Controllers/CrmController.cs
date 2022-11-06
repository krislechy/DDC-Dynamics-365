using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DDC.WebService.Controllers
{
    [ApiController]
    [EnableCors("AllowAllPolicy")]
    [Route("api/[controller]")]
    public class CrmController : Controller
    {
        private readonly IMediator mediator;
        public CrmController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet(nameof(DownloadAttachments))]
        public async Task<IActionResult> DownloadAttachments(DateTime ge)
        {
            var command = new DDC.BL.Commands.IGetDocumentsCommand()
            {
                Args = new string[] { "--ge", $"{ge.Day}.{ge.Month}.{ge.Year}" },
            };
            return Ok(JsonConvert.SerializeObject(await mediator.Send(command)));
        }
    }
}
