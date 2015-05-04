using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PorteFolio.LIB;

namespace PorteFolio.WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Activite ActiviteSelected { get { return (Activite)ComboBox_Activites.SelectedItem; } }
        public MainWindow()
        {
            InitializeComponent();
            ComboBox_Processus.ItemsSource = Outils.FicheCompetence.ListProcessus;
            
            List<ELocalisation> eLocalisations = new List<ELocalisation>{ ELocalisation.Organisation, ELocalisation.CentreFormation, ELocalisation.Mixte, ELocalisation.Autre };
            ComboBox_Localisation.ItemsSource = eLocalisations;

            List<EContexte> eContextes = new List<EContexte>{ EContexte.Analyse, EContexte.Production, EContexte.Support };
            ComboBox_Contexte.ItemsSource = eContextes;

            List<ESituation> eSituations = new List<ESituation> { ESituation.Vecue, ESituation.Observee, ESituation.Simulee, ESituation.Mixte };
            ComboBox_Situation.ItemsSource = eSituations;

            ComboBox_Missions.ItemsSource = Outils.FicheCompetence.ListMissions;
        }

        private void RefreshActivite(Activite Activite)
        {
            if (Activite != null)
            {
                ComboBox_Processus.SelectedItem = Activite.Domaine.Processus;
                ComboBox_Domaines.SelectedItem = Activite.Domaine;
                ComboBox_Activites.SelectedItem = Activite;
            }
        }

        private void ComboBox_Processus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Processus processusSelected = (Processus)ComboBox_Processus.SelectedItem;
            if (processusSelected != null)
            {
                ComboBox_Domaines.ItemsSource = processusSelected.Domaines;
            }
            else
            {
                ComboBox_Domaines.ItemsSource = null;
            }
            ComboBox_Domaines.SelectedItem = null;
        }

        private void ComboBox_Domaines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Domaine domaineSelected = (Domaine)ComboBox_Domaines.SelectedItem;
            if (domaineSelected != null)
            {
                ComboBox_Activites.ItemsSource = domaineSelected.Activites;
            }
            else
            {
                ComboBox_Activites.ItemsSource = null;
            }
            ComboBox_Activites.SelectedItem = null;
        }

        private void ComboBox_Activites_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshActivite(ActiviteSelected);
        }
    }
}
