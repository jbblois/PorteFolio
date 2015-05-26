using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PorteFolio.LIB;
namespace PorteFolio.WPF
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Outils.FicheCompetence = FicheCompetence.Load("FicheCompetences");
            if (Outils.FicheCompetence == null)
            {
                Outils.FicheCompetence = new FicheCompetence(true);
            }
            new MainWindow().ShowDialog();
        }

        private void Application_Exit(object sender = null, ExitEventArgs e = null)
        {
            FicheCompetence.Save(Outils.FicheCompetence, "FicheCompetences");
        }
    }
}
