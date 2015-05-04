using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PorteFolio.LIB
{
    public class Mission
    {
        #region Proprietes

        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlAttribute("Nom")]
        public String Nom { get; set; }

        #endregion

        #region Attributs
        #endregion

        public Mission()
        {
        }
        public Mission( int ID, String Nom)
        {
            this.ID = ID;
            this.Nom = Nom;
        }

        public override string ToString()
        {
            return "M-" + ID + "-" + Nom;
        }
    }
}
