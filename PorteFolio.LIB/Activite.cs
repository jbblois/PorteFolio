using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PorteFolio.LIB
{
    [Serializable]
    public enum EOrigine
    {
        Creation = 0,
        Adaptation = 1,
        Recuperation = 2
    }

    [Serializable]
    public enum ENature
    {
        Code = 0,
        Solution = 1,
        Logiciel = 2,
        Document = 3
    }

    [Serializable]
    public enum ELocalisation 
    { 
        Organisation = 0,
        CentreFormation = 1,
        Mixte = 2,
        Autre = 3 
    }

    [Serializable]
    public enum EContexte 
    { 
        Analyse = 0, 
        Production = 1, 
        Support = 2 
    }

    [Serializable]
    public enum ESituation 
    { 
        Vecue = 0, 
        Observee = 1, 
        Simulee = 2, 
        Mixte = 3 
    }

    [Serializable]
    public class Activite
    {
        #region Proprietes

        [XmlAttribute("FID_Processus")]
        public int FID_Processus { get; set; }
        [XmlAttribute("FID_Domaine")]
        public int FID_Domaine { get; set; }

        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlAttribute("Nom")]
        public String Nom { get; set; }

        public List<Competence> Competences { get; set; }

        [XmlAttribute("FID_Mission")]
        public int FID_Mission { get; set; }

        [XmlAttribute("Periode")]
        public int Periode { get; set; }

        [XmlAttribute("Acteurs")]
        public String Acteurs { get; set; }

        public String Objectifs { get; set; }

        public String Description { get; set; }

        public List<Support> Supports { get; set; }

        [XmlAttribute("Localisation")]
        public ELocalisation Localisation { get; set; }

        [XmlAttribute("Contexte")]
        public EContexte Contexte { get; set; }

        [XmlAttribute("Situation")]
        public ESituation Situation { get; set; }
        #endregion

        #region attributs
        [XmlIgnore]
        public Domaine Domaine 
        { 
            get 
            {
                Processus processus = Outils.FicheCompetence.ListProcessus.FirstOrDefault(P => P.ID == FID_Processus);
                if (processus != null)
                {
                    return processus.Domaines.FirstOrDefault(D => D.ID == FID_Domaine);
                }
                else
                {
                    return null;
                }
            } 
        }

        [XmlIgnore]
        public Mission Mission
        { 
            get 
            {
                return Outils.FicheCompetence.ListMissions.FirstOrDefault(M => M.ID == FID_Mission);
            }
            set 
            {
                FID_Mission = value.ID;
            }
        }
        #endregion

        public Activite()
        {
        }
        public Activite(int FID_Processus, int FID_Domaine, int ID, String Nom)
        {
            this.FID_Processus = FID_Processus;
            this.FID_Domaine = FID_Domaine;

            this.ID = ID;
            this.Nom = Nom;

            this.Periode = 0;

            this.Acteurs = "";
            this.Objectifs = "";
            this.Description = "";


            Competences = new List<Competence>();
            Supports = new List<Support>();
        }
        public Activite(int FID_Processus, int FID_Domaine, int ID, String Nom, int FID_Mission, int Periode, 
                        String Acteurs, String Objectifs, String Description,
                        ELocalisation Localisation, EContexte Contexte, ESituation Situation)
        {
            this.FID_Processus = FID_Processus;
            this.FID_Domaine = FID_Domaine;

            this.ID = ID;
            this.Nom = Nom;
            
            Competences = new List<Competence>();

            this.FID_Mission = FID_Mission;
            this.Periode = Periode;

            this.Acteurs = Acteurs;
            this.Objectifs = Objectifs;
            this.Description = Description;

            Supports = new List<Support>();

            this.Localisation = Localisation;
            this.Contexte = Contexte;
            this.Situation = Situation;
        }

       public override string ToString()
       {
           return "A-" + FID_Processus + "." + FID_Domaine + "." + ID + "-" + Nom;
       }



    }
}
