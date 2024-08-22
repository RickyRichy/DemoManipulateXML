using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DemoManipulateXML.Models;

namespace DemoManipulateXML.Pages
{
    public class IndexModel : PageModel
    {
        public Root Root { get; set; }

        public void OnGet()
        {
            // Đường dẫn tới file XML
            string xmlFilePath = "../DemoManipulateXML/XML/users-lv52.xml";
            
            // Đọc và phân tích file XML
            Root = DeserializeXmlFile<Root>(xmlFilePath);

            var weaponList = Root.warriors.warrior.items.item
                .Where(c => c.nameItem.StartsWith("WEAPON"))
                .ToList();

            List<string> weaponName = new();
            foreach (var item in weaponList)
            {
                
                weaponName.Add(item.nameItem);
                Console.WriteLine(item.nameItem);

            }

            var helmList = Root.warriors.warrior.items.item
                .Where(c => c.nameItem.StartsWith("HELM"))
                .ToList();

            List<string> helmName = new();
            foreach (var item in helmList)
            {

                helmName.Add(item.nameItem);
                Console.WriteLine(item.nameItem);

            }

            var armorList = Root.warriors.warrior.items.item
                .Where(c => c.nameItem.StartsWith("ARMOR"))
                .ToList();

            List<string> armorName = new();
            foreach (var item in armorList)
            {

                armorName.Add(item.nameItem);
                Console.WriteLine(item.nameItem);

            }

            var enchantmentList = Root.warriors.warrior.items.item
                .Where(c => c.enchantments != null)
                .Select(c => c.enchantments?.perks)
                .ToList();

            List<string> enchantmentName = new();
            foreach ( var item in enchantmentList )
            {
                foreach (var perkName in item)
                {
                    enchantmentName.Add(perkName.namePerk);
                }
            }

            enchantmentName = enchantmentName.Distinct().ToList();

            foreach (var item in enchantmentName)
            {
                Console.WriteLine(item);
            }

            var rootItem = Root.warriors.warrior.items.item.Count();

            //Console.WriteLine(rootItem);
        }

        // Phương thức để phân tích file XML thành đối tượng
        public static T DeserializeXmlFile<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream reader = new(filePath, FileMode.Open))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
