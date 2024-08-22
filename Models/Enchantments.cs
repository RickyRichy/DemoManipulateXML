using System.Xml.Serialization;

namespace DemoManipulateXML.Models
{
    public class Enchantments
    {
        [XmlElement("Perk")]
        public List<Perk> perks { get; set; } = default!;
    }
}