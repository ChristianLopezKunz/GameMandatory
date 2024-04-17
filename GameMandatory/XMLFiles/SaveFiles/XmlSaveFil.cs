using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GameMandatory.XMLFiles.SaveFiles
{
    public static class XmlSaveFil
    {
         static string filePath = @"C:\Users\chr_k\Desktop\Opgaver\Valgfag c#\Mandatory assignment\GameMandatory\GameMandatory\bin\Debug\net7.0\SetupWorld.xml";
        public static void SaveWorld(World world, string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();

            var root = xmlDoc.CreateElement("World");
            xmlDoc.AppendChild(root);

            var xNode = xmlDoc.CreateElement("MaxX");
            xNode.InnerText = world.MaxX.ToString();
            root.AppendChild(xNode);

            var yNode = xmlDoc.CreateElement("MaxY");
            yNode.InnerText = world.MaxY.ToString();
            root.AppendChild(yNode);

            xmlDoc.Save(filePath);
        }
    }
}
