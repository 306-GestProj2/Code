using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuleStructure
{
    public partial class ModuleStructureDossier : Form
    {
        public ModuleStructureDossier()
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

            for (int intX = 0; intX < tab_TextBoxLine.Length; intX++)
            {
                Tabnumber = 0;
                DirectoryName = tab_TextBoxLine[intX];

                for (int intY = 0; intY < DirectoryName.Length; intY++)
                {
                    if (DirectoryName[intY] == Convert.ToChar("\t"))
                    {
                        Tabnumber++;
                    }
                }

                tab_TabPerLine[intX] = Tabnumber;

                if (tab_TabPerLine[intX] == 0)
                {
                    CompletePath = DefaultPath;
                    CompletePath += "\\" + DirectoryName;
                    tab_Path[intX] = CompletePath;
                    //System.IO.Directory.CreateDirectory(CompletePath + "\\" + DirectoryName);
                }
                else
                {                   
                    for (int intZ = intX; intZ >= 0; intZ--)
                    {
                        if ((tab_TabPerLine[intZ] < (tab_TabPerLine[intX])))
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

                            CompletePath += TempPath;
                            tab_Path[intX] = CompletePath;

                            break;
                            //MessageBox.Show(CompletePath + "\\" + TextBoxLine[intZ] + "\\" + DirectoryName[intX]);
                        }
                        /*else
                        {
                            CompletePath += "\\" + TempPath;
                            //System.IO.Directory.CreateDirectory(CompletePath);
                            //break;
                        }*/
                    }
                }

                
                //MessageBox.Show(DirectoryName + "\n Nombre de tabulation : " + "");
                //MessageBox.Show(CompletePath);
                //System.IO.Directory.CreateDirectory(CompletePath);
            }

            for (int intX = 0; intX < tab_TextBoxLine.Length; intX++)
            {
                DirectoryName = tab_TextBoxLine[intX];

                for (int intY = intX; intY >= 0; intY--)
                {
                    if (tab_TabPerLine[intY] <= tab_TabPerLine[intX])
                    {
                        if (tab_TabPerLine[intY] == (tab_TabPerLine[intX] - 1))
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
            }

            for (int intX = 0; intX < tab_TextBoxLine.Length; intX++)
            {
                //MessageBox.Show(tab_Path[intX]);
                System.IO.Directory.CreateDirectory(tab_Path[intX]);
            }
        }
    }
}
