using System.Collections.Generic;
using System.Xml.Serialization;

namespace DemoManipulateXML.Models
{
    public class Perk
    {
        [XmlAttribute("Name")]
        public string namePerk { get; set; } = default!;
        [XmlElement("Set")]
        public Set? set { get; set; }
    }

    public class Set
    {
        [XmlAttribute("Aspect")]
        public double aspect { get; set; }
    }
}