using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using SaveTheOcean2.Models;

namespace SaveTheOcean2
{
    public class Methods
    {
      
        public static void XMLPlayers()
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Players");
            xmlDocument.AppendChild(root);
            root.InnerText = "";
            xmlDocument.Save("Players.xml");
        }

        public static bool InRange(int max, int min, int num)
        {
            return (num <= max) && (num >= min);
        }

        public static void WriteXML(Player player)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("Players.xml");
            XmlElement root = xmlDocument.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                if (node["Name"].InnerText == player.Name)
                {
                    node["Xp"].InnerText = player.Xp.ToString();
                    xmlDocument.Save("Players.xml");
                    return;
                }
            }

            XmlElement personElement = xmlDocument.CreateElement("Player");
            XmlElement nameElement = xmlDocument.CreateElement("Name");
            nameElement.InnerText = player.Name;
            XmlElement rolElement = xmlDocument.CreateElement("Role");
            rolElement.InnerText = player.Rol;
            XmlElement xpElement = xmlDocument.CreateElement("Xp");
            xpElement.InnerText = player.Xp.ToString();
            personElement.AppendChild(nameElement);
            personElement.AppendChild(rolElement);
            personElement.AppendChild(xpElement);
            root.AppendChild(personElement);
            xmlDocument.Save("Players.xml");
        }

        public static int Randomizer(int x, int y)
        {
            Random random = new Random();
            return random.Next(x, y + 1);
        }

    }
}
