using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ModuleStructure
{
    public partial class ModuleStructure : Form
    {
        public ModuleStructure()
        {
            InitializeComponent();
        }

        private void SearchFileBtn_Click(object sender, EventArgs e)
        {
            SearchFileFBDialog.ShowDialog();
            SelectedPathTxtBox.Text = SearchFileFBDialog.SelectedPath;
        }

        private void CreateStructureBtn_Click(object sender, EventArgs e)
        {
            int Tabnumber;
            string UserSelectedPath = SelectedPathTxtBox.Text;
            string[] tab_TextBoxLine = FolderStructureRichTxtB.Lines;
            int[] tab_TabPerLine = new int[tab_TextBoxLine.Length];
            string[] tab_Path = new string[tab_TextBoxLine.Length];
            string CompletePath = UserSelectedPath;
            string TempPath = "";
            string DefaultPath = SelectedPathTxtBox.Text;
            string DirectoryName;
            double ProgressBarValue;
            double ProgressBarMax;
            double DblPercentage;


            if (SelectedPathTxtBox.Text != "")
            {
                if (FolderStructureRichTxtB.Text != "")
                {
                    if (Directory.Exists(DefaultPath))
                    {
                        CreationProgressPrB.Maximum = tab_TextBoxLine.Length;
                        CreationProgressPrB.Minimum = 0;
                        CreationProgressPrB.Step = 1;
                        CreationProgressPrB.Value = 0;

                        for (int intX = 0; intX < tab_TextBoxLine.Length; intX++)
                        {
                            Tabnumber = 0;
                            DirectoryName = tab_TextBoxLine[intX];
                            bool IsLetter = false;


                            for (int intY = 0; intY < DirectoryName.Length; intY++)
                            {
                                if (DirectoryName[intY] == Convert.ToChar("\t") && IsLetter == false)
                                {
                                    Tabnumber++;
                                }
                                else
                                    IsLetter = true;
                            }

                            tab_TabPerLine[intX] = Tabnumber;

                            if (tab_TabPerLine[intX] == 0)
                            {
                                string DeleteTabulation = "";
                                TempPath = "";
                                bool NoNewLine = false;

                                for (int intA = 0; intA < DirectoryName.Length; intA++)
                                {
                                    if (DirectoryName[intA] != Convert.ToChar("\t"))
                                    {
                                        DeleteTabulation += DirectoryName[intA];
                                    }
                                }

                                CompletePath = DefaultPath;
                                CompletePath += "\\" + DeleteTabulation;
                                tab_Path[intX] = CompletePath;
                            }
                            else
                            {
                                for (int intZ = intX; intZ >= 0; intZ--)
                                {
                                    if ((tab_TabPerLine[intZ] < (tab_TabPerLine[intX])))
                                    {
                                        string DeleteTabulation = "";
                                        TempPath = "";
                                        bool NoNewLine = false;

                                        for (int intA = 0; intA < DirectoryName.Length; intA++)
                                        {
                                            if (DirectoryName[intA] != Convert.ToChar("\t"))
                                            {
                                                DeleteTabulation += DirectoryName[intA];
                                            }
                                        }
                                        TempPath = TempPath + "\\" + DeleteTabulation;

                                        CompletePath += TempPath;
                                        tab_Path[intX] = CompletePath;

                                        break;
                                    }
                                }
                            }

                            for (int intY = intX; intY >= 0; intY--)
                            {
                                if (tab_TabPerLine[intY] <= tab_TabPerLine[intX])
                                {
                                    if (tab_TabPerLine[intY] < (tab_TabPerLine[intX]))
                                    {
                                        string DeleteTabulation = "";
                                        TempPath = "";

                                        for (int intA = 0; intA < DirectoryName.Length; intA++)
                                        {
                                            if (DirectoryName[intA] != Convert.ToChar("\t"))
                                            {
                                                DeleteTabulation += DirectoryName[intA];
                                            }
                                        }

                                        TempPath = TempPath + "\\" + DeleteTabulation;

                                        tab_Path[intX] = tab_Path[intY] + "\\" + TempPath;

                                        break;
                                    }
                                }
                            }

                            System.IO.Directory.CreateDirectory(tab_Path[intX]);
                            if (CreationProgressPrB.Value < CreationProgressPrB.Maximum)
                                CreationProgressPrB.Value += CreationProgressPrB.Step;

                            else
                                CreationProgressPrB.Value = CreationProgressPrB.Maximum;


                            ProgressBarValue = CreationProgressPrB.Value;
                            ProgressBarMax = CreationProgressPrB.Maximum;
                            DblPercentage = Math.Round(Convert.ToDouble((ProgressBarValue * 100) / ProgressBarMax), 2);
                            ProgressOfProgressBarLbl.Text = Convert.ToString(DblPercentage) + " %";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dossier inexistant ! Vérifiez bien que votre dossier possède la bonne orthographe ou qu'il existe !");
                    }

                }
                else
                {
                    MessageBox.Show("Veuillez créer au moins un dossier !");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un chemin !");
            }
        }
    }
}
