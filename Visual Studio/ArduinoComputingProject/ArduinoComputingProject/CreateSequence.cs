using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArduinoComputingProject
{
    public partial class CreateEditSequenceForm : Form
    {
        public CreateEditSequenceForm()
        {
            InitializeComponent();
        }

        private void CreateSequenceForm_Load(object sender, EventArgs e)
        {
            refreshListboxes();
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            if (lstSequenceFiles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Make sure you have selected a file from the listbox", "File Not Selected");
            }
            else
            {

                string path = Environment.CurrentDirectory;
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\")) + @"\" + lstSequenceFiles.SelectedItem.ToString();
                string[] lines = System.IO.File.ReadAllLines(@newPath);

                txtSequence.Text = ""; //empty the textbox and load the new file
                foreach (string line in lines)
                {
                    txtSequence.AppendText(line + "\r\n");
                }
            }
            
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (txtSequence.Text != "")
            {
                InputBox inputBox = new InputBox("Enter a name for the new file");
                do
                {
                    inputBox.ShowDialog();
                } while (inputBox.input == "" & inputBox.shouldClose == false);

                if (inputBox.input != "")
                {
                    string path = Environment.CurrentDirectory;
                    string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\")) + @"\" + inputBox.input + ".seq";
                    System.IO.File.WriteAllText(@newPath, txtSequence.Text);
                    refreshListboxes();
                }
            }
            else 
            {
                MessageBox.Show("Make sure you have written a sequence in the space provided!", "Empty Textbox");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSequence.Text = "";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDeleteSequenceFile.SelectedItems.Count > 0)
            {
                string path = Environment.CurrentDirectory;
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\")) + @"\" + lstDeleteSequenceFile.SelectedItem.ToString();
                File.Delete(newPath);
                refreshListboxes();
            }
            else 
            {
                MessageBox.Show("Make sure you have selected a file from the listbox", "File Not Selected");
            }
            
        }

        private void refreshListboxes()
        {
            
            string path = Environment.CurrentDirectory;
            string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\"));
            string[] files = System.IO.Directory.GetFiles(newPath, "*.seq");

            lstDeleteSequenceFile.Items.Clear();
            lstSequenceFiles.Items.Clear();
            foreach (string file in files)
            {
                lstDeleteSequenceFile.Items.Add(System.IO.Path.GetFileName(file));
                lstSequenceFiles.Items.Add(System.IO.Path.GetFileName(file));
            }
        }

        private void btnOverwriteFile_Click(object sender, EventArgs e)
        {

            if (lstSequenceFiles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Make sure you have selected a file from the listbox", "File Not Selected");
            }
            else
            {

                string path = Environment.CurrentDirectory;
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\")) + @"\" + lstSequenceFiles.SelectedItem.ToString();
                System.IO.File.WriteAllText(@newPath, txtSequence.Text);
            }
        }

        private void CreateEditSequenceForm_Activated(object sender, EventArgs e)
        {
            refreshListboxes();
        }

        private void CreateEditSequenceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Select();
        }

        
    }
}
