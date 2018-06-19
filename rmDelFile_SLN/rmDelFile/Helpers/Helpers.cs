using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmDelFile.Helpers
{
    public static class Helpers
    {
        /// <summary>
        /// Avancement de la barre de progression par rapport aux fichiers supprimer.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="LApSuppr"></param>
        /// <returns></returns>
        public static bool GetProgressBar(string name, List<string> LApSuppr)
        {
            bool rep = true;
            if (!LApSuppr.Contains(name))
            {
                rep = true;

            }
            return rep;
            
            
        }

        /// <summary>
        /// Suppression des fichiers.
        /// </summary>
        /// <param name="FlistF"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetDelete(List<FileInfo> FlistF)
        {
            //List<string> lin = new List<string>();
            Dictionary<string, string> ExcepFile = new Dictionary<string, string>();
            foreach (FileInfo files in FlistF)
            {
                try
                {
                    files.Delete();
                    
                }
                catch (Exception ex)
                {
                    //string Erreur = "Erreur sur le fichier : "+files.FullName+" : "+ ex.Message;
                    ExcepFile.Add(files.FullName, ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }
            return ExcepFile;
        }

        /// <summary>
        /// Inscription des logs erreurs.
        /// </summary>
        /// <param name="lin"></param>
        public static void GetLogsErreurs(List<string> NameList, List<string> ExceptList)
        {
            List<string> FinalLine = new List<string>();
            string lines = "";

            for (int i = 0; i == NameList.Count - 1; i++)
            {
                string ligne = DateTime.Now + " : Erreur sur le fichier : " + NameList[i] + " : " + ExceptList[i];
                FinalLine.Add(ligne);
            }

            foreach (string ligne in FinalLine)
            {
                lines = String.Join(" ", ligne);

                // Remplace dd/MM/yyyy en dd_MM_yyyy
                string DateToday = DateTime.Now.ToString("yyyy_MM_dd");

                // Nom du fichier logs erreur du jour.
                string PathFile = @"F:\logs\logserreurs\" + "logsErreurs_" + DateToday + ".txt";
                using (StreamWriter file = new StreamWriter(PathFile, true))
                {
                    try
                    {
                        file.WriteLine(lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Suppression de chaque fichier et inscription d'une trace de chaque fichier supprimer dans les logs du jour.
        /// </summary>
        /// <param name="FlistF"></param>
        /// <returns></returns>
        public static void GetLogs(List<string> DelFile, List<string> NameList)
        {
            List<string> lin = new List<string>();
            List<string> line = new List<string>();

            foreach (string nomFichier in NameList)
            {
                //DelFile.RemoveAll(element => element.Contains(nomFichier));
                if (DelFile.Contains(nomFichier))
                {
                    DelFile.Remove(nomFichier);
                }
            }

            string lines = "";

            foreach (string files in DelFile)
            {
                // Ligne écrite dans les logs pour chaque fichier supprimé.

                string logEnCours = DateTime.Now + " : " + files + " a été supprimé.";
                lin.Add(logEnCours);

            }
            foreach (string ligne in lin)
            {
                lines = String.Join(" ", ligne);

                // Remplace dd/MM/yyyy en dd_MM_yyyy
                string DateToday = DateTime.Now.ToString("yyyy_MM_dd");

                // Nom du fichier logs du jour.
                string PathFile = @"F:\logs\" + "logs_" + DateToday + ".txt";
                using (StreamWriter file = new StreamWriter(PathFile, true))
                {
                    try
                    {
                        file.WriteLine(lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;

                    }
                }
            }
        }
    }
}
