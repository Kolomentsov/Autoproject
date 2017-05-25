using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Automedon
{
    public class Settings
    {
        public static Settings GetSettings()
        {
            Settings sett = null;
            string filename = World.SittingsFile;
            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xmlser = new XmlSerializer(typeof(Settings));
                    sett = (Settings)xmlser.Deserialize(fs);
                    fs.Close();
                }
            }
            else sett = new Settings();
            return sett;
        }

        public void Save()
        {
            string filename = World.SittingsFile;
            if (File.Exists(filename)) File.Delete(filename);
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(Settings));
                xmlser.Serialize(fs, this);
                fs.Close();
            }
        }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Otchestvo { get; set; }
        public string Mail { get; set; }
        public string Comment { get; set; }
    }

}
