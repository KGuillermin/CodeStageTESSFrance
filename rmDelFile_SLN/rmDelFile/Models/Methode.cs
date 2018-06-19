using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace rmDelFile.Models
{
    public static class Methode
    {
        /// <summary>
        /// Liste tous les fichiers du/des types sélectionnés.
        /// </summary>
        /// <param name="searchP"></param>
        /// <param name="optionrep"></param>
        /// <param name="fi"></param>
        /// <returns></returns>
        /*public static List<FileInfo> GetList(FileInfo fichier, string searchP)
        {
            List<FileInfo> Flist = new List<FileInfo>();
            //fichier.Name.StartsWith(searchP);
            Regex myRegex = new Regex(@"^(" + searchP + ")");
            string fic = Convert.ToString(fichier);

            if (myRegex.IsMatch(fic.ToUpper()))
            {
                Flist.Add(fichier);
            }

            return Flist;
        }*/

        /// <summary>
        /// Suppression du fichier.
        /// </summary>
        /// <param name="Datefic"></param>
        /// <param name="dateSuppr"></param>
        /// <param name="format"></param>
        /// <param name="fileExt"></param>
        /// <param name="fichier"></param>
        /// <returns></returns>
        /*public static List<FileInfo> GetListDate(DateTime Datefic,DateTime dateSuppr,FileInfo fichier)
        {
            List<FileInfo> ListDelFile = new List<FileInfo>();
            // Compare la date de création ou de modification et le délai de suppression.
            int result = DateTime.Compare(Datefic, dateSuppr);

            if (result < 0 )
            {
                ListDelFile.Add(fichier);
                
            }
            return ListDelFile;
        }*/

        /// <summary>
        /// Liste tous les fichiers du/des formats sélectionnés à partir de la liste Flist.
        /// </summary>
        /// <param name="ExtFormat"></param>
        /// <param name="fileExt"></param>
        /// <param name="fichier"></param>
        /// <param name="Filist"></param>
        /// <returns></returns>
        /*public static List<FileInfo> GetListFormat(string ExtFormat, string fileExt, FileInfo fichier)
        {
            List<FileInfo> FlistF = new List<FileInfo>();
            
            if (ExtFormat == fileExt.ToUpper())
            {
                FlistF.Add(fichier);
                
            }
            return FlistF;
        }*/
    }

}
