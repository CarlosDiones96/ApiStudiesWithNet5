using Newtonsoft.Json;
using System.Collections.Generic;

namespace HateoasExampleV2.Models
{
    public class ResourceList<T>
    {
        public List<T> Items {get;}

        [JsonProperty("_links", Order = -2)]
        public List<Link> Links {get;} = new List<Link>();

        public ResourceList(List<T> items)
        {
            Items = items;
        }
    }
}