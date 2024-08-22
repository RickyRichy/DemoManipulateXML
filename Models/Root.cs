using System.Xml.Serialization;

namespace DemoManipulateXML.Models
{
    [XmlRoot("Root")]
    public class Root
    {
        [XmlElement("Warriors")]
        public Warriors warriors { get; set; }
    }

    public class Warriors
    {
        [XmlElement("Warrior")]
        public Warrior warrior { get; set; }
    }
}
