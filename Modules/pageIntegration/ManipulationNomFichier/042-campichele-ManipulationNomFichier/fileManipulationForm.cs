using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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

        private void modifyFile() { }

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
                //Remplacement
                if (typeTabControl.SelectedIndex == 0) 
                {

                    string strToChange = searchReplaceTextBox.Text;

                    //travels the ListBox
                    for (int i = 0; i < choosenFileListBox.Items.Count; i++)
                    {
                        //take the actual Item for modification
                        string actualFile = choosenFileListBox.Items[i].ToString();

                        //split the name + path of the Item every "\" and store all part in the "tokens" table
                        string[] tokens = actualFile.Split('\\');
                        //Get the NAME of the file (the last "token" of the table is obviously the name of the file (without the path))
                        string actualFileAfterSplit = tokens[tokens.Length - 1];

                        //replace the matched part of the string
                        string result = actualFileAfterSplit.Replace(strToChange, newTextReplaceTextBox.Text);

                        //unsplit the full name with "tokens"
                        string finalToken = "";
                        for (int y = 0; y < tokens.Length - 1; y++)
                        {
                            finalToken = finalToken + tokens[y] + "\\";
                        }
                        finalToken = finalToken + result;

                        //Rename the file
                        System.IO.File.Move(actualFile, finalToken);

                        //refresh the result label
                        resultLabel.Text = resultLabel.Text + "\n" + actualFileAfterSplit + " Edited to : " + result;

                        //Replace the old item with the new one in the listBox
                        choosenFileListBox.Items[i] = finalToken;
                    }
                }

                //Suppression
                if (typeTabControl.SelectedIndex == 1)
                {

                    string strToDelet = searchDeletTextBox.Text;

                    //travels the ListBox
                    for (int i = 0; i < choosenFileListBox.Items.Count; i++)
                    {
                        //take the actual Item for modification
                        string actualFile = choosenFileListBox.Items[i].ToString();

                        //split the name + path of the Item every "\" and store all part in the "tokens" table
                        string[] tokens = actualFile.Split('\\');
                        //Get the NAME of the file (the last "token" of the table is obviously the name of the file (without the path))
                        string actualFileAfterSplit = tokens[tokens.Length - 1];

                        //delet the matched part of the string
                        string result = actualFileAfterSplit.Replace(strToDelet, "");

                        //unsplit the full name with "tokens"
                        string finalToken = "";
                        for (int y = 0; y < tokens.Length -1; y++)
                        {
                            finalToken = finalToken + tokens[y] + "\\";
                        }
                        finalToken = finalToken + result;

                        //Rename the file
                        System.IO.File.Move(actualFile, finalToken);

                        //refresh the result label
                        resultLabel.Text = resultLabel.Text + "\n" + actualFileAfterSplit + " Edited to : " + result;

                        //Replace the old item with the new one in the listBox
                        choosenFileListBox.Items[i] = finalToken;
                    }
                }

                //Ajout
                if (typeTabControl.SelectedIndex == 2)
                {

                    string strToChange = searchReplaceTextBox.Text;
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

                        //delet the add part to the string
                        string result;
                        if (counterCheckBox.Checked == true)
                        {
                            result = addCounter + addTextBox.Text + actualFileAfterSplit;
                            addCounter++;
                        }
                        else 
                        {
                            result = addTextBox.Text + actualFileAfterSplit;
                        } 

                        //MessageBox.Show(result);
                        //unsplit the full name with "tokens"
                        string finalToken = "";
                        for (int y = 0; y < tokens.Length - 1; y++)
                        {
                            finalToken = finalToken + tokens[y] + "\\";
                        }
                        finalToken = finalToken + result;

                        //Rename the file
                        System.IO.File.Move(actualFile, finalToken);

                        //Refresh the result label
                        resultLabel.Text = resultLabel.Text + "\n" + actualFileAfterSplit + " Edited to : " + result;

                        //Replace the old item with the new one in the listBox
                        choosenFileListBox.Items[i] = finalToken;
                        }
                    }
            }
            else
            {
                //message if no file are selected
                MessageBox.Show("Veuillez sélectionner au moins un fichier");
            }
            
        }
    }
}
