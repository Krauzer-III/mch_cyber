using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MosHack_2021.MosApi;
using Newtonsoft.Json;
using System.Linq;

namespace MosHack_2021.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get(bool isPersonal)
        {
            if (isPersonal)
            {
                return JsonConvert.SerializeObject(ParseAPI.GetPersonalRecomendation(ParseAPI.ConvertToCustomEvent(ParseAPI.GetJson())));
            }
            else
            {
                return JsonConvert.SerializeObject(ParseAPI.ConvertToCustomEvent(ParseAPI.GetJson()));
            }
        }


        [HttpPost]
        public string Post(string dateFrom = "", string dateTo = "", string typeEvent = "")
        {
            var result = ParseAPI.GetJson();
            result = result.OrderByDescending(e => e.date_from).ToList();
            ParseAPI.SortByDate(ref result, dateFrom, dateTo);
            return JsonConvert.SerializeObject(ParseAPI.ConvertToCustomEvent(result));
        }
    }
}
