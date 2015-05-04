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

        [XmlAttribute("Nom")]
        public String Nom { get; set; }

        [XmlAttribute("Origine")]
        public EOrigine Origine { get; set; }

        [XmlAttribute("Nature")]
        public ENature Nature { get; set; }
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
