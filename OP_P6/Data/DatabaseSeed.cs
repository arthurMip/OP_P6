using Microsoft.EntityFrameworkCore;
using OP_P6.Data.Entities;

namespace OP_P6.Data;

public static class DatabaseSeed
{
    public static void Seed(ApplicationDbContext context)
    {
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        context.OperatingSystems.AddRange(
            new Entities.OperatingSystem { Name = "Linux" },
            new Entities.OperatingSystem { Name = "MacOS" },
            new Entities.OperatingSystem { Name = "Windows" },
            new Entities.OperatingSystem { Name = "Android" },
            new Entities.OperatingSystem { Name = "iOS" },
            new Entities.OperatingSystem { Name = "Windows Mobile" }
        );


        context.Products.AddRange(
            new Product { Name = "Trader en Herbe" },
            new Product { Name = "Maître des Investissements" },
            new Product { Name = "Planificateur d’Entraînement" },
            new Product { Name = "Planificateur d’Anxiété Sociale" }
        );

        var product1Versions = new List<Entities.Version>
        {
            new Entities.Version { Name = 1.0M },
            new Entities.Version { Name = 1.1M },
            new Entities.Version { Name = 1.2M },
            new Entities.Version { Name = 1.3M }
        };

        var prodcut2Versions = new List<Entities.Version>
        {
            new Entities.Version { Name = 1.0M },
            new Entities.Version { Name = 2.0M },
            new Entities.Version { Name = 2.1M }
        };

        var prodcut3Versions = new List<Entities.Version>
        {
            new Entities.Version { Name = 1.0M },
            new Entities.Version { Name = 1.1M },
            new Entities.Version { Name = 2.0M },
        };

        var prodcut4Versions = new List<Entities.Version>
        {
            new Entities.Version { Name = 1.0M },
            new Entities.Version { Name = 1.1M },
        };

        context.Versions.AddRange(product1Versions);
        context.Versions.AddRange(prodcut2Versions);
        context.Versions.AddRange(prodcut3Versions);
        context.Versions.AddRange(prodcut4Versions);

        context.SaveChanges();

        var product1 = context.Products.First(p => p.Name == "Trader en Herbe");
        var product2 = context.Products.First(p => p.Name == "Maître des Investissements");
        var product3 = context.Products.First(p => p.Name == "Planificateur d’Entraînement");
        var product4 = context.Products.First(p => p.Name == "Planificateur d’Anxiété Sociale");

        var linux = context.OperatingSystems.First(os => os.Name == "Linux");
        var macOs = context.OperatingSystems.First(os => os.Name == "MacOS");
        var windows = context.OperatingSystems.First(os => os.Name == "Windows");
        var android = context.OperatingSystems.First(os => os.Name == "Android");
        var iOS = context.OperatingSystems.First(os => os.Name == "iOS");
        var windowsMobile = context.OperatingSystems.First(os => os.Name == "Windows Mobile");

        var p1v10 = product1Versions.First(v => v.Name == 1.0M);
        var p1v11 = product1Versions.First(v => v.Name == 1.1M);
        var p1v12 = product1Versions.First(v => v.Name == 1.2M);
        var p1v13 = product1Versions.First(v => v.Name == 1.3M);

        var p2v10 = prodcut2Versions.First(v => v.Name == 1.0M);
        var p2v20 = prodcut2Versions.First(v => v.Name == 2.0M);
        var p2v21 = prodcut2Versions.First(v => v.Name == 2.1M);

        var p3v10 = prodcut3Versions.First(v => v.Name == 1.0M);
        var p3v11 = prodcut3Versions.First(v => v.Name == 1.1M);
        var p3v20 = prodcut3Versions.First(v => v.Name == 2.0M);

        var p4v10 = prodcut4Versions.First(v => v.Name == 1.0M);
        var p4v11 = prodcut4Versions.First(v => v.Name == 1.1M);


        context.ProductVersionOperatingSystems.AddRange(
            // Trader en Herbe;
            new ProductVersionOperatingSystem { Product = product1, Version = p1v10, OperatingSystem = linux },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v10, OperatingSystem = windows },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v11, OperatingSystem = linux },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v11, OperatingSystem = macOs },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v11, OperatingSystem = windows },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v12, OperatingSystem = linux },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v12, OperatingSystem = macOs },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v12, OperatingSystem = windows },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v12, OperatingSystem = android },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v12, OperatingSystem = iOS },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v12, OperatingSystem = windowsMobile },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v13, OperatingSystem = macOs },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v13, OperatingSystem = windows },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v13, OperatingSystem = android },
            new ProductVersionOperatingSystem { Product = product1, Version = p1v13, OperatingSystem = iOS },
            // Maître des Investissements;
            new ProductVersionOperatingSystem { Product = product2, Version = p2v10, OperatingSystem = macOs },
            new ProductVersionOperatingSystem { Product = product2, Version = p2v10, OperatingSystem = iOS },
            new ProductVersionOperatingSystem { Product = product2, Version = p2v20, OperatingSystem = macOs },
            new ProductVersionOperatingSystem { Product = product2, Version = p2v20, OperatingSystem = android },
            new ProductVersionOperatingSystem { Product = product2, Version = p2v20, OperatingSystem = iOS },
            new ProductVersionOperatingSystem { Product = product2, Version = p2v21, OperatingSystem = macOs },
            new ProductVersionOperatingSystem { Product = product2, Version = p2v21, OperatingSystem = windows },
            new ProductVersionOperatingSystem { Product = product2, Version = p2v21, OperatingSystem = android },
            new ProductVersionOperatingSystem { Product = product2, Version = p2v21, OperatingSystem = iOS },
            // Planificateur d’Entraînement;
            new ProductVersionOperatingSystem { Product = product3, Version = p3v10, OperatingSystem = linux },
            new ProductVersionOperatingSystem { Product = product3, Version = p3v10, OperatingSystem = macOs },
            new ProductVersionOperatingSystem { Product = product3, Version = p3v11, OperatingSystem = linux },
            new ProductVersionOperatingSystem { Product = product3, Version = p3v11, OperatingSystem = macOs },
            new ProductVersionOperatingSystem { Product = product3, Version = p3v11, OperatingSystem = windows },
            new ProductVersionOperatingSystem { Product = product3, Version = p3v11, OperatingSystem = android },
            new ProductVersionOperatingSystem { Product = product3, Version = p3v11, OperatingSystem = iOS },
            new ProductVersionOperatingSystem { Product = product3, Version = p3v11, OperatingSystem = windowsMobile },
            new ProductVersionOperatingSystem { Product = product3, Version = p3v20, OperatingSystem = macOs },
            new ProductVersionOperatingSystem { Product = product3, Version = p3v20, OperatingSystem = windows },
            new ProductVersionOperatingSystem { Product = product3, Version = p3v20, OperatingSystem = android },
            new ProductVersionOperatingSystem { Product = product3, Version = p3v20, OperatingSystem = iOS },
            // Planificateur d’Anxiété Sociale;
            new ProductVersionOperatingSystem { Product = product4, Version = p4v10, OperatingSystem = macOs },
            new ProductVersionOperatingSystem { Product = product4, Version = p4v10, OperatingSystem = windows },
            new ProductVersionOperatingSystem { Product = product4, Version = p4v10, OperatingSystem = android },
            new ProductVersionOperatingSystem { Product = product4, Version = p4v10, OperatingSystem = iOS },
            new ProductVersionOperatingSystem { Product = product4, Version = p4v11, OperatingSystem = macOs },
            new ProductVersionOperatingSystem { Product = product4, Version = p4v11, OperatingSystem = windows },
            new ProductVersionOperatingSystem { Product = product4, Version = p4v11, OperatingSystem = android },
            new ProductVersionOperatingSystem { Product = product4, Version = p4v11, OperatingSystem = iOS }
        );

        context.SaveChanges();

        context.Tickets.AddRange(
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                        .First(pvos => pvos.ProductId == product1.Id && pvos.VersionId == p1v10.Id && pvos.OperatingSystemId == linux.Id),
                Created = new DateTime(2024, 1, 1),
                Status = "Pending",
                Problem = "L'utilisateur constate que lors de la mise à jour du portefeuille dans \"Trader en Herbe\" sur Linux, les nouvelles transactions n'apparaissent pas, même après plusieurs tentatives de rafraîchissement.",
                Solution = "Il est possible que le programme ne parvienne pas à se connecter au serveur pour synchroniser les données. Demander à l'utilisateur de vérifier sa connexion Internet et de s'assurer que le pare-feu ne bloque pas l'application. Si le problème persiste, envoyer une demande à l'équipe de développement pour vérifier la compatibilité du programme avec les dernières versions des distributions Linux."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product1.Id && pvos.VersionId == p1v11.Id && pvos.OperatingSystemId == macOs.Id),
                Created = new DateTime(2024, 1, 2),
                Resolved = new DateTime(2024, 2, 2),
                Status = "Resolved",
                Problem = "L'utilisateur rapporte que \"Trader en Herbe\" cesse de répondre lorsqu'il tente d'importer des données historiques pour une analyse approfondie.",
                Solution = "Le problème peut être lié à un fichier de données corrompu ou trop volumineux. Conseiller à l'utilisateur de vérifier le format et la taille du fichier importé. Suggérer d'importer les données en plusieurs segments plus petits. Transmettre le problème à l'équipe de développement pour optimiser la gestion des imports de données volumineuses."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product1.Id && pvos.VersionId == p1v12.Id && pvos.OperatingSystemId == windows.Id),
                Created = new DateTime(2024, 1, 3),
                Status = "Pending",
                Problem = "Lors de l'exécution de \"Trader en Herbe\" sur Windows, l'utilisateur reçoit un message d'erreur \"Mémoire insuffisante\" après quelques heures d'utilisation.",
                Solution = "Cela peut être dû à une fuite de mémoire dans l'application. Demander à l'utilisateur de redémarrer le programme et de vérifier l'utilisation de la mémoire dans le Gestionnaire des tâches. Informer l'équipe de développement pour qu'elle identifie et corrige la fuite de mémoire dans une prochaine mise à jour.",
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product1.Id && pvos.VersionId == p1v13.Id && pvos.OperatingSystemId == android.Id),
                Created = new DateTime(2024, 1, 4),
                Resolved = new DateTime(2024, 2, 4),
                Status = "Resolved",
                Problem = "L'utilisateur ne peut pas se connecter à son compte sur l'application \"Trader en Herbe\" pour Android ; un message d'erreur indique \"Identifiants invalides\" malgré l'utilisation des bonnes informations.",
                Solution = "Il se peut que le clavier virtuel ajoute des espaces ou que le mode de saisie automatique interfère. Demander à l'utilisateur de saisir manuellement ses identifiants sans autocomplétion. Si le problème persiste, suggérer de réinitialiser le mot de passe. Envoyer une alerte à l'équipe de développement pour améliorer la gestion des entrées du clavier virtuel."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product1.Id && pvos.VersionId == p1v12.Id && pvos.OperatingSystemId == iOS.Id),
                Created = new DateTime(2024, 1, 5),
                Status = "Pending",
                Problem = "Le problème peut provenir d'une incompatibilité avec la nouvelle version d'iOS. Conseiller à l'utilisateur de vérifier les mises à jour de l'application dans l'App Store. Si aucune mise à jour n'est disponible, informer l'équipe de développement pour qu'elle publie une version compatible.",
                Solution = "Après la mise à jour vers la dernière version d'iOS, l'application \"Trader en Herbe\" n'affiche plus les graphiques en temps réel."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product1.Id && pvos.VersionId == p1v12.Id && pvos.OperatingSystemId == windowsMobile.Id),
                Created = new DateTime(2024, 1, 6),
                Resolved = new DateTime(2024, 2, 6),
                Status = "Resolved",
                Problem = "L'utilisateur remarque que les taux de change ne se mettent pas à jour automatiquement dans \"Trader en Herbe\" sur Windows Mobile.",
                Solution = "Vérifier que la fonction de mise à jour automatique est activée dans les paramètres de l'application. Si c'est le cas, le problème peut être lié à une connexion Internet instable. Demander à l'utilisateur de tester sur un réseau différent. Si le problème continue, signaler à l'équipe de développement pour qu'elle examine la fonctionnalité de mise à jour automatique."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product1.Id && pvos.VersionId == p1v10.Id && pvos.OperatingSystemId == windows.Id),
                Created = new DateTime(2024, 1, 7),
                Status = "Pending",
                Problem = "Lors de l'utilisation de la fonction de trading automatique sur \"Trader en Herbe\" pour Windows, l'utilisateur constate que les ordres ne sont pas exécutés selon les paramètres définis.",
                Solution = "Il est possible que les paramètres de trading automatique ne soient pas correctement enregistrés. Demander à l'utilisateur de vérifier et de reconfigurer ses paramètres, puis de sauvegarder avant de relancer la fonction. Si le problème persiste, transmettre les détails à l'équipe de développement pour qu'elle enquête sur un éventuel bug dans le module de trading automatique."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product2.Id && pvos.VersionId == p2v10.Id && pvos.OperatingSystemId == macOs.Id),
                Created = new DateTime(2024, 1, 8),
                Resolved = new DateTime(2024, 2, 6),
                Status = "Resolved",
                Problem = "L'utilisateur remarque que \"Maître des Investissements\" se ferme de manière inattendue lorsqu'il tente d'exporter un rapport financier au format PDF. Aucun message d'erreur n'est affiché avant la fermeture de l'application.",
                Solution = "Il est possible que l'application rencontre un conflit avec les paramètres d'impression par défaut de macOS. Demander à l'utilisateur de vérifier les permissions d'accès au dossier de destination et de s'assurer que macOS est à jour. Envoi d'une demande à l'équipe de développement pour investiguer le problème d'exportation et ajouter des messages d'erreur appropriés en cas de défaillance."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product2.Id && pvos.VersionId == p2v21.Id && pvos.OperatingSystemId == windows.Id),
                Created = new DateTime(2024, 1, 9),
                Status = "Pending",
                Problem = "L'utilisateur signale que les données de marché en temps réel ne se mettent pas à jour dans \"Maître des Investissements\" sur Windows, malgré une connexion Internet stable. Les graphiques restent statiques et ne reflètent pas les dernières variations du marché.",
                Solution = "Il se peut que le pare-feu Windows bloque les connexions sortantes de l'application. Demander à l'utilisateur de vérifier les paramètres du pare-feu et d'ajouter une exception pour \"Maître des Investissements\". Si le problème persiste, suggérer de vérifier les paramètres de proxy ou VPN qui pourraient interférer. Transmettre le problème à l'équipe de développement pour améliorer la gestion des connexions réseau et ajouter des notifications en cas de perte de connexion."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product2.Id && pvos.VersionId == p2v20.Id && pvos.OperatingSystemId == android.Id),
                Created = new DateTime(2024, 1, 10),
                Resolved = new DateTime(2024, 2, 10),
                Status = "Resolved",
                Problem = "Sur l'application Android de \"Maître des Investissements\", l'utilisateur constate que les notifications push ne fonctionnent pas. Il ne reçoit aucune alerte sur les fluctuations importantes du marché, malgré avoir activé les notifications dans les paramètres de l'application.",
                Solution = "Le problème peut être dû aux paramètres de l'appareil ou à une restriction d'économie d'énergie. Demander à l'utilisateur de vérifier que l'application est autorisée à envoyer des notifications dans les paramètres du système Android, et qu'elle n'est pas optimisée pour la batterie. Si les notifications sont toujours absentes, informer l'équipe de développement pour vérifier la fonctionnalité des notifications push sur Android.\r\n\r\n"
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product2.Id && pvos.VersionId == p2v10.Id && pvos.OperatingSystemId == iOS.Id),
                Created = new DateTime(2024, 1, 11),
                Status = "Pending",
                Problem = "Lors de la tentative de connexion à \"Maître des Investissements\" sur iOS, l'utilisateur reçoit le message d'erreur \"Impossible de vérifier l'identité du serveur\". L'application ne permet pas de se connecter, bloquant ainsi l'accès aux fonctionnalités.",
                Solution = "Il est probable que l'application rencontre des problèmes avec le certificat SSL. Demander à l'utilisateur de vérifier qu'il dispose de la dernière version de l'application et d'iOS. Suggérer de redémarrer l'appareil et de réessayer. Envoi d'une alerte à l'équipe de développement pour qu'elle examine les certificats SSL et s'assure qu'ils sont correctement configurés pour iOS.\r\n\r\n"
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product2.Id && pvos.VersionId == p2v20.Id && pvos.OperatingSystemId == iOS.Id),
                Created = new DateTime(2024, 1, 12),
                Resolved = new DateTime(2024, 2, 12),
                Status = "Resolved",
                Problem = "L'utilisateur note que \"Maître des Investissements\" sur iOS consomme une quantité excessive de batterie, même lorsqu'il est en arrière-plan. La batterie de l'appareil se décharge beaucoup plus rapidement que d'habitude.",
                Solution = "Conseiller à l'utilisateur de fermer complètement l'application lorsqu'elle n'est pas utilisée, et de vérifier si le rafraîchissement en arrière-plan est activé pour l'application. Si oui, suggérer de le désactiver pour économiser la batterie. Informer l'équipe de développement pour optimiser la consommation d'énergie de l'application sur iOS, en particulier en arrière-plan.\r\n\r\n"
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product2.Id && pvos.VersionId == p2v21.Id && pvos.OperatingSystemId == windows.Id),
                Created = new DateTime(2024, 1, 13),
                Status = "Pending",
                Problem = "Lors de l'installation de \"Maître des Investissements\" sur Windows, l'utilisateur reçoit un message d'erreur indiquant \"Erreur 1603 : Erreur fatale lors de l'installation\". L'installation échoue et le logiciel ne s'installe pas.",
                Solution = "L'erreur 1603 est généralement liée à un problème d'installation Windows. Demander à l'utilisateur de vérifier qu'il dispose des droits administrateur et qu'aucune autre installation n'est en cours. Suggérer de nettoyer les fichiers temporaires et de réessayer l'installation. Si le problème persiste, fournir à l'équipe de développement les logs d'installation pour aider à identifier la cause exacte et améliorer le processus d'installation.\r\n\r\n"
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product3.Id && pvos.VersionId == p3v10.Id && pvos.OperatingSystemId == linux.Id),
                Created = new DateTime(2024, 1, 14),
                Resolved = new DateTime(2024, 2, 14),
                Status = "Resolved",
                Problem = "L'utilisateur constate que \"Planificateur d’Entraînement\" ne se lance pas sur certaines distributions Linux. Lors de l'exécution, un message d'erreur indique \"Librairie manquante : libfitness.so\".",
                Solution = "Il est probable que certaines dépendances ne soient pas installées. Demander à l'utilisateur d'installer la bibliothèque manquante en exécutant sudo apt-get install libfitness. Suggérer à l'équipe de développement d'inclure une vérification des dépendances lors de l'installation et de fournir une documentation détaillée pour les utilisateurs Linux."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product3.Id && pvos.VersionId == p3v10.Id && pvos.OperatingSystemId == macOs.Id),
                Created = new DateTime(2024, 1, 15),
                Status = "Pending",
                Problem = "L'utilisateur rapporte que \"Planificateur d’Entraînement\" se fige lorsqu'il tente de synchroniser son programme avec l'application Calendrier de macOS.",
                Solution = "Il se peut que l'application n'ait pas les permissions nécessaires pour accéder au calendrier. Demander à l'utilisateur de vérifier dans \"Préférences Système\" > \"Sécurité et confidentialité\" > \"Calendrier\" que \"Planificateur d’Entraînement\" est autorisé. Si le problème persiste, suggérer de redémarrer le système. Informer l'équipe de développement pour qu'elle vérifie la compatibilité avec la dernière version de macOS."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product3.Id && pvos.VersionId == p3v11.Id && pvos.OperatingSystemId == windows.Id),
                Created = new DateTime(2024, 1, 16),
                Resolved = new DateTime(2024, 2, 16),
                Status = "Resolved",
                Problem = "Lors de l'importation d'un plan d'entraînement depuis un fichier Excel, l'utilisateur reçoit un message d'erreur \"Format de fichier non pris en charge\".",
                Solution = "Le fichier Excel pourrait être dans un format incompatible. Demander à l'utilisateur de s'assurer que le fichier est enregistré au format .xlsx et que les données respectent le modèle requis par l'application. Fournir un modèle de fichier si nécessaire. Transmettre le problème à l'équipe de développement pour améliorer la compatibilité avec différents formats de fichiers."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product3.Id && pvos.VersionId == p3v11.Id && pvos.OperatingSystemId == android.Id),
                Created = new DateTime(2024, 1, 17),
                Status = "Pending",
                Problem = "L'application \"Planificateur d’Entraînement\" ne synchronise pas les données avec le compte utilisateur, même avec une connexion Internet active.",
                Solution = "Vérifier que l'application a les permissions nécessaires en allant dans \"Paramètres\" > \"Applications\" > \"Planificateur d’Entraînement\" > \"Permissions\", et s'assurer que l'accès à Internet est autorisé. Si le problème continue, demander à l'utilisateur de se déconnecter puis de se reconnecter à son compte. Informer l'équipe de développement pour examiner les problèmes de synchronisation."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product3.Id && pvos.VersionId == p3v20.Id && pvos.OperatingSystemId == iOS.Id),
                Created = new DateTime(2024, 1, 18),
                Resolved = new DateTime(2024, 2, 18),
                Status = "Resolved",
                Problem = "L'utilisateur ne reçoit pas les notifications de rappel pour les séances d'entraînement programmées.",
                Solution = "Demander à l'utilisateur de vérifier que les notifications sont activées pour l'application en allant dans \"Réglages\" > \"Notifications\" > \"Planificateur d’Entraînement\". S'assurer également que le mode \"Ne pas déranger\" n'est pas activé. Si le problème persiste, suggérer de réinstaller l'application. Notifier l'équipe de développement pour vérifier la fonctionnalité des notifications sur iOS."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product3.Id && pvos.VersionId == p3v20.Id && pvos.OperatingSystemId == android.Id),
                Created = new DateTime(2024, 1, 19),
                Status = "Pending",
                Problem = "Après la dernière mise à jour, l'application plante lors de l'accès à la section \"Statistiques\".",
                Solution = "Il est possible que la mise à jour ait introduit un bug. Demander à l'utilisateur de vider le cache et les données de l'application via \"Paramètres\" > \"Applications\" > \"Planificateur d’Entraînement\" > \"Stockage\". Si cela ne résout pas le problème, suggérer de désinstaller puis de réinstaller l'application. Informer l'équipe de développement pour qu'elle corrige le bug dans la prochaine mise à jour."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product4.Id && pvos.VersionId == p4v10.Id && pvos.OperatingSystemId == macOs.Id),
                Created = new DateTime(2024, 1, 20),
                Resolved = new DateTime(2024, 2, 20),
                Status = "Resolved",
                Problem = "L'utilisateur constate que l'application \"Planificateur d’Anxiété Sociale\" ne sauvegarde pas les modifications apportées aux séances programmées. Après avoir fermé et rouvert l'application, les changements ne sont pas enregistrés.",
                Solution = "Il est possible que l'application n'ait pas les permissions nécessaires pour écrire dans le répertoire de sauvegarde. Demander à l'utilisateur de vérifier les permissions en allant dans \"Préférences Système\" > \"Sécurité et confidentialité\" > \"Confidentialité\" > \"Accès complet au disque\", et s'assurer que \"Planificateur d’Anxiété Sociale\" est autorisé. Si le problème persiste, suggérer de réinstaller l'application. Informer l'équipe de développement pour vérifier les mécanismes de sauvegarde sur macOS."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product4.Id && pvos.VersionId == p4v11.Id && pvos.OperatingSystemId == windows.Id),
                Created = new DateTime(2024, 1, 21),
                Status = "Pending",
                Problem = "Lors du lancement de \"Planificateur d’Anxiété Sociale\" sur Windows, l'utilisateur reçoit un message d'erreur \"Erreur de connexion à la base de données\". L'application ne démarre pas et reste bloquée sur l'écran de chargement.",
                Solution = "Il se peut que les fichiers de configuration soient corrompus ou que l'antivirus bloque l'accès à la base de données locale. Demander à l'utilisateur de vérifier les paramètres de l'antivirus et de créer une exception pour l'application. Si cela ne résout pas le problème, suggérer de supprimer les fichiers de configuration situés dans le dossier AppData et de relancer l'application pour générer de nouveaux fichiers. Transmettre le problème à l'équipe de développement pour améliorer la gestion des erreurs de connexion à la base de données."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product4.Id && pvos.VersionId == p4v10.Id && pvos.OperatingSystemId == android.Id),
                Created = new DateTime(2024, 1, 22),
                Resolved = new DateTime(2024, 2, 22),
                Status = "Resolved",
                Problem = "L'utilisateur signale que les rappels de séances programmées dans \"Planificateur d’Anxiété Sociale\" ne se déclenchent pas à l'heure prévue sur son appareil Android.",
                Solution = "Vérifier que les notifications sont activées pour l'application en allant dans \"Paramètres\" > \"Applications\" > \"Planificateur d’Anxiété Sociale\" > \"Notifications\". S'assurer également que l'appareil n'est pas en mode \"Économie d'énergie\" ou \"Ne pas déranger\", ce qui pourrait empêcher les rappels. Si le problème persiste, demander à l'utilisateur de redémarrer l'appareil. Informer l'équipe de développement pour s'assurer que la fonctionnalité de rappel fonctionne correctement sur Android."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product4.Id && pvos.VersionId == p4v11.Id && pvos.OperatingSystemId == iOS.Id),
                Created = new DateTime(2024, 1, 23),
                Status = "Pending",
                Problem = "Après la mise à jour de l'application \"Planificateur d’Anxiété Sociale\" sur iOS, l'utilisateur remarque que certaines fonctionnalités, comme le journal de bord, ne s'affichent plus correctement.",
                Solution = "Il est possible que la mise à jour n'ait pas été installée correctement. Demander à l'utilisateur de supprimer et de réinstaller l'application depuis l'App Store. Avant de le faire, s'assurer que les données sont sauvegardées sur le compte utilisateur pour éviter toute perte d'informations. Si le problème continue, signaler le bug à l'équipe de développement pour qu'elle corrige les problèmes d'affichage dans la prochaine version.\r\n\r\n"
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product4.Id && pvos.VersionId == p4v11.Id && pvos.OperatingSystemId == macOs.Id),
                Created = new DateTime(2024, 1, 24),
                Resolved = new DateTime(2024, 2, 24),
                Status = "Resolved",
                Problem = "L'utilisateur ne parvient pas à synchroniser \"Planificateur d’Anxiété Sociale\" avec son calendrier iCloud sur macOS. Les événements créés dans l'application n'apparaissent pas dans le calendrier du système.",
                Solution = "Vérifier que l'application est autorisée à accéder au calendrier en allant dans \"Préférences Système\" > \"Sécurité et confidentialité\" > \"Confidentialité\" > \"Calendriers\", et s'assurer que \"Planificateur d’Anxiété Sociale\" est coché. Si l'autorisation est déjà donnée, suggérer de déconnecter et reconnecter le compte iCloud. Si le problème persiste, transmettre l'information à l'équipe de développement pour qu'elle examine la fonctionnalité de synchronisation avec iCloud."
            },
            new Ticket
            {
                ProductVersionOperatingSystem = context.ProductVersionOperatingSystems
                    .First(pvos => pvos.ProductId == product4.Id && pvos.VersionId == p4v10.Id && pvos.OperatingSystemId == windows.Id),
                Created = new DateTime(2024, 1, 25),
                Status = "Pending",
                Problem = "L'utilisateur remarque que \"Planificateur d’Anxiété Sociale\" affiche des caractères illisibles ou des symboles étranges à la place du texte dans l'application sur Windows.",
                Solution = "Cela peut être dû à un problème d'encodage ou à une police manquante. Demander à l'utilisateur de vérifier que les paramètres régionaux et linguistiques de Windows sont correctement configurés pour le français. Suggérer également de réinstaller l'application pour s'assurer que toutes les polices nécessaires sont installées. Si le problème continue, informer l'équipe de développement pour qu'elle corrige les problèmes d'affichage des caractères dans l'application."
            }
        );

        context.SaveChanges();
    }
}
