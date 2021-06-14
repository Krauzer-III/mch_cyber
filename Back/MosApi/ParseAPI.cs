using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MosHack_2021.MyApi;
using Newtonsoft.Json;

namespace MosHack_2021.MosApi
{
    public class ParseAPI
    {
        readonly static string apiAdressAfisha = "https://www.mos.ru/api/newsfeed/v4/frontend/json/ru/afisha";
        readonly static string pageParameter = "page=";

        public static List<_items> GetJson()
        {
            List<_items> events = new List<_items>();
            using (WebClient wc = new WebClient())
            {
                string jsonString = "";
                int pageNumber = 1;
                string apiAdressAfisha_page = $"{apiAdressAfisha}?{pageParameter}{pageNumber}";
                while (jsonString != wc.DownloadString(apiAdressAfisha_page))
                {
                    jsonString = wc.DownloadString(apiAdressAfisha_page);

                    if (jsonString != "")
                    {
                        try
                        {
                            var myObject = JsonConvert.DeserializeObject<JsonEvent>(jsonString);
                            int count = myObject.items.Length;
                            events.AddRange(myObject.items);
                        }
                        catch
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return events;
        }

        public static void SortByDate(ref List<_items> items, string dateFrom, string dateTo)
        {
            for(int i=0; i< items.Count; i++)
            {
                if(dateFrom != "" && Convert.ToDateTime(items[i].date_from) < Convert.ToDateTime(dateFrom) ||
                   dateTo != "" && Convert.ToDateTime(items[i].date_to) > Convert.ToDateTime(dateTo))
                {
                    items.RemoveAt(i);
                    i--;
                    continue;
                }
            }
        }

        public static _CustomEvent ConvertToCustomEvent(List<_items> oldEvent)
        {
            var result = new _CustomEvent();
            result.Events = oldEvent.Select(e => new CustomEvent
            {
               ID = e.id,
               Title = e.title,
               Description = e.text,
               Date = e.date_from.Split(' ')[0],
               Time = e.date_from.Split(' ')[1]
            }).ToArray();
            for(int i=0; i<result.Events.Length; i++)
            {
                result.Events[i].Images = oldEvent.Where(e => e.id == result.Events[i].ID)
                    .Select(e => new Image
                    {
                        id = e.image.original.id,
                        title = e.image.original.title,
                        src = e.image.original.src,
                        width = e.image.original.width,
                        height = e.image.original.height,
                        type = e.image.original.type
                    }).ToArray();
            }

            return result;
        }


        public static _CustomEvent GetPersonalRecomendation(_CustomEvent data)
        {
            List<CustomEvent> lce = new List<CustomEvent>();
            lce.AddRange(data.Events);
            int count = new Random().Next(lce.Count / 6, lce.Count / 4);
            for(int i=0; i< lce.Count - count; i++)
            {
                lce.RemoveAt(new Random().Next(0, lce.Count));
            }
            _CustomEvent ce = new _CustomEvent();
            ce.Events = lce.ToArray();
            return ce;
        }




    }
}
