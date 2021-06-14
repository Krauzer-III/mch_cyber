using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MosHack_2021.MyApi
{
    public class _CustomEvent
    {
        public CustomEvent[] Events { get; set; }
    }
    public class CustomEvent
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public Image[] Images { get; set; }
    }

    public class Image
    {
        public string id { get; set; }
        public string title { get; set; }
        public string src { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string type { get; set; }
    }


}
