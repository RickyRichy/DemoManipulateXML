using System.Xml.Serialization;

namespace DemoManipulateXML.Models
{
    public class Item
    {
        [XmlAttribute("Name")]
        public string nameItem { get; set; } = default!;
        [XmlAttribute("Equipped")]
        public bool isEquipped { get; set; }
        [XmlAttribute("Count")]
        public int count { get; set; }
        [XmlAttribute("UpgradeLevel")]
        public int upgradeLevel { get; set; }
        [XmlAttribute("DeliveryTime")]
        public int deliveryTime { get; set; }
        [XmlAttribute("DeliveryUpgradeLevel")]
        public int deliveryUpgradeLevel { get; set; }
        [XmlAttribute("AcquireType")]
        public string acquireType { get; set; } = "Upgrade";
        [XmlElement("Enchantments")]
        public Enchantments? enchantments { get; set; }
    }
}