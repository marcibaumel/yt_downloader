// Ignore Spelling: backend

using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace backend.Controllers
{
    public class VideoController : Controller
    {
        [HttpGet("DownloadVideo/{link}")]
        public ActionResult<String> DownloadVideo(string link)
        {
            Log.Information("Given link "+ link);
            return Ok(link);
        }
    }
}
