using Newtonsoft.Json;
using System.Collections.Generic;

namespace HateoasExampleV3.Models
{
    public class ResourceList<T>
    {
        public ResourceList(List<T> items)
        {
            this.items = items;
        }

        public List<T> items {get;}
        [JsonProperty("_links", Order = -2)]
        public List<Link> Links {get;} = new List<Link>();
    }
}