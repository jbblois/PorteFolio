using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PorteFolio.LIB
{
    [Serializable]
    public class Support
    {
        #region Proprietes
        [XmlAttribute("Chemin")]
        public String Chemin { get; set; }

        [XmlAttribute("Nom")]
        public String Nom { get; set; }

        [XmlAttribute("Origine")]
        public EOrigine Origine { get; set; }

        [XmlAttribute("Nature")]
        public ENature Nature { get; set; }

        [XmlAttribute("Description")]
        public String Description { get; set; }
        #endregion


        public Support()
        {

        }
        public Support(String Nom, EOrigine Origine, ENature Nature)
        {
            this.Nom = Nom;
            this.Origine = Origine;
            this.Nature = Nature;
        }
    }
}
