using Newtonsoft.Json;

namespace MosHack_2021.MosApi
{
    public class JsonEvent
    {
        public _items[] items { get; set; }
    }

    public class _items
    {
        public string id { get; set; }
        public string lang { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string date_from { get; set; }
        public string date_to { get; set; }
        public string date_from_timestamp { get; set; }
        public string date_to_timestamp { get; set; }
        public string date { get; set; }
        public string date_timestamp { get; set; }
        public string created_at { get; set; }
        public string created_at_timestamp { get; set; }
        public string updated_at { get; set; }
        public string updated_at_timestamp { get; set; }
        public string published_at { get; set; }
        public string status { get; set; }
        public int search { get; set; }
        public int ya_rss { get; set; }
        public int free { get; set; }
        public int is_powered { get; set; }
        public string label { get; set; }
        public int oiv_id { get; set; }
        public _restriction restriction { get; set; }
        public int has_image { get; set; }
        public string active_from { get; set; }
        public string active_to { get; set; }
        public string active_from_timestamp { get; set; }
        public string active_to_timestamp { get; set; }
        public string icon_id { get; set; }
        public _kind kind { get; set; }
        public int is_oiv_publication { get; set; }
        public string ebs_id { get; set; }
        public string ebs_type { get; set; }
        public string ebs_title { get; set; }
        public string ebs_agent_uid { get; set; }
        public string[] organizations { get; set; }
        public _image image { get; set; }
    }

    public class _restriction
    {
        public int age { get; set; }
    }

    public class _kind
    {
        public string id { get; set; }
        public string title { get; set; }
        public int type { get; set; }
    }
    public class _image
    {
        public int id { get; set; }
        public string title { get; set; }
        public string copyright { get; set; }
        public _imageParams original { get; set; }
        public _imageParams small { get; set; }
        public _imageParams MyProperty { get; set; }
        public _imageParams middle { get; set; }
        public _imageParams big { get; set; }
        public _imageParams download { get; set; }
        public _imageParams thumb { get; set; }
        public _imageParams show { get; set; }
        [JsonProperty("1x1_m")]
        public _imageParams _1x1_m { get; set; }
        [JsonProperty("1x1_s")]
        public _imageParams _1x1_s { get; set; }
        [JsonProperty("2x1_b")]
        public _imageParams _2x1_b { get; set; }
        [JsonProperty("2x1_m")]
        public _imageParams _2x1_m { get; set; }
        [JsonProperty("2x1_s")]
        public _imageParams _2x1_s { get; set; }
        [JsonProperty("3x1_b")]
        public _imageParams _3x1_b { get; set; }
        [JsonProperty("3x1_m")]
        public _imageParams _3x1_m { get; set; }
        [JsonProperty("3x1_s")]
        public _imageParams _3x1_s { get; set; }
        [JsonProperty("4x1_b")]
        public _imageParams _4x1_b { get; set; }
        [JsonProperty("4x1_m")]
        public _imageParams _4x1_m { get; set; }
        [JsonProperty("4x1_s")]
        public _imageParams _4x1_s { get; set; }
    }

    public class _imageParams
    {
        public string id { get; set; }
        public string title { get; set; }
        public string src { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string type { get; set; }
    }
}
