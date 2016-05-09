using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace _042_campichele_ManipulationNomFichier
{
    public partial class fileManipulationForm : Form
    {
        public fileManipulationForm()
        {
            InitializeComponent();
        }

        //Count the number of handpicked file
        int NbOfFileSelected = 0;

        //store results for a output (txt file)
        string[] resultOutputTab;

        //Write the results in a .txt file
        string outputPath = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\Output.log";

        private void modifyFile(string strToChange) 
        {
            //counter
            int addCounter = 0;
            //travels the ListBox
            for (int i = 0; i < choosenFileListBox.Items.Count; i++)
            {

                //take the actual Item for modification
                string actualFile = choosenFileListBox.Items[i].ToString();
                //MessageBox.Show(actualFile); //for testing

                //split the name + path of the Item every "\" and store all part in the "tokens" table
                string[] tokens = actualFile.Split('\\');
                //Get the NAME of the file (the last "token" of the table is obviously the name of the file (without the path))
                string actualFileAfterSplit = tokens[tokens.Length - 1];

                string extension;
                string resultWithoutExt;
                if (extCheckBox.Checked == false)
                {
                    extension = System.IO.Path.GetExtension(actualFileAfterSplit);
                    resultWithoutExt = actualFileAfterSplit.Substring(0, actualFileAfterSplit.Length - extension.Length);
                }
                else
                {
                    extension = "";
                    resultWithoutExt = actualFileAfterSplit;
                }


                string result = "";
                if (typeTabControl.SelectedIndex == 0)
                {
                    //replace the matched part of the string
                    result = resultWithoutExt.Replace(strToChange, newTextReplaceTextBox.Text);
                }
                else if (typeTabControl.SelectedIndex == 1)
                {
                    //delet the matched part of the string
                    result = resultWithoutExt.Replace(strToChange, "");
                }
                else if (typeTabControl.SelectedIndex == 2)
                {


                    int position;
                    if (Convert.ToInt32(locationTextBox.Text) > resultWithoutExt.Length)
                    {
                        position = resultWithoutExt.Length;
                    }
                    else
                    {
                        position = Convert.ToInt32(locationTextBox.Text);
                    }

                    //delet the add part to the string
                    if (counterCheckBox.Checked == true)
                    {
                        //result = addCounter + strToChange + actualFileAfterSplit; old
                        result = resultWithoutExt.Insert(position, addCounter + strToChange);
                        addCounter++;
                    }
                    else
                    {
                        //result = strToChange + actualFileAfterSplit; old
                        result = resultWithoutExt.Insert(position, strToChange);
                    }
                }

                //unsplit the name with the extension
                result = result + extension;

                //MessageBox.Show(result);
                //unsplit the full name with "tokens"
                string finalToken = "";
                for (int y = 0; y < tokens.Length - 1; y++)
                {
                    finalToken = finalToken + tokens[y] + "\\";
                }
                finalToken = finalToken + result;

                //Try catch for exeptions
                try
                {
                    //Rename the file
                    System.IO.File.Move(actualFile, finalToken);

                    //Refresh the result label
                    resultLabel.Text = resultLabel.Text + "\r\n" + actualFileAfterSplit + " Edited to : " + result;
                    //Replace the old item with the new one in the listBox
                    choosenFileListBox.Items[i] = finalToken;
                    

                }
                catch (Exception e)
                {
                    string msg = e.ToString();
                    if (msg.Contains("UnauthorizedAccessException"))
                    {
                        var failOpenOutput = MessageBox.Show("L'exception \"UnauthorizedAccessException\" est survenue et peut vouloir dire 4 choses:\n -L'appelant n'a pas l'autorisation requise.\n -Le fichier est un fichier exécutable qui est en cours d'utilisation.\n -Le fichier est un répertoire. \n -Le fichier spécifié est en lecture seule.\n Arrêt des modifications depuis l'erreur.\nOuvrir le fichier des résultats?", "Echec", MessageBoxButtons.YesNo);
                        if (failOpenOutput == DialogResult.Yes)
                        {
                            Process.Start("notepad.exe", outputPath);
                        }
                        //Refresh the result label
                        resultLabel.Text = resultLabel.Text + "\r\n" + actualFileAfterSplit + " Failed to change, stop program";
                        //store results output by lines
                        resultOutputTab = resultLabel.Lines;
                        return;
                    }
                    else
                    {
                        var failOpenOutput = MessageBox.Show("Erreur: une exception est survenue. Arrêt des modifications depuis l'erreur.\nOuvrir le fichier des résultats?", "Echec", MessageBoxButtons.YesNo);
                        if (failOpenOutput == DialogResult.Yes)
                        {
                            Process.Start("notepad.exe", outputPath);
                        }
                        //Refresh the result label
                        resultLabel.Text = resultLabel.Text + "\r\n" + actualFileAfterSplit + " Failed to change, stop program ";
                        //store results output by lines
                        resultOutputTab = resultLabel.Lines;
                        return;
                    }
                }
            }
            //store results output by lines
            resultOutputTab = resultLabel.Lines;
            var SuccesOpenOutput = MessageBox.Show("Tous les fichiers ont été modifiés avec succès.\nOuvrir le fichier des résultats?", "Succès", MessageBoxButtons.YesNo);
            // If the yes button was pressed ...
            if (SuccesOpenOutput == DialogResult.Yes)
            {
                Process.Start("notepad.exe", outputPath);
            }

        }

        /// <summary>
        /// Manage the Drag & drop with checks
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void fileManipulationForm_DragDrop(object sender, DragEventArgs e)
        {
            //Take dropped tiems and store in array
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            //loop thru droppes items and display them
            foreach (string file in droppedFiles)
            {
                string filename = System.IO.Path.GetFullPath(file);

                //Course all the elements and check if the element is already selected
                bool itemAlreadyAdded = false;
                foreach (string item in choosenFileListBox.Items)
                {
                    if (item == filename)
                    {
                        itemAlreadyAdded = true;
                        break;
                    }
                }
                if (itemAlreadyAdded)
                {
                    //Display error message if the element is already selected
                    MessageBox.Show("Le fichier " + filename + " est déjà sélectionné ");
                }
                else
                {
                    // get the file attributes for file or directory
                    FileAttributes attr = File.GetAttributes(filename);
                    if (attr.HasFlag(FileAttributes.Directory))
                        MessageBox.Show(filename + " est un dossier, séléctionnez uniquement des fichiers");
                    else
                    {
                        //Add the element to the ListBox
                        choosenFileListBox.Items.Add(filename);
                        NbOfFileSelected++;
                        choosenFilesGroupBox.Text = NbOfFileSelected + " fichier(s) choisi(s)";
                    }
                }

            }
        }

        /// <summary>
        /// Duno what this is supposed to do
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void fileManipulationForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        /// <summary>
        /// Button for select files 
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            //open the windows for select files
            OpenFileDialog GetFile = new OpenFileDialog();
            GetFile.Filter = "All files (*.*)|*.*";
            GetFile.InitialDirectory = @"C:\";
            GetFile.Title = "Sélectionner un fichier";
            if (GetFile.ShowDialog() == DialogResult.OK)
            {
                    //Course all the elements and check if the element is already selected
                    bool itemAlreadyAdded = false;
                    foreach (string item in choosenFileListBox.Items)
                    {
                        if (item == GetFile.FileName)
                        {
                            itemAlreadyAdded = true;
                            break;
                        }
                    }
                    if (itemAlreadyAdded)
                    {
                        //Display error message if the element is already selected
                        MessageBox.Show("Un fichier du même nom est déjà sélectionné ");
                    }
                    else
                    {
                        //Add the element to the ListBox
                        choosenFileListBox.Items.Add(GetFile.FileName);
                        NbOfFileSelected++;
                        choosenFilesGroupBox.Text = NbOfFileSelected + " fichier(s) choisi(s)";
                    }
            }
        }

        /// <summary>
        /// Button for clear the selected files
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void clearListButton_Click(object sender, EventArgs e)
        {
            choosenFileListBox.Items.Clear();
            choosenFileListBox.ResetText();
            NbOfFileSelected = 0;
            choosenFilesGroupBox.Text = NbOfFileSelected + " fichier(s) choisi(s)";
        }

        /// <summary>
        /// Button for modify 
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void changeTextButton_Click(object sender, EventArgs e)
        {
            //check if 1 or more file are selected
            if (choosenFileListBox.Items.Count != 0)
            {

                //reset the result label every click on the button
                resultLabel.Text = "";

                    //check what tabs is selected
                    if (typeTabControl.SelectedIndex == 0)
                    {
                        if (searchReplaceTextBox.Text != "")
                        {
                            //call modifyFile() function
                            modifyFile(searchReplaceTextBox.Text);
                        }
                        else
                        {
                            MessageBox.Show("Aucune chaine à remplacer");
                        }
                    }
                    else if (typeTabControl.SelectedIndex == 1)
                    {
                        if (searchDeletTextBox.Text != "")
                        {
                            //call modifyFile() function
                            modifyFile(searchDeletTextBox.Text); 
                        }
                        else
                        {
                            MessageBox.Show("Aucune chaine à supprimer");
                        }
                    }
                    else if (typeTabControl.SelectedIndex == 2)
                    {
                        //call modifyFile() function
                        modifyFile(addTextBox.Text);
                    }

                    FileStream fch;
                    FileStream Fch;
                    StreamWriter wr;
                    StreamReader rd;

                if (!File.Exists(outputPath))
                   {
                       fch = new FileStream(outputPath, FileMode.Create);
                       wr = new StreamWriter(fch);
                       wr.WriteLine("This is the historic output file");
                       wr.WriteLine("**************************************************************************************************************************\r\n");
                       //Close the file
                       wr.Close();
                       fch.Close();
                   }
                if (File.Exists(outputPath))
                   {

                       Fch = new FileStream(outputPath, FileMode.Open);
                       wr = new StreamWriter(Fch);
                       rd = new StreamReader(Fch);
                       string ligne = rd.ReadLine();

                       do
                       {
                           ligne = rd.ReadLine();
                       }
                       while (ligne != null);

                       //Write text
                       wr.WriteLine("[ " + DateTime.Now.ToString() + " ] : ");
                       foreach (string item in resultOutputTab)
                       {
                           wr.WriteLine(item);
                       }
                       wr.WriteLine("\r\n**************************************************************************************************************************\r\n");
                       //Close the file
                       wr.Close();
                       rd.Close();
                       Fch.Close();
                   }
                
            }
            else
            {
                //message if no file are selected
                MessageBox.Show("Veuillez sélectionner au moins un fichier");
            }
            
        }

        private void DisclamerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attention: le module de manipulation de nom de fichier à la possibilité de modifier les extensions de fichier, même si tout est récupérable en renomment l'extension modifiée je ne suis pas résponsable des problèmes suivants:\n\n -Erreur de manipulation du programme\n -Problèmes avec d'autres logiciels utilisant un fichier renommé avec ce module\nMerci de votre compréhension, le dev.");
        }

        private void fileManipulationForm_Load(object sender, EventArgs e)
        {

        }

        private void tipsLabel_Click(object sender, EventArgs e)
        {

        }

        private void locationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(locationTextBox.Text, "^[0-9]+$")) { locationTextBox.Text = "0"; };
        }

        private void extCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (extCheckBox.Checked == true)
            {
                MessageBox.Show("Attention: renommer les extensions ne revient pas a convertir le fichier, pour ça, utilisez un convertisseur de fichier!","Important Note",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
