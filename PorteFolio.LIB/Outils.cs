using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorteFolio.LIB
{
    public static class Outils
    {
        public static FicheCompetence FicheCompetence { get; set; }
    }

    public class FicheCompetence
    {
        public List<Processus> ListProcessus { get; set; }
        public List<Mission> ListMissions { get; set; }
        
        public FicheCompetence()
        {
            ListProcessus = new List<Processus>();
            ListMissions = new List<Mission>();
        }

        public static bool Save(FicheCompetence FicheCompetence)
        {
            System.Xml.Serialization.XmlSerializer writer = null;
            System.IO.FileStream file = null;
            try
            {
                writer = new System.Xml.Serialization.XmlSerializer(typeof(FicheCompetence));
                file = System.IO.File.Create("FicheCompetences.xml");
                writer.Serialize(file, FicheCompetence);
                return true;
            }
            catch (Exception )
            {
            }
            finally
            {
                try
                {
                    file.Close();
                }
                catch (Exception )
                {
                }
            }

            return false;

        }
        public static bool Save(FicheCompetence FicheCompetence, String Path)
        {
            System.Xml.Serialization.XmlSerializer writer = null;
            System.IO.FileStream file = null;
            try
            {
                writer = new System.Xml.Serialization.XmlSerializer(typeof(FicheCompetence));
                file = System.IO.File.Create(Path+".xml");
                writer.Serialize(file, FicheCompetence);
                return true;
            }
            catch (Exception )
            {
            }
            finally
            {
                try
                {
                    file.Close();
                }
                catch (Exception )
                {
                }
            }

            return false;

        }

        public static FicheCompetence Load()
        {
            FicheCompetence context = new FicheCompetence();
            System.IO.StreamReader file = null;
            try
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(FicheCompetence));

                file = new System.IO.StreamReader("FicheCompetences.xml");

                return (FicheCompetence)reader.Deserialize(file);
            }
            catch (Exception )
            {
                return null;
            }
            finally
            {
                try
                {
                    file.Close();
                }
                catch (Exception )
                {
                }

            }

        }
        public static FicheCompetence Load(String Path)
        {
            FicheCompetence context = new FicheCompetence();
            System.IO.StreamReader file = null;
            try
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(FicheCompetence));

                file = new System.IO.StreamReader(Path+".xml");

                return (FicheCompetence)reader.Deserialize(file);
            }
            catch (Exception )
            {
                return null;
            }
            finally
            {
                try
                {
                    file.Close();
                }
                catch (Exception )
                {
                }

            }

        }
    }

}
