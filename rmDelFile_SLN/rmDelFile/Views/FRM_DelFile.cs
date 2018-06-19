﻿using rmDelFile.Helpers;
using rmDelFile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rmDelFile
{
    public partial class FRM_DelFile : Form
    {
        List<string> format = new List<string>();
        List<string> type = new List<string>();
        public FRM_DelFile()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            /*  DirectoryInfo di = new DirectoryInfo(@"C:\\");
              DirectoryInfo[] dir = di.GetDirectories();

              foreach (DirectoryInfo dire in dir)
              {
                  comboBoxRep.Items.Add(dire.Name);
              }
              */

        }

        private void buttonSrep_Click(object sender, EventArgs e)
        {/*

            DirectoryInfo di = new DirectoryInfo(@"C:\"+comboBoxRep.Text+"");
            DirectoryInfo[] dir = di.GetDirectories();

            foreach (DirectoryInfo dire in dir)
            {
                comboBoxSrep.Items.Add(dire.Name);
            }

            buttonSrep.Visible = false;
            comboBoxSrep.Visible = true;
        }

        private void comboBoxRep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRep.Text == "")
            {
                buttonSrep.Visible = false;

            }
            else
            {
                buttonSrep.Visible = true;
            }

            comboBoxRep.Enabled = false;*/
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {


        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        public void CheckBoxformat(object sender, EventArgs e)
        {
            // Récupération des formats
            CheckBox cboxf = (CheckBox)sender;

            if (cboxf.Checked == true && !format.Contains(cboxf.Text.ToUpper()))
            {
                format.Add(cboxf.Text.ToUpper());

            }
            else if (cboxf.Checked == false && format.Contains(cboxf.Text.ToUpper()))
            {
                format.Remove(cboxf.Text.ToUpper());
            }
            else if (CBTousF.Checked == true)
            {
                format.Clear();

            }

            if (((CBbl.Checked == true) || (CBpod.Checked == true) || (CBfac.Checked == true) || (CBpd.Checked == true) ||
                (CBlit.Checked == true) || (CBTousT.Checked == true)) &&
                ((CBjpg.Checked == true) ||
                (CBtif.Checked == true) ||
                (CBtxt.Checked == true) ||
                (CBbmp.Checked == true) ||
                (CBpng.Checked == true) ||
                (CBpdf.Checked == true) || (CBTousF.Checked == true)) && (textBoxpath.Text != ""))
            {
                buttonstart.Enabled = true;
            }
            else
            {
                buttonstart.Enabled = false;
            }

        }

        public void CheckBoxType(object sender, EventArgs e)
        {
            CheckBox cboxt = (CheckBox)sender;

            if (cboxt.Checked == true && !type.Contains(cboxt.Text.ToUpper()))
            {
                type.Add(cboxt.Text.ToUpper());

            }
            else if (cboxt.Checked == false && type.Contains(cboxt.Text.ToUpper()))
            {
                type.Remove(cboxt.Text.ToUpper());
            }
            else if (CBTousT.Checked == true)
            {
                type.Clear();

            }

            if (((CBbl.Checked == true) || (CBpod.Checked == true) || (CBfac.Checked == true) || (CBpd.Checked == true) ||
                (CBlit.Checked == true) || (CBTousT.Checked == true)) &&
                ((CBjpg.Checked == true) ||
                (CBtif.Checked == true) ||
                (CBtxt.Checked == true) ||
                (CBbmp.Checked == true) ||
                (CBpng.Checked == true) ||
                (CBpdf.Checked == true) || (CBTousF.Checked == true)) && (textBoxpath.Text != ""))
            {
                buttonstart.Enabled = true;
            }
            else
            {
                buttonstart.Enabled = false;
            }

        }

        public void CBSrep_CheckedChange(object sender, EventArgs e)
        {


        }
        /// <summary>
        /// Chemin du répertoire
        /// </summary>
        private void buttonpath_Click(object sender, EventArgs e)
        {
            // Récupere le chemin est le met dans le textbox.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxpath.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        /// <summary>
        /// Ajuste la taille du textbox
        /// </summary>
        private void textBoxpath_TextChanged(object sender, EventArgs e)
        {
            // Mesure la taille du texte est ajuste la taille du textbox en fonction.
            Size size = TextRenderer.MeasureText(textBoxpath.Text, textBoxpath.Font);
            textBoxpath.Width = size.Width;
            textBoxpath.Height = size.Height;
            if (textBoxpath.Text != "")
            {
                CBSrep.Visible = true;

            }

            if (((CBbl.Checked == true) || (CBpod.Checked == true) || (CBfac.Checked == true) || (CBpd.Checked == true) ||
                (CBlit.Checked == true) || (CBTousT.Checked == true)) &&
                ((CBjpg.Checked == true) ||
                (CBtif.Checked == true) ||
                (CBtxt.Checked == true) ||
                (CBbmp.Checked == true) ||
                (CBpng.Checked == true) ||
                (CBpdf.Checked == true) || (CBTousF.Checked == true)) && (textBoxpath.Text != ""))
            {
                buttonstart.Enabled = true;
            }
            else
            {
                buttonstart.Enabled = false;
            }

        }

        private void Buttonstartacces(Object sender, EventArgs e)
        {
            if (((CBbl.Checked == true) || (CBpod.Checked == true) || (CBfac.Checked == true) || (CBpd.Checked == true) ||
                (CBlit.Checked == true) || (CBTousT.Checked == true)) &&
                ((CBjpg.Checked == true) ||
                (CBtif.Checked == true) ||
                (CBtxt.Checked == true) ||
                (CBbmp.Checked == true) ||
                (CBpng.Checked == true) ||
                (CBpdf.Checked == true) || (CBTousF.Checked == true)) && (textBoxpath.Text != ""))
            {
                buttonstart.Enabled = true;
            }
            else
            {
                buttonstart.Enabled = false;
            }


            if (CBTousT.Checked == true)
            {
                CBbl.Enabled = false;
                CBpod.Enabled = false;
                CBfac.Enabled = false;
                CBpd.Enabled = false;
                CBlit.Enabled = false;


                CBbl.Checked = false;
                CBpod.Checked = false;
                CBfac.Checked = false;
                CBpd.Checked = false;
                CBlit.Checked = false;
            }
            else
            {
                CBbl.Enabled = true;
                CBpod.Enabled = true;
                CBfac.Enabled = true;
                CBpd.Enabled = true;
                CBlit.Enabled = true;

            }

            if (CBTousF.Checked == true)
            {
                CBjpg.Enabled = false;
                CBtif.Enabled = false;
                CBtxt.Enabled = false;
                CBbmp.Enabled = false;
                CBpng.Enabled = false;
                CBpdf.Enabled = false;

                CBjpg.Checked = false;
                CBtif.Checked = false;
                CBtxt.Checked = false;
                CBbmp.Checked = false;
                CBpng.Checked = false;
                CBpdf.Checked = false;

            }
            else
            {
                CBjpg.Enabled = true;
                CBtif.Enabled = true;
                CBtxt.Enabled = true;
                CBbmp.Enabled = true;
                CBpng.Enabled = true;
                CBpdf.Enabled = true;

            }
        }
        
        /// <summary>
        /// Traitement principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonstart_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Maximum = 100;
            progressBar.Minimum = 0;
            progressBar.Step = 1;
            progressBar.PerformStep();
            DateTime DateSuppr;
            decimal jours;

            List<FileInfo> LTypeFile = new List<FileInfo>();
            List<FileInfo> LAllFile = new List<FileInfo>();
            List<FileInfo> LFormat = new List<FileInfo>();
            Dictionary<string, string> FinalList = new Dictionary<string, string>();
            List<string> listeDelFile = new List<string>();
            DirectoryInfo Di = new DirectoryInfo(@"" + textBoxpath.Text + "");
            FileInfo[] fic;
            progressBar.PerformStep();
            if (CBSrep.Checked == true)
            {
                fic = Di.GetFiles("*", SearchOption.AllDirectories);
            }
            else
            {
                fic = Di.GetFiles("*", SearchOption.TopDirectoryOnly);
            }
            Console.WriteLine("FORMAT :");

            foreach (string f in format)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("TYPE :");
            foreach (string f in type)
            {

                Console.WriteLine(f);
            }
            progressBar.PerformStep();
            jours = numericUpDown2.Value;
            Console.WriteLine(jours);
            DateSuppr = DateTime.Now.AddDays(-Convert.ToDouble(jours));
            Console.WriteLine("DateSUPPR : ");
            Console.WriteLine(DateSuppr);

            // Récupère la liste des fichiers correspondant à la date de suppression.
            progressBar.PerformStep();
            if (RBcreation.Checked)
                LAllFile = fic.Where(a => DateSuppr > a.CreationTime).ToList();
            else
                LAllFile = fic.Where(a => DateSuppr > a.LastWriteTime).ToList();
            Console.WriteLine("FICIERDATELISTES");
            foreach (FileInfo fi in LAllFile)
            {
                progressBar.PerformStep();

                Console.WriteLine(fi.CreationTime);
            }
            progressBar.PerformStep();

            // Récupère la liste des fichiers correspondant aux types.
            if (CBTousT.Checked == true)
            {
                LTypeFile = LAllFile;

            }
            else
            {
                foreach (string i in type)
                {
                    progressBar.PerformStep();
                    Console.WriteLine(i);
                    LTypeFile.AddRange(LAllFile.Where(a => a.Name.ToUpper().StartsWith(i)));
                }
            }

            // Récupère la liste des fichiers correspondant aux formats.
            progressBar.PerformStep();
            if (CBTousF.Checked == true)
            {
                LFormat = LTypeFile;

            }
            else
            {
                LFormat = LTypeFile.Where(a => format.Contains(a.Extension.ToUpper())).ToList();
            }
            foreach (FileInfo i in LFormat)
            {
                Console.WriteLine(i.Name);
            }

            //for (int i = 0; i < type.Count; i++)

            Console.WriteLine("FICHASUPPR:");
            foreach (FileInfo i in LFormat)
            {
                progressBar.PerformStep();
                Console.WriteLine(i);
                listeDelFile.Add(i.FullName);
            }
            progressBar.PerformStep();


            int NBDelFile = LFormat.Count;
            FinalList = Helpers.Helpers.GetDelete(LFormat);

            // Liste de nom.
            List<string> NameList = new List<string>(FinalList.Keys);
        
            // Liste d'exception.
            List<string> ExceptList = new List<string>(FinalList.Values);


            Helpers.Helpers.GetLogsErreurs(NameList, ExceptList);
            Helpers.Helpers.GetLogs(listeDelFile, NameList);
            if (LFormat.Count == 0)
            {
                MessageBox.Show("Aucun fichier n'a été supprimé, vérifier les options.");
            }
            else
            {
                if (FinalList.Count == 0)
                {
                    MessageBox.Show(listeDelFile.Count + " fichier(s) supprimé(s)");
                }
                else
                {
                    int NBFile = NBDelFile - FinalList.Count;
                    MessageBox.Show(NBFile + " fichier(s) sur " + NBDelFile + " supprimé(s). Veuillez consultez les logs erreurs " +
                        "afin de vous renseignez sur le(s) fichier(s) non supprimé(s)");
                }
            }
            if (progressBar.Value < 100)
            {
                progressBar.Value = 100;

            }


            //string OuiOuNon = "";
            //bool toto = false;
            //OuiOuNon = toto == true ? "Oui" : "Non";
            //Fin a supp
            /*foreach (FileInfo fichier in listeFicATraiter)
            {

                if (CBbl.Checked == true)
                {
                    searchP = "BL";
                    Filist.AddRange(Methode.GetList(fichier, searchP));
                }

                if (CBpod.Checked == true)
                {
                    searchP = "POD";
                    Filist.AddRange(Methode.GetList(fichier, searchP));

                }

                if (CBfac.Checked == true)
                {
                    searchP = "FAC";
                    Filist.AddRange(Methode.GetList(fichier, searchP));

                }

                if (CBpd.Checked == true)
                {
                    searchP = "PD";
                    Filist.AddRange(Methode.GetList(fichier, searchP));

                }

                if (CBlit.Checked == true)
                {
                    searchP = "LIT";
                    Filist.AddRange(Methode.GetList(fichier, searchP));

                }

                if (CBTousT.Checked == true)
                {
                    searchP = "*";
                    Filist = listeFicATraiter;

                }

            }*/


        }



        private void comboBoxtest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void progressBar_Click(object sender, EventArgs e)
        {

        }


    }
}
