using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobOverview.POCO;
using System.Data.SqlClient;

namespace JobOverview.DAL
{
    public class DALLogiciel
    {
        /// <summary>
        /// Requete de récupération des informations nécessaire au remplissage de la liste de 
        /// logiciel (incluant la liste de version et de module)
        /// </summary>
        /// <returns>liste de logiciel</returns>
        public static List<Logiciel> GetLogiciel()
        {
            // On récupérer la chaîne de connexion stockée dans le fichier App.config
            var connectString = Properties.Settings.Default.JobOverViewConnectionString;

            var logic = new List<Logiciel>();

            string queryString = @"select L.CodeLogiciel, L.Nom, M.CodeModule, M.Libelle, 
            V.NumeroVersion, V.DateSortiePrevue, MAX(R.NumeroRelease) as Release
            from jo.Logiciel L 
            inner join jo.Version V on L.CodeLogiciel = V.CodeLogiciel
            inner join jo.Module M on L.CodeLogiciel = M.CodeLogiciel
            inner join jo.Release R on V.NumeroVersion = R.NumeroVersion and V.CodeLogiciel = R.CodeLogiciel
            group by L.CodeLogiciel, L.Nom, M.CodeModule, M.Libelle, V.NumeroVersion, V.DateSortiePrevue
            order by L.CodeLogiciel, L.Nom, M.CodeModule, M.Libelle, V.NumeroVersion, V.DateSortiePrevue";

            // On crée une connexion à partir de la chaîne de connexion
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête,
                // et en utilisant la connexion définies précédemment
                var command = new SqlCommand(queryString, connect);

                // On ouvre la connexion
                connect.Open();

                // On exécute la requête en récupérant son résultat 
                // dans un objet SqlDataRedader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On lit et on affiche les lignes de résultat en boucle
                    while (reader.Read())
                    {
                        GetLogicielFromDataReader(logic, reader);
                    }
                }
            }
            // Le fait d'avoir créé la connexion dans une instruction using
            // permet de la fermer automatiquement à la fin du bloc using
            return logic;
        }

        /// <summary>
        /// Remplissage des listes logiciel/module/version
        /// </summary>
        /// <param name="lstLogiciel"></param>
        /// <param name="reader"></param>
        private static void GetLogicielFromDataReader(List<Logiciel> lstLogiciel, SqlDataReader reader)
        {
            POCO.Logiciel log = null;

            // Test si la liste de logiciel est vide ou contient déjà le logiciel du reader
            if (lstLogiciel.Count == 0 || lstLogiciel.Last().CodeLogiciel != (string)reader["CodeLogiciel"])
            {
                log = new Logiciel();
                log.CodeLogiciel = (string)reader["CodeLogiciel"];
                log.Nom = (string)reader["Nom"];
                log.ListeModule = new List<Module>();
                log.ListeVersion = new List<POCO.Version>();

                // Ajout de l'objet logiciel dans la liste
                lstLogiciel.Add(log);
            }
            else
                log = lstLogiciel.Last();

            // Test si la liste de module du logiciel courant est vide ou contient déjà le module du reader
            if (log.ListeModule.Count == 0 || log.ListeModule.Last().CodeModule != (string)reader["CodeModule"])
            {
                var mod = new POCO.Module();
                mod.CodeModule = (string)reader["CodeModule"];
                mod.Libelle = (string)reader["Libelle"];
                log.ListeModule.Add(mod);
            }

            if (log.ListeVersion.Count == 0 || log.ListeVersion.Last().NumeroVersion != (float)reader["NumeroVersion"])
            {
                // Remplissage d'un objet Version
                var ver = new POCO.Version();
                ver.NumeroVersion = (float)reader["NumeroVersion"];
                ver.DateSortiePrevue = (DateTime)reader["DateSortiePrevue"];
                ver.NumeroRelease = (short)reader["Release"];
                // Ajout de l'objet version dans le logiciel
                log.ListeVersion.Add(ver);
            }

        }
    }
}
