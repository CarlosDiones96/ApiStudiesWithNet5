using System.Xml.Serialization;

namespace IntegrationTesting.Models
{
    [XmlRoot("Person")]
    public class PersonDto
    {
        [XmlAttribute]
        public int Id {get; set;}
        [XmlAttribute]
        public string Name {get; set;}
    }
}