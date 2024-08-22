using System.Xml;
using System.Xml.Serialization;

namespace DemoManipulateXML.Models
{
    [XmlRoot("Root")]
    public class User
    {
        [XmlElement("Warriors")]
        public List<Warrior> warriors { get; set; }
    }
}
