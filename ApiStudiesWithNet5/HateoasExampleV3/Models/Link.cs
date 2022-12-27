namespace HateoasExampleV3.Models
{
    public class Link
    {
        public Link(string rel, string href, string method)
        {
            this.Rel = rel;
            this.Href = href;
            this.Method = method;
        }

        public string Rel {get; set;}
        public string Href {get; set;}
        public string Method {get; set;}
    }
}