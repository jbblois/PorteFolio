using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PorteFolio.LIB
{
    [Serializable]
    public class Competence
    {
        #region Proprietes
        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlAttribute("Nom")]
        public String Nom { get; set; }

        [XmlAttribute("Checked")]
        public Boolean Check { get; set; }
        #endregion


        public Competence()
        {

        }
        public Competence(int ID, String Nom)
        {
            this.ID = ID;
            this.Nom = Nom;
        }
    }
}
