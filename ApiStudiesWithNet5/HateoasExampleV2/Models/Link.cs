namespace HateoasExampleV2.Models
{
    public class Link
    {
        public string Rel {get; set;}
        public string Href {get; set;}
        public string Method {get; set;}

        public Link(string rel, string href, string method)
        {
            Rel = rel;
            Href = href;
            Method = method;
        }
    }
}