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
                InitializeFicheCompetence();
            }
            new MainWindow().ShowDialog();
        }

        private void Application_Exit(object sender = null, ExitEventArgs e = null)
        {
            FicheCompetence.Save(Outils.FicheCompetence, "FicheCompetences");
        }

        private void InitializeFicheCompetence()
        {
            #region FicheCompetences

            Outils.FicheCompetence = new FicheCompetence();;

            Processus processus;
            Domaine domaine;
            Activite activite;
            Competence competence;

            #region P1
            processus = new Processus(1, "Production de services");

            #region D11
            domaine = new Domaine(processus.ID, 1, "Analyse de la demande");

            #region A111
            activite = new Activite(processus.ID,domaine.ID, 1, "Analyse du cahier des charges d'un service à produire");

            #region Competences
            competence = new Competence(1, "Recenser et caractériser les contextes d’utilisation, les processus et les acteurs sur lesquels le service à produire aura un impact");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Identifier les fonctionnalités attendues du service à produire");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Préparer sa participation à une réunion ");
            activite.Competences.Add(competence);
            competence = new Competence(4, "Rédiger un compte-rendu d’entretien, de réunion");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A112
            activite = new Activite(processus.ID,domaine.ID, 2, "Etude de l'impact de l'intégration d'un service sur le système informatique");

            #region Competences
            competence = new Competence(1, "Analyser les interactions entre services ");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Recenser les composants de l’architecture technique sur lesquels le service à produire aura un impact");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A113
            activite = new Activite(processus.ID,domaine.ID, 3, "Étude des exigences liées à la qualité attendue d’un service");

            #region Competences
            competence = new Competence(1, "Recenser et caractériser les exigences liées à la qualité attendue du service à produire");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Recenser et caractériser les exigences de sécurité pour le service à produire");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            processus.Domaines.Add(domaine);
            #endregion

            #region D12
            domaine = new Domaine(processus.ID, 2, "Choix d'une solution");

            #region A121
            activite = new Activite(processus.ID,domaine.ID, 1, "Élaboration et présentation d’un dossier de choix de solution technique");

            #region Competences
            competence = new Competence(1, "Recenser et caractériser des solutions répondant au cahier des charges (adaptation d’une solution existante ou réalisation d’une nouvelle)");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Estimer le coût d’une solution");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Rédiger un dossier de choix et un argumentaire technique");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A122
            activite = new Activite(processus.ID,domaine.ID, 2, "Rédaction des spécifications techniques de la solution retenue");

            #region Competences
            competence = new Competence(1, "Recenser les composants nécessaires à la réalisation de la solution retenue");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Décrire l’implantation des différents composants de la solution et les échanges entre eux");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Rédiger les spécifications fonctionnelles et techniques de la solution retenue dans le formalisme exigé par l’organisation");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A123
            activite = new Activite(processus.ID,domaine.ID, 3, "Évaluation des risques liés à l’utilisation d’un service");

            #region Competences
            competence = new Competence(1, "Recenser les risques liés à une mauvaise utilisation ou à une utilisation malveillante du service");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Recenser les risques liés à un dysfonctionnement du service");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Prévoir les conséquences techniques de la non prise en compte d’un risque ");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A124
            activite = new Activite(processus.ID,domaine.ID, 4, "Détermination des tests nécessaires à la validation d’un service");

            #region Competences
            competence = new Competence(1, "Recenser les tests d’acceptation nécessaires à la validation du service et les résultats attendus");
            activite.Competences.Add(competence);
            competence = new Competence(2, "les jeux d’essai et les procédures pour la réalisation des tests");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A125
            activite = new Activite(processus.ID,domaine.ID, 5, "Définition des niveaux d’habilitation associés à un service");

            #region Competences
            competence = new Competence(1, "Recenser les utilisateurs du service, leurs rôles et leur niveau de responsabilité");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Recenser les ressources liées à l’utilisation du service");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Proposer les niveaux d’habilitation associés au service ");
            activite.Competences.Add(competence);
            #endregion

            #endregion

            processus.Domaines.Add(domaine);
            #endregion

            #region D13
            domaine = new Domaine(processus.ID, 3, "Mise en production d'un service");

            #region A131
            activite = new Activite(processus.ID,domaine.ID, 1, "Test d’intégration et d’acceptation d’un service");

            #region Competences
            competence = new Competence(1, "Mettre en place l’environnement de test du service");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Tester le service");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Rédiger le rapport de test");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A132
            activite = new Activite(processus.ID,domaine.ID, 2, "Définition des éléments nécessaires à la continuité d’un service");

            #region Competences
            competence = new Competence(1, "Identifier les éléments à sauvegarder et à journaliser pour assurer la continuité du service et la traçabilité des transactions");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Spécifier les procédures d’alerte associées au service");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Décrire les solutions de fonctionnement en mode dégradé et les procédures de reprise du service ");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A133
            activite = new Activite(processus.ID,domaine.ID, 3, "Accompagnement de la mise en place d’un nouveau service");

            #region Competences
            competence = new Competence(1, "Mettre en place l’environnement de formation au nouveau service");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Informer et former les utilisateurs ");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A134
            activite = new Activite(processus.ID,domaine.ID, 4, "Déploiement d'un service");

            #region Competences
            competence = new Competence(1, "Mettre au point une procédure d’installation de la solution");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Automatiser l’installation de la solution");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Mettre en exploitation le service ");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            processus.Domaines.Add(domaine);
            #endregion

            #region D14
            domaine = new Domaine(processus.ID, 4, "Travail en mode projet");

            #region A141
            activite = new Activite(processus.ID,domaine.ID, 1, "Participation à un projet");

            #region Competences
            competence = new Competence(1, "Établir son planning personnel en fonction des exigences et du déroulement du projet");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Rendre compte de son activité");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A142
            activite = new Activite(processus.ID,domaine.ID, 2, "Évaluation des indicateurs de suivi d’un projet et justification des écarts");

            #region Competences
            competence = new Competence(1, "Suivre l’exécution du projet ");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Analyser les écarts entre temps prévu et temps consommé ");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Contribuer à l’évaluation du projet");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A143
            activite = new Activite(processus.ID,domaine.ID, 3, "Gestion des ressources");

            #region Competences
            competence = new Competence(1, "Recenser les ressources humaines, matérielles, logicielles et budgétaires nécessaires à l’exécution du projet");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Adapter son planning personnel en fonction des ressources disponibles ");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            processus.Domaines.Add(domaine);
            #endregion

            Outils.FicheCompetence.ListProcessus.Add(processus);
            #endregion

            #region P2
            processus = new Processus(2, "Fourniture de services");

            #region D21
            domaine = new Domaine(processus.ID, 1, "Exploitation des services");

            #region A211
            activite = new Activite(processus.ID,domaine.ID, 1, "Accompagnement des utilisateurs dans la prise en main d’un service");

            #region Competences
            competence = new Competence(1, "Aider les utilisateurs dans l’appropriation du nouveau service");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Identifier des besoins de formation complémentaires ");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Rendre compte de la satisfaction des utilisateurs ");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A212
            activite = new Activite(processus.ID,domaine.ID, 2, "Évaluation et maintien de la qualité d’un service");

            #region Competences
            competence = new Competence(1, "Analyser les indicateurs de qualité du service");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Appliquer les procédures d’alerte destinées à rétablir la qualité du service ");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Vérifier périodiquement le fonctionnement du service en mode dégradé");
            activite.Competences.Add(competence);
            competence = new Competence(4, "Superviser les services et leur utilisation");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            processus.Domaines.Add(domaine);
            #endregion

            #region D22
            domaine = new Domaine(processus.ID, 2, "Gestion des incidents et des demandes d’assistance");

            #region A221
            activite = new Activite(processus.ID,domaine.ID, 1, "Suivi et résolution d’incidents");

            #region Competences
            competence = new Competence(1, "Résoudre l’incident en s’appuyant sur une base de connaissances et la documentation associée ou solliciter l’entité compétente");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Prendre le contrôle d’un système à distance");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Rédiger un rapport d'incident et mémoriser l’incident et sa résolution dans une base de connaissances");
            activite.Competences.Add(competence);
            competence = new Competence(4, "Faire évoluer une procédure de résolution d’incident");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A222
            activite = new Activite(processus.ID,domaine.ID, 2, "Suivi et réponse à des demandes d’assistance");

            #region Competences
            competence = new Competence(1, "Identifier le niveau d'assistance souhaité et proposer une réponse adaptée en s’appuyant sur une base de connaissances et sur la documentation associée ou solliciter l’entité compétente");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Informer l'utilisateur de la situation de sa demande");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Prendre le contrôle d’un poste utilisateur à distance");
            activite.Competences.Add(competence);
            competence = new Competence(4, "Mémoriser la demande d'assistance et sa réponse dans une base de connaissances");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A223
            activite = new Activite(processus.ID,domaine.ID, 3, "Réponse à une interruption de service");

            #region Competences
            competence = new Competence(1, "Appliquer la procédure de continuité du service en mode dégradé");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Appliquer la procédure de reprise du service ");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            processus.Domaines.Add(domaine);
            #endregion

            #region D23
            domaine = new Domaine(processus.ID, 3, "Gestion des problèmes et des changements");

            #region A231
            activite = new Activite(processus.ID,domaine.ID, 1, "Identification, qualification et évaluation d’un problème");

            #region Competences
            competence = new Competence(1, "Repérer une suite de dysfonctionnements récurrents d’un service");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Identifier les causes de ce dysfonctionnement");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Qualifier le problème (contexte et environnement)");
            activite.Competences.Add(competence);
            competence = new Competence(4, "Définir le degré d'urgence du problème");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A232
            activite = new Activite(processus.ID,domaine.ID, 2, "Proposition d’amélioration d’un service");

            #region Competences
            competence = new Competence(1, "Décrire les incidences d’un changement proposé sur le service");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Évaluer le délai et le coût de réalisation du changement proposé");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Recenser les risques techniques, humains, financiers et juridiques associés au changement proposé");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            processus.Domaines.Add(domaine);
            #endregion

            Outils.FicheCompetence.ListProcessus.Add(processus);
            #endregion

            #region P4
            processus = new Processus(4, "Conception et maintenance de solutions applicatives");

            #region D41
            domaine = new Domaine(processus.ID, 1, "Conception et réalisation d’une solution applicative");

            #region A411
            activite = new Activite(processus.ID,domaine.ID, 1, "Proposition d’une solution applicative");

            #region Competences
            competence = new Competence(1, "Identifier les composants logiciels nécessaires à la conception de la solution ");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Estimer les éléments de coût et le délai de mise en œuvre de la solution");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A412
            activite = new Activite(processus.ID,domaine.ID, 2, "Conception ou adaptation de l’interface utilisateur d’une solution applicative");

            #region Competences
            competence = new Competence(1, "Définir les spécifications de l’interface utilisateur de la solution applicative");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Maquetter un élément de la solution applicative");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Concevoir et valider la maquette en collaboration avec des utilisateurs");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A413
            activite = new Activite(processus.ID,domaine.ID, 3, "Conception ou adaptation d’une base de données");

            #region Competences
            competence = new Competence(1, "Modéliser le schéma de données nécessaire à la mise en place de la solution applicative");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Implémenter le schéma de données dans un SGBD ");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Programmer des éléments de la solution applicative dans le langage d’un SGBD");
            activite.Competences.Add(competence);
            competence = new Competence(4, "Manipuler les données liées à la solution applicative à travers un langage de requête");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A414
            activite = new Activite(processus.ID,domaine.ID, 4, "Définition des caractéristiques d’une solution applicative");

            #region Competences
            competence = new Competence(1, "Recenser et caractériser les composants existants ou à développer utiles à la réalisation de la solution applicative"
                                          + "dans le respect des budgets et planning prévisionnels");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A415
            activite = new Activite(processus.ID,domaine.ID, 5, "Prototypage de composants logiciels");

            #region Competences
            competence = new Competence(1, "Choisir les éléments de la solution à prototyper");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Développer un prototype");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Valider un prototype");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A416
            activite = new Activite(processus.ID,domaine.ID, 6, "Gestion d’environnements de développement et de test");

            #region Competences
            competence = new Competence(1, "Mettre en place et exploiter un environnement de développement");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Mettre en place et exploiter un environnement de test");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A417
            activite = new Activite(processus.ID,domaine.ID, 7, "Développement, utilisation ou adaptation de composants logiciels");

            #region Competences
            competence = new Competence(1, "Développer les éléments d’une solution ");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Créer un composant logiciel");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Analyser et modifier le code d’un composant logiciel");
            activite.Competences.Add(competence);
            competence = new Competence(4, "Utiliser des composants d’accès aux données ");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A418
            activite = new Activite(processus.ID,domaine.ID, 8, "Réalisation des tests nécessaires à la validation d’éléments adaptés ou développés");

            #region Competences
            competence = new Competence(1, "Élaborer et réaliser des tests unitaires");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Mettre en évidence et corriger les écarts");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A419
            activite = new Activite(processus.ID,domaine.ID, 9, "Rédaction d’une documentation technique");

            #region Competences
            competence = new Competence(1, "Produire ou mettre à jour la documentation technique d’une solution applicative et de ses composants logiciels");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A4110
            activite = new Activite(processus.ID,domaine.ID, 10, "Rédaction d’une documentation d’utilisation");

            #region Competences
            competence = new Competence(1, "Rédiger la documentation d’utilisation, une aide en ligne, une FAQ");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Adapter la documentation d’utilisation à chaque contexte d’utilisation");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            processus.Domaines.Add(domaine);
            #endregion

            #region D42
            domaine = new Domaine(processus.ID, 2, "Maintenance d’une solution applicative");

            #region A421
            activite = new Activite(processus.ID,domaine.ID, 1, "Analyse et correction d’un dysfonctionnement, d’un problème de qualité de service ou de sécurité");

            #region Competences
            competence = new Competence(1, "Élaborer un jeu d’essai permettant de reproduire le dysfonctionnement");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Repérer les composants à l’origine du dysfonctionnement");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Concevoir les mises à jour à effectuer");
            activite.Competences.Add(competence);
            competence = new Competence(4, "Réaliser les mises à jour");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A422
            activite = new Activite(processus.ID,domaine.ID, 2, "Adaptation d’une solution applicative aux évolutions de ses composants");

            #region Competences
            competence = new Competence(1, "Repérer les évolutions des composants utilisés et leurs conséquences");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Concevoir les mises à jour à effectuer");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Élaborer et réaliser les tests unitaires des composants mis à jour");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A423
            activite = new Activite(processus.ID,domaine.ID, 3, "Réalisation des tests nécessaires à la mise en production d’éléments mis à jour");

            #region Competences
            competence = new Competence(1, "Élaborer et réaliser des tests d’intégration et de non régression de la solution mise à jour");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Concevoir une procédure de migration et l’appliquer dans le respect de la continuité de service");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A424
            activite = new Activite(processus.ID,domaine.ID, 4, "Mise à jour d’une documentation technique");

            #region Competences
            competence = new Competence(1, "Repérer les éléments de la documentation à mettre à jour");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Mettre à jour une documentation");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            processus.Domaines.Add(domaine);
            #endregion

            Outils.FicheCompetence.ListProcessus.Add(processus);
            #endregion

            #region P5
            processus = new Processus(5, "Gestion du patrimoine informatique");

            #region D51
            domaine = new Domaine(processus.ID, 1, "Gestion des configurations");

            #region A511
            activite = new Activite(processus.ID,domaine.ID, 1, "Mise en place d’une gestion de configuration");

            #region Competences
            competence = new Competence(1, "Recenser les caractéristiques techniques nécessaires à la gestion des éléments de la configuration d’une organisation");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Paramétrer une solution de gestion des éléments d’une configuration");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A512
            activite = new Activite(processus.ID,domaine.ID, 2, "Recueil d’informations sur une configuration et ses éléments");

            #region Competences
            competence = new Competence(1, "Renseigner les événements relatifs au cycle de vie d’un élément de la configuration");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Actualiser les caractéristiques des éléments de la configuration");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A513
            activite = new Activite(processus.ID,domaine.ID, 3, "Suivi d’une configuration et de ses éléments");

            #region Competences
            competence = new Competence(1, "Contrôler et auditer les éléments de la configuration");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Reconstituer un historique des modifications effectuées sur les éléments de la configuratio");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Identifier les éléments de la configuration à modifier ou à remplacer");
            activite.Competences.Add(competence);
            competence = new Competence(4, "Repérer les équipements obsolètes et en proposer le traitement dans le respect de la réglementation en vigueur");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A514
            activite = new Activite(processus.ID,domaine.ID, 4, "Étude de propositions de contrat de service (client, fournisseur)");

            #region Competences
            competence = new Competence(1, "Assister la maîtrise d’ouvrage dans l’analyse technique de la proposition de contrat");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Interpréter des indicateurs de suivi de la prestation associée à la proposition de contrat");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Renseigner les éléments permettant d’estimer la valeur du service");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A515
            activite = new Activite(processus.ID,domaine.ID, 5, "Évaluation d’un élément de configuration ou d’une configuration");

            #region Competences
            competence = new Competence(1, "Vérifier un plan d’amortissement");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Apprécier la valeur actuelle d'un élément de configuration");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A516
            activite = new Activite(processus.ID,domaine.ID, 6, "Evaluation d'un investissement informatique");

            #region Competences
            competence = new Competence(1, "Renseigner les variables d’une étude de rentabilité d’un investissement ");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Caractériser et prévoir les investissements matériels et logiciels");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            processus.Domaines.Add(domaine);
            #endregion

            #region D52
            domaine = new Domaine(processus.ID, 2, "Gestion des compétences");

            #region A521
            activite = new Activite(processus.ID,domaine.ID, 1, "Exploitation des référentiels, normes et standards adoptés par le prestataire informatique ");

            #region Competences
            competence = new Competence(1, "Évaluer le degré de conformité des pratiques à un référentiel, à une norme ou à un standard adopté par le prestataire informatique");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Identifier et partager les bonnes pratiques à intégrer");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A522
            activite = new Activite(processus.ID,domaine.ID, 2, "Veille technologique");

            #region Competences
            competence = new Competence(1, "Définir une stratégie de recherche d’informations");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Tenir à jour une liste de sources d'information");
            activite.Competences.Add(competence);
            competence = new Competence(3, "Évaluer la qualité d'une source d'information en fonction d'un besoin ");
            activite.Competences.Add(competence);
            competence = new Competence(4, "Synthétiser et diffuser les résultats d'une veille");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A523
            activite = new Activite(processus.ID,domaine.ID, 3, "Repérage des compléments de formation ou d’auto-formation utiles à l’acquisition de nouvelles compétences");

            #region Competences
            competence = new Competence(1, "Identifier les besoins de formation pour mettre en œuvre une technologie, un composant, un outil ou une méthode");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Repérer l’offre et les dispositifs de formation");
            activite.Competences.Add(competence);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            #region A524
            activite = new Activite(processus.ID,domaine.ID, 4, "Étude d'une technologie, d’un composant, d’un outil ou d’une méthode");

            #region Competences
            competence = new Competence(1, "Se documenter à propos d‘une technologie, d’un composant, d’un outil ou d’une méthode");
            activite.Competences.Add(competence);
            competence = new Competence(2, "Identifier le potentiel et les limites d'une technologie, d’un composant, d’un outil ou d’une méthode par rapport à un service à produire");
            activite.Competences.Add(competence);
            #endregion

            processus.Domaines.Add(domaine);
            #endregion

            domaine.Activites.Add(activite);
            #endregion

            Outils.FicheCompetence.ListProcessus.Add(processus);
            #endregion

            #endregion

            Outils.FicheCompetence.ListMissions.Add(new Mission(1, "MegaCasting"));
            Outils.FicheCompetence.ListMissions.Add(new Mission(2, "EntretienSPPP"));
            Outils.FicheCompetence.ListMissions.Add(new Mission(3, "PresentationSPPP"));

            FicheCompetence.Save(Outils.FicheCompetence, "FicheCompetences");
        }
    }
}
