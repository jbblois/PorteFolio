using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PorteFolio.LIB
{
    [Serializable]
    public class Processus
    {
        #region Proprietes
        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlAttribute("Nom")]
        public String Nom { get; set; }

        public List<Domaine> Domaines { get; set; }
        #endregion

        public Processus()
        {
            Domaines = new List<Domaine>();
        }
        public Processus(int ID, String Nom)
        {
            this.ID = ID;
            this.Nom = Nom;
            
            Domaines = new List<Domaine>();
        }

        public override string ToString()
        {
            return "P-" + ID + "-" + Nom;
        }
    }
}
