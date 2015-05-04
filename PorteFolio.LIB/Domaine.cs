using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PorteFolio.LIB
{
    [Serializable]
    public class Domaine
    {
        #region Proprietes

        [XmlAttribute("FID_Processus")]
        public int FID_Processus { get; set; }

        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlAttribute("Nom")]
        public String Nom { get; set; }

        public List<Activite> Activites { get; set; }
        #endregion

        #region Attributs
        [XmlIgnore]
        public Processus Processus 
        { 
            get 
            {
                return Outils.FicheCompetence.ListProcessus.FirstOrDefault(P => P.ID == FID_Processus);
            } 
        }
        #endregion

        public Domaine()
        {
            Activites = new List<Activite>();
        }
        public Domaine(int FID_Processus, int ID, String Nom)
        {
            this.FID_Processus = FID_Processus;
            this.ID = ID;
            this.Nom = Nom;
            
            Activites = new List<Activite>();
        }

        public override string ToString()
        {
            return "D-" + FID_Processus + "." + ID + "-" + Nom;
        }
    }
}
