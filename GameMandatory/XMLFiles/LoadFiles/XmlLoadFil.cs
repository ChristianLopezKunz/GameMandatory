using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GameMandatory.XMLFiles.LoadFiles
{
    public class XmlLoadFil
    {
        string filePath = @"C:\Users\chr_k\Desktop\Opgaver\Valgfag c#\Mandatory assignment\GameMandatory\GameMandatory\bin\Debug\net7.0\SetupWorld.xml";
        public static World LoadWorld(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            var xNode = doc.DocumentElement.SelectSingleNode("MaxX");
            var yNode = doc.DocumentElement.SelectSingleNode("MaxY");

            int x = int.Parse(xNode.InnerText.Trim());
            int y = int.Parse(yNode.InnerText.Trim());

            return new World(x,y);
        }
    }
}
