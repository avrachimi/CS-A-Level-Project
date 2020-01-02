using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace ArduinoComputingProject
{
    public partial class BoardSetupForm : Form
    {
        private MainForm mainForm = new MainForm();

        //dictionaries to see if layer/port is already selected. I used this to minimise the amount of if-statements as it would need a lot
        Dictionary<string, bool> isLayerSelectedDict = new Dictionary<string, bool>(); 
        Dictionary<string, bool> isPortSelectedDict = new Dictionary<string, bool>();

        public BoardSetupForm()
        {
            InitializeComponent();
        }

       
        //reset port dictionary and comboboxes
        void resetPortCombos()
        {
            string[] ports = SerialPort.GetPortNames(); //get all ports available

            isPortSelectedDict.Clear(); //in case i call this method again and there are existing values in the dictionary
            isPortSelectedDict.Add("COM0", false); //always enter COM0 since it is not an actual port and is used as an 'empty' selection. it doesn't matter if the value is set to true or false.

            //clear all comboboxes to enter new values
            comboBoard1Port.Items.Clear();
            comboBoard2Port.Items.Clear();
            comboBoard3Port.Items.Clear();
            comboBoard4Port.Items.Clear();
            comboBoard5Port.Items.Clear();

            //enter COM0 to all as it is consider the option for 'empty'
            comboBoard1Port.Items.Add("COM0");
            comboBoard2Port.Items.Add("COM0");
            comboBoard3Port.Items.Add("COM0");
            comboBoard4Port.Items.Add("COM0");
            comboBoard5Port.Items.Add("COM0");

            //set the selected index to  for COM0 to be already selected
            comboBoard1Port.SelectedIndex = 0;
            comboBoard2Port.SelectedIndex = 0;
            comboBoard3Port.SelectedIndex = 0;
            comboBoard4Port.SelectedIndex = 0;
            comboBoard5Port.SelectedIndex = 0;

            if (ports.Length > 0) //if at least 1 port is found, then enter it in the comboboxes and dictionary
            {
                foreach (string sp in ports) //loop through all available ports to add the names in the comboboxes
                {
                    comboBoard1Port.Items.Add(sp);
                    comboBoard2Port.Items.Add(sp);
                    comboBoard3Port.Items.Add(sp);
                    comboBoard4Port.Items.Add(sp);
                    comboBoard5Port.Items.Add(sp);

                    isPortSelectedDict.Add(sp, false); //initializes the dictionary with the available ports set to false, aka not selected
                }
            }
        }

        private void BoardSetupForm_Load(object sender, EventArgs e)
        {
            refreshListbox();

            initializeLayerDict(); //resets dictionary
            resetLayerCombos(); //resets comboboxes
            
            resetPortCombos(); //resets comboboxes and dictionary
        }

        

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides the current form if user presses done
        }

        //add the amount of layers the users want to use to the dictionary
        private void initializeLayerDict()
        {
            isLayerSelectedDict.Clear(); //clear so that new values can be added from the start
            isLayerSelectedDict.Add("Layer 0", false); //layer 0 is considered to be an 'empty' layer. just like COM0 in the ports dictionary
            for (int i = 1; i <= numOfLayers.Value; i++) //loop the amount of layers selected by the user
            {
                isLayerSelectedDict.Add("Layer " + i, false); //add each layer to the dictionary. use false since none is selected yet
            }
        }

        //whenever user changes the amount of boards they want to use, hide/display the correct comboboxes
        private void numOfBoards_ValueChanged(object sender, EventArgs e)
        {
            int numberOfBoards = Decimal.ToInt32(numOfBoards.Value); //get value for number of boards

            numOfLayers.Maximum = numberOfBoards * 4; //since each board can have a max of 4 motors

            resetLayerCombos();

            switch (numberOfBoards)  //depending on the number of boards display/hide comboboxes and labels
            {
                case 1: 
                    comboBoard1Port.Visible = true;
                    comboBoard2Port.Visible = false;
                    comboBoard3Port.Visible = false;
                    comboBoard4Port.Visible = false;
                    comboBoard5Port.Visible = false;

                    comboBoard1MotorX.Visible = true;
                    comboBoard2MotorX.Visible = false;
                    comboBoard3MotorX.Visible = false;
                    comboBoard4MotorX.Visible = false;
                    comboBoard5MotorX.Visible = false;

                    comboBoard1MotorY.Visible = true;
                    comboBoard2MotorY.Visible = false;
                    comboBoard3MotorY.Visible = false;
                    comboBoard4MotorY.Visible = false;
                    comboBoard5MotorY.Visible = false;

                    comboBoard1MotorZ.Visible = true;
                    comboBoard2MotorZ.Visible = false;
                    comboBoard3MotorZ.Visible = false;
                    comboBoard4MotorZ.Visible = false;
                    comboBoard5MotorZ.Visible = false;

                    comboBoard1MotorE1.Visible = true;
                    comboBoard2MotorE1.Visible = false;
                    comboBoard3MotorE1.Visible = false;
                    comboBoard4MotorE1.Visible = false;
                    comboBoard5MotorE1.Visible = false;

                    lblBoard1.Visible = true;
                    lblBoard2.Visible = false;
                    lblBoard3.Visible = false;
                    lblBoard4.Visible = false;
                    lblBoard5.Visible = false;

                    break;
                case 2:
                    comboBoard1Port.Visible = true;
                    comboBoard2Port.Visible = true;
                    comboBoard3Port.Visible = false;
                    comboBoard4Port.Visible = false;
                    comboBoard5Port.Visible = false;

                    comboBoard1MotorX.Visible = true;
                    comboBoard2MotorX.Visible = true;
                    comboBoard3MotorX.Visible = false;
                    comboBoard4MotorX.Visible = false;
                    comboBoard5MotorX.Visible = false;

                    comboBoard1MotorY.Visible = true;
                    comboBoard2MotorY.Visible = true;
                    comboBoard3MotorY.Visible = false;
                    comboBoard4MotorY.Visible = false;
                    comboBoard5MotorY.Visible = false;

                    comboBoard1MotorZ.Visible = true;
                    comboBoard2MotorZ.Visible = true;
                    comboBoard3MotorZ.Visible = false;
                    comboBoard4MotorZ.Visible = false;
                    comboBoard5MotorZ.Visible = false;

                    comboBoard1MotorE1.Visible = true;
                    comboBoard2MotorE1.Visible = true;
                    comboBoard3MotorE1.Visible = false;
                    comboBoard4MotorE1.Visible = false;
                    comboBoard5MotorE1.Visible = false;

                    lblBoard1.Visible = true;
                    lblBoard2.Visible = true;
                    lblBoard3.Visible = false;
                    lblBoard4.Visible = false;
                    lblBoard5.Visible = false;

                    break;
                case 3:
                    comboBoard1Port.Visible = true;
                    comboBoard2Port.Visible = true;
                    comboBoard3Port.Visible = true;
                    comboBoard4Port.Visible = false;
                    comboBoard5Port.Visible = false;

                    comboBoard1MotorX.Visible = true;
                    comboBoard2MotorX.Visible = true;
                    comboBoard3MotorX.Visible = true;
                    comboBoard4MotorX.Visible = false;
                    comboBoard5MotorX.Visible = false;

                    comboBoard1MotorY.Visible = true;
                    comboBoard2MotorY.Visible = true;
                    comboBoard3MotorY.Visible = true;
                    comboBoard4MotorY.Visible = false;
                    comboBoard5MotorY.Visible = false;

                    comboBoard1MotorZ.Visible = true;
                    comboBoard2MotorZ.Visible = true;
                    comboBoard3MotorZ.Visible = true;
                    comboBoard4MotorZ.Visible = false;
                    comboBoard5MotorZ.Visible = false;

                    comboBoard1MotorE1.Visible = true;
                    comboBoard2MotorE1.Visible = true;
                    comboBoard3MotorE1.Visible = true;
                    comboBoard4MotorE1.Visible = false;
                    comboBoard5MotorE1.Visible = false;

                    lblBoard1.Visible = true;
                    lblBoard2.Visible = true;
                    lblBoard3.Visible = true;
                    lblBoard4.Visible = false;
                    lblBoard5.Visible = false;

                    break;
                case 4:
                    comboBoard1Port.Visible = true;
                    comboBoard2Port.Visible = true;
                    comboBoard3Port.Visible = true;
                    comboBoard4Port.Visible = true;
                    comboBoard5Port.Visible = false;

                    comboBoard1MotorX.Visible = true;
                    comboBoard2MotorX.Visible = true;
                    comboBoard3MotorX.Visible = true;
                    comboBoard4MotorX.Visible = true;
                    comboBoard5MotorX.Visible = false;

                    comboBoard1MotorY.Visible = true;
                    comboBoard2MotorY.Visible = true;
                    comboBoard3MotorY.Visible = true;
                    comboBoard4MotorY.Visible = true;
                    comboBoard5MotorY.Visible = false;

                    comboBoard1MotorZ.Visible = true;
                    comboBoard2MotorZ.Visible = true;
                    comboBoard3MotorZ.Visible = true;
                    comboBoard4MotorZ.Visible = true;
                    comboBoard5MotorZ.Visible = false;

                    comboBoard1MotorE1.Visible = true;
                    comboBoard2MotorE1.Visible = true;
                    comboBoard3MotorE1.Visible = true;
                    comboBoard4MotorE1.Visible = true;
                    comboBoard5MotorE1.Visible = false;

                    lblBoard1.Visible = true;
                    lblBoard2.Visible = true;
                    lblBoard3.Visible = true;
                    lblBoard4.Visible = true;
                    lblBoard5.Visible = false;

                    break;
                case 5:
                    comboBoard1Port.Visible = true;
                    comboBoard2Port.Visible = true;
                    comboBoard3Port.Visible = true;
                    comboBoard4Port.Visible = true;
                    comboBoard5Port.Visible = true;

                    comboBoard1MotorX.Visible = true;
                    comboBoard2MotorX.Visible = true;
                    comboBoard3MotorX.Visible = true;
                    comboBoard4MotorX.Visible = true;
                    comboBoard5MotorX.Visible = true;

                    comboBoard1MotorY.Visible = true;
                    comboBoard2MotorY.Visible = true;
                    comboBoard3MotorY.Visible = true;
                    comboBoard4MotorY.Visible = true;
                    comboBoard5MotorY.Visible = true;

                    comboBoard1MotorZ.Visible = true;
                    comboBoard2MotorZ.Visible = true;
                    comboBoard3MotorZ.Visible = true;
                    comboBoard4MotorZ.Visible = true;
                    comboBoard5MotorZ.Visible = true;

                    comboBoard1MotorE1.Visible = true;
                    comboBoard2MotorE1.Visible = true;
                    comboBoard3MotorE1.Visible = true;
                    comboBoard4MotorE1.Visible = true;
                    comboBoard5MotorE1.Visible = true;

                    lblBoard1.Visible = true;
                    lblBoard2.Visible = true;
                    lblBoard3.Visible = true;
                    lblBoard4.Visible = true;
                    lblBoard5.Visible = true;

                    break;
                default:
                    comboBoard1Port.Visible = true;
                    comboBoard2Port.Visible = false;
                    comboBoard3Port.Visible = false;
                    comboBoard4Port.Visible = false;
                    comboBoard5Port.Visible = false;

                    comboBoard1MotorX.Visible = true;
                    comboBoard2MotorX.Visible = false;
                    comboBoard3MotorX.Visible = false;
                    comboBoard4MotorX.Visible = false;
                    comboBoard5MotorX.Visible = false;

                    comboBoard1MotorY.Visible = true;
                    comboBoard2MotorY.Visible = false;
                    comboBoard3MotorY.Visible = false;
                    comboBoard4MotorY.Visible = false;
                    comboBoard5MotorY.Visible = false;

                    comboBoard1MotorZ.Visible = true;
                    comboBoard2MotorZ.Visible = false;
                    comboBoard3MotorZ.Visible = false;
                    comboBoard4MotorZ.Visible = false;
                    comboBoard5MotorZ.Visible = false;

                    comboBoard1MotorE1.Visible = true;
                    comboBoard2MotorE1.Visible = false;
                    comboBoard3MotorE1.Visible = false;
                    comboBoard4MotorE1.Visible = false;
                    comboBoard5MotorE1.Visible = false;

                    lblBoard1.Visible = true;
                    lblBoard2.Visible = false;
                    lblBoard3.Visible = false;
                    lblBoard4.Visible = false;
                    lblBoard5.Visible = false;

                    break;
            }
        }

        //reset all layer comboboxes
        private void resetLayerCombos()
        {
            //clear them first to enter values from the start
            comboBoard1MotorX.Items.Clear();
            comboBoard1MotorY.Items.Clear();
            comboBoard1MotorZ.Items.Clear();
            comboBoard1MotorE1.Items.Clear();

            comboBoard2MotorX.Items.Clear();
            comboBoard2MotorY.Items.Clear();
            comboBoard2MotorZ.Items.Clear();
            comboBoard2MotorE1.Items.Clear();

            comboBoard3MotorX.Items.Clear();
            comboBoard3MotorY.Items.Clear();
            comboBoard3MotorZ.Items.Clear();
            comboBoard3MotorE1.Items.Clear();

            comboBoard4MotorX.Items.Clear();
            comboBoard4MotorY.Items.Clear();
            comboBoard4MotorZ.Items.Clear();
            comboBoard4MotorE1.Items.Clear();

            comboBoard5MotorX.Items.Clear();
            comboBoard5MotorY.Items.Clear();
            comboBoard5MotorZ.Items.Clear();
            comboBoard5MotorE1.Items.Clear();

            for (int i = 0; i <= numOfLayers.Value; i++) //enter values in the comboboxes
            {
                comboBoard1MotorX.Items.Add("Layer " + i);
                comboBoard1MotorY.Items.Add("Layer " + i);
                comboBoard1MotorZ.Items.Add("Layer " + i);
                comboBoard1MotorE1.Items.Add("Layer " + i);

                comboBoard2MotorX.Items.Add("Layer " + i);
                comboBoard2MotorY.Items.Add("Layer " + i);
                comboBoard2MotorZ.Items.Add("Layer " + i);
                comboBoard2MotorE1.Items.Add("Layer " + i);

                comboBoard3MotorX.Items.Add("Layer " + i);
                comboBoard3MotorY.Items.Add("Layer " + i);
                comboBoard3MotorZ.Items.Add("Layer " + i);
                comboBoard3MotorE1.Items.Add("Layer " + i);

                comboBoard4MotorX.Items.Add("Layer " + i);
                comboBoard4MotorY.Items.Add("Layer " + i);
                comboBoard4MotorZ.Items.Add("Layer " + i);
                comboBoard4MotorE1.Items.Add("Layer " + i);

                comboBoard5MotorX.Items.Add("Layer " + i);
                comboBoard5MotorY.Items.Add("Layer " + i);
                comboBoard5MotorZ.Items.Add("Layer " + i);
                comboBoard5MotorE1.Items.Add("Layer " + i);
            }

            //select 'Layer 0' for every combobox as it is the default 'empty' option
            comboBoard1MotorX.SelectedIndex = 0;
            comboBoard1MotorY.SelectedIndex = 0;
            comboBoard1MotorZ.SelectedIndex = 0;
            comboBoard1MotorE1.SelectedIndex = 0;

            comboBoard2MotorX.SelectedIndex = 0;
            comboBoard2MotorY.SelectedIndex = 0;
            comboBoard2MotorZ.SelectedIndex = 0;
            comboBoard2MotorE1.SelectedIndex = 0;

            comboBoard3MotorX.SelectedIndex = 0;
            comboBoard3MotorY.SelectedIndex = 0;
            comboBoard3MotorZ.SelectedIndex = 0;
            comboBoard3MotorE1.SelectedIndex = 0;

            comboBoard4MotorX.SelectedIndex = 0;
            comboBoard4MotorY.SelectedIndex = 0;
            comboBoard4MotorZ.SelectedIndex = 0;
            comboBoard4MotorE1.SelectedIndex = 0;

            comboBoard5MotorX.SelectedIndex = 0;
            comboBoard5MotorY.SelectedIndex = 0;
            comboBoard5MotorZ.SelectedIndex = 0;
            comboBoard5MotorE1.SelectedIndex = 0;
        }

        //whenever the number of layers changes, reset the layer dictionary together with the comboboxes
        private void numOfLayers_ValueChanged(object sender, EventArgs e)
        {
            initializeLayerDict(); //reset the dictionary
            resetLayerCombos(); // clear all values and enter them again since the user has changed the amount of layers they want to use
        }

        //function that returns a list with only the selected layers together with the corresponding board and motor
        //basically returns the mapped layers the user has entered
        private List<string> layerComboboxValuesIntoList()
        {
            List<string> layersOutput = new List<string>(); //create new list to enter values into

            //only add values to list if an actual layer is selected, not Layer 0
            if (comboBoard1MotorX.Text != "Layer 0") layersOutput.Add(comboBoard1MotorX.Text + " Board1 MotorX");
            if (comboBoard2MotorX.Text != "Layer 0") layersOutput.Add(comboBoard2MotorX.Text + " Board2 MotorX");
            if (comboBoard3MotorX.Text != "Layer 0") layersOutput.Add(comboBoard3MotorX.Text + " Board3 MotorX");
            if (comboBoard4MotorX.Text != "Layer 0") layersOutput.Add(comboBoard4MotorX.Text + " Board4 MotorX");
            if (comboBoard5MotorX.Text != "Layer 0") layersOutput.Add(comboBoard5MotorX.Text + " Board5 MotorX");
            if (comboBoard1MotorY.Text != "Layer 0") layersOutput.Add(comboBoard1MotorY.Text + " Board1 MotorY");
            if (comboBoard2MotorY.Text != "Layer 0") layersOutput.Add(comboBoard2MotorY.Text + " Board2 MotorY");
            if (comboBoard3MotorY.Text != "Layer 0") layersOutput.Add(comboBoard3MotorY.Text + " Board3 MotorY");
            if (comboBoard4MotorY.Text != "Layer 0") layersOutput.Add(comboBoard4MotorY.Text + " Board4 MotorY");
            if (comboBoard5MotorY.Text != "Layer 0") layersOutput.Add(comboBoard5MotorY.Text + " Board5 MotorY");
            if (comboBoard1MotorZ.Text != "Layer 0") layersOutput.Add(comboBoard1MotorZ.Text + " Board1 MotorZ");
            if (comboBoard2MotorZ.Text != "Layer 0") layersOutput.Add(comboBoard2MotorZ.Text + " Board2 MotorZ");
            if (comboBoard3MotorZ.Text != "Layer 0") layersOutput.Add(comboBoard3MotorZ.Text + " Board3 MotorZ");
            if (comboBoard4MotorZ.Text != "Layer 0") layersOutput.Add(comboBoard4MotorZ.Text + " Board4 MotorZ");
            if (comboBoard5MotorZ.Text != "Layer 0") layersOutput.Add(comboBoard5MotorZ.Text + " Board5 MotorZ");
            if (comboBoard1MotorE1.Text != "Layer 0") layersOutput.Add(comboBoard1MotorE1.Text + " Board1 MotorE1");
            if (comboBoard2MotorE1.Text != "Layer 0") layersOutput.Add(comboBoard2MotorE1.Text + " Board2 MotorE1");
            if (comboBoard3MotorE1.Text != "Layer 0") layersOutput.Add(comboBoard3MotorE1.Text + " Board3 MotorE1");
            if (comboBoard4MotorE1.Text != "Layer 0") layersOutput.Add(comboBoard4MotorE1.Text + " Board4 MotorE1");
            if (comboBoard5MotorE1.Text != "Layer 0") layersOutput.Add(comboBoard5MotorE1.Text + " Board5 MotorE1");

            return layersOutput; //return the list
        }

        //save the setup and layer mapping to the file
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            
            InputBox inputBox = new InputBox("Enter a name for the new file"); //show an input box for the user to enter the name of the file
            do //show input box until user has entered a value or pressed cancel
            {
                inputBox.ShowDialog();
            } while (inputBox.input == "" & inputBox.shouldClose == false);

            if (inputBox.input != "") //only write to file if the name is not empty
            {
                //add port values to the lines list
                List<string> lines = new List<string>();
                lines.Add(comboBoard1Port.Text);
                lines.Add(comboBoard2Port.Text);
                lines.Add(comboBoard3Port.Text);
                lines.Add(comboBoard4Port.Text);
                lines.Add(comboBoard5Port.Text);
                //enters the returned list from the function into the lines list
                lines.AddRange(layerComboboxValuesIntoList());
                

                //write lines list to file
                string path = Environment.CurrentDirectory;
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\")) + @"\" + inputBox.input + ".setup";
                System.IO.File.WriteAllLines(@newPath, lines);
            }

            refreshListbox(); //refresh to show the new file that was saved
        }

        //delete the selected setup file
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDeleteSetupFile.SelectedItems.Count > 0) // attempt to delete the file only if a file is selected
            {
                string path = Environment.CurrentDirectory;
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\")) + @"\" + lstDeleteSetupFile.SelectedItem.ToString();
                File.Delete(newPath);
                refreshListbox();
            }
            else //if nothing is selected then inform user
            {
                MessageBox.Show("Make sure you have selected a file from the listbox", "File Not Selected");
            }
        }

        private void refreshListbox() //refresh the values in the setup files listbox
        {
            string path = Environment.CurrentDirectory;
            string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\"));
            string[] files = System.IO.Directory.GetFiles(newPath, "*.setup"); //gets all files with extension .setup

            lstDeleteSetupFile.Items.Clear(); //clear to enter new values
            foreach (string file in files) //loop in the files array to enter the names of the files
            {
                lstDeleteSetupFile.Items.Add(System.IO.Path.GetFileName(file)); //enter name of file
            }
        }

        //used to check if the port is already selected
        private void portValidationHandler(ComboBox comboBoardPort)
        {
            string selectedValue = comboBoardPort.Text; //port name that user wants to select
            bool isAlreadySelected = isPortSelectedDict[selectedValue]; //true if it is already selected, false otherwise
            if (selectedValue != "COM0") //since COM0 is only used as an 'empty' port it is okay to be selected on multiple boards
            {
                if (isAlreadySelected) //if true then user can't select this port again
                {
                    MessageBox.Show("Port " + selectedValue + " is already selected for another board.", "Error");
                    comboBoardPort.SelectedIndex = 0; //set selected port to 'COM0'
                }
                else if (!isAlreadySelected) //if false, then allow the user to select the port and set the value in the dict to true
                {
                    isPortSelectedDict[selectedValue] = true; //means that the port is selected, so that it cannot be selected again
                }
            }
        }

        //used to check if the layer is already selected
        private void layerValidationHandler(ComboBox comboBoard)
        {
            string selectedValue = comboBoard.Text; //layer name that user wants to select
            bool isAlreadySelected = isLayerSelectedDict[selectedValue]; 
            if (selectedValue != "Layer 0") //since Layer 0 is only used as an 'empty' layer it is okay to be selected on multiple motors
            {
                if (isAlreadySelected) //if true then user can't select this layer again
                {
                    MessageBox.Show("Layer " + selectedValue + " is already selected for another motor.", "Error");
                    comboBoard.SelectedIndex = 0; //set selected layer to 'Layer 0'
                }
                else if (!isAlreadySelected) //means that layer is not already selected
                {
                    isLayerSelectedDict[selectedValue] = true; //set the layer as selected so that it cannot be selected again
                }
            }
        }

        //when user tries to change any value in any combobox, then call the above procedures to handle the selection
        private void comboBoard1Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            portValidationHandler(comboBoard1Port);
        }

        private void comboBoard2Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            portValidationHandler(comboBoard2Port);
        }

        private void comboBoard3Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            portValidationHandler(comboBoard3Port);
        }

        private void comboBoard4Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            portValidationHandler(comboBoard4Port);
        }

        private void comboBoard5Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            portValidationHandler(comboBoard5Port);
        }



        private void comboBoard1MotorX_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard1MotorX);
        }

        private void comboBoard2MotorX_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard2MotorX);
        }

        private void comboBoard3MotorX_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard3MotorX);
        }

        private void comboBoard4MotorX_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard4MotorX);
        }

        private void comboBoard5MotorX_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard5MotorX);
        }

        private void comboBoard1MotorY_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard1MotorY);
        }

        private void comboBoard2MotorY_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard2MotorY);
        }

        private void comboBoard3MotorY_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard3MotorY);
        }

        private void comboBoard4MotorY_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard4MotorY);
        }

        private void comboBoard5MotorY_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard5MotorY);
        }

        private void comboBoard1MotorZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard1MotorZ);
        }

        private void comboBoard2MotorZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard2MotorZ);
        }

        private void comboBoard3MotorZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard3MotorZ);
        }

        private void comboBoard4MotorZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard4MotorZ);
        }

        private void comboBoard5MotorZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard5MotorZ);
        }

        private void comboBoard1MotorE1_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard1MotorE1);
        }

        private void comboBoard2MotorE1_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard2MotorE1);
        }

        private void comboBoard3MotorE1_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard3MotorE1);
        }

        private void comboBoard4MotorE1_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard4MotorE1);
        }

        private void comboBoard5MotorE1_SelectedIndexChanged(object sender, EventArgs e)
        {
            layerValidationHandler(comboBoard5MotorE1);
        }

        private void btnResetLayers_Click(object sender, EventArgs e)
        {
            resetLayerCombos();
        }

        private void btnResetPorts_Click(object sender, EventArgs e)
        {
            resetPortCombos();
        }

        
    }
}
