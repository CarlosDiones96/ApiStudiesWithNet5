namespace HateoasExample.Models
{
    public class Link
    {
        public string Href {get; set;}
        public string Rel {get; set;}
        public string Method {get; set;}

        public Link(string rel, string href, string method)
        {
            Href = href;
            Rel = rel;
            Method = method;
        }
    }
}