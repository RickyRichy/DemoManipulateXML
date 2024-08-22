using System.Xml.Serialization;

namespace DemoManipulateXML.Models
{
    public class Warrior
    {
        [XmlAttribute("Money")]
        public double money { get; set; }
        [XmlAttribute("Bonus")]
        public double bonus { get; set; }
        [XmlAttribute("Strength")]
        public int strength { get; set; }
        [XmlAttribute("Stamina")]
        public int stamina { get; set; }
        [XmlAttribute("Level")]
        public int level { get; set; }
        [XmlAttribute("Experience")]
        public int experience { get; set; }
        [XmlAttribute("Power")]
        public int power { get; set; }
        [XmlElement("Items")]
        public Items items { get; set; } = default!;
    }

    public class Items
    {
        [XmlElement("Item")]
        public List<Item> item { get; set; }
    }
}