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

namespace ArduinoComputingProject
{
    public partial class MainForm : Form
    {
        
        //Instantiate baord objects
        ArduinoBoardClass board1 = new ArduinoBoardClass();
        ArduinoBoardClass board2 = new ArduinoBoardClass();
        ArduinoBoardClass board3 = new ArduinoBoardClass();
        ArduinoBoardClass board4 = new ArduinoBoardClass();
        ArduinoBoardClass board5 = new ArduinoBoardClass();
        

        string selectedPort = "";
        List<string> executionList = new List<string>(); //to store the names of the files to be executed

        int boardsUsed = 5; //CHANGE SO THAT IT GETS THE NUMBER OF BOARDS USED
        
        Dictionary<string, ArduinoBoardClass> boardsDict = new Dictionary<string, ArduinoBoardClass>();
        Dictionary<int, string[]> layersDict = new Dictionary<int, string[]>();

        public MainForm()
        {
            InitializeComponent();
            board1.serialPort = serialPort1;
            board2.serialPort = serialPort2;
            board3.serialPort = serialPort3;
            board4.serialPort = serialPort4;
            board5.serialPort = serialPort5;
        }

        private void btnBoardSetup_Click(object sender, EventArgs e)
        {
            BoardSetupForm boardSetupForm = new BoardSetupForm();
            boardSetupForm.Show();
        }

        private void btnCreateSequence_Click(object sender, EventArgs e)
        {
            CreateEditSequenceForm createSequenceForm = new CreateEditSequenceForm();
            createSequenceForm.Show();
        }

        public void setPorts(string[] ports)
        {
            board1.serialPort.PortName = ports[0];
            board2.serialPort.PortName = ports[1];
            board3.serialPort.PortName = ports[2];
            board4.serialPort.PortName = ports[3];
            board5.serialPort.PortName = ports[4];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setPorts(new string[] {"COM0", "COM0", "COM0", "COM0", "COM0" });
            refreshListboxes();
            setupBoardDict();
        }

        private void lstSequenceFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lstSequenceFiles.SelectedItems.Count != 0)
            {
                executionList.Add(lstSequenceFiles.SelectedItem.ToString());
            }
            refreshListboxes();
        }

        private void refreshListboxes()
        {
            //execution list listbox
            lstExecutionList.Items.Clear();
            for (int i = 0; i < executionList.Count; i++)
            {
                lstExecutionList.Items.Add(executionList[i]);
            }

            //saved sequences listbox
            string path = Environment.CurrentDirectory;
            string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\"));
            string[] sequenceFiles = System.IO.Directory.GetFiles(newPath, "*.seq");

            lstSequenceFiles.Items.Clear();
            foreach (string file in sequenceFiles)
            {
                lstSequenceFiles.Items.Add(System.IO.Path.GetFileName(file));
            }

            //board setup files listbox
            string[] setupFiles = System.IO.Directory.GetFiles(newPath, "*.setup");

            lstBoardSetupFiles.Items.Clear();
            foreach (string file in setupFiles)
            {
                lstBoardSetupFiles.Items.Add(System.IO.Path.GetFileName(file));
            }
        }

        private void lstExecutionList_DoubleClick(object sender, EventArgs e)
        {
            if (lstExecutionList.SelectedItems.Count > 0)
            {
                executionList.Remove(lstExecutionList.SelectedItem.ToString());
            }
            refreshListboxes();
        }

        private void executeSequence(string fileName)
        {
            string path = Environment.CurrentDirectory;
            string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\"));
            string[] lines = System.IO.File.ReadAllLines(@newPath + fileName);

            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                
                if (words[0] != "delay" & words[0] != "end" & words[0] != "home")
                {
                    int layerNum = Int32.Parse(words[0].Substring(words[0].Length - 2));
                    int num = Int32.Parse(words[1]);
                    string boardName = layersDict[layerNum][0];

                    if (layersDict[layerNum][1] == "MotorX") boardsDict[boardName].degX = num;
                    if (layersDict[layerNum][1] == "MotorY") boardsDict[boardName].degY = num;
                    if (layersDict[layerNum][1] == "MotorZ") boardsDict[boardName].degZ = num;
                    if (layersDict[layerNum][1] == "MotorE1") boardsDict[boardName].degE1 = num;

                }
                else if (words[0] == "delay")
                {
                    int num = Int32.Parse(words[1]);
                    //execute all code above the delay, then execute delay
                    
                    for (int i = 1; i <= boardsUsed; i++)
                    {
                        boardsDict["Board" + i].moveMotors();
                    }

                   // moveMotors();
                    resetBoardObjects();

                    var delay = Task.Run(async delegate
                    {
                        await Task.Delay(num);
                        return 42;
                    });
                    delay.Wait();
                }
                else if (words[0] == "end")
                {
                    for (int i = 1; i <= boardsUsed; i++)
                    {
                        boardsDict["Board" + i].moveMotors();
                    }

                    resetBoardObjects();
                }
                else if (words[0] == "home")
                {
                    for (int i = 1; i <= boardsUsed; i++)
                    {
                        boardsDict["Board" + i].moveHome(); 
                    }

                    resetBoardObjects();
                }
            }

            
        }

        
        private void resetBoardObjects()
        { 

            for (int i = 1; i <= boardsUsed; i++)
            {
                boardsDict["Board" + i].degX = 0;
                boardsDict["Board" + i].degY = 0;
                boardsDict["Board" + i].degZ = 0;
                boardsDict["Board" + i].degE1 = 0;
            }
        }


        private void setupBoardDict()
        {

            //Boards Dictionary
            boardsDict.Add("Board1", board1);
            boardsDict.Add("Board2", board2);
            boardsDict.Add("Board3", board3);
            boardsDict.Add("Board4", board4);
            boardsDict.Add("Board5", board5);

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            //CHECK LATER: if ports were not set don't execute sequence

            if (executionList.Count == 0)
            {
                MessageBox.Show("Make sure you have at least one sequence in the execution list.", "Empty List");
            }
            else
            {
                try
                {
                    foreach (string sequence in executionList)
                    {
                        executeSequence(sequence);
                        var delay = Task.Run(async delegate
                        {
                            await Task.Delay(1500);
                            return 42;
                        });
                        delay.Wait();
                    }
                }

                catch
                {
                    MessageBox.Show("Error: Make sure all boards are connected and all ports are assigned correctly!", "Serial Communication Error");
                }
                
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            refreshListboxes();
        }

        private void btnAssignPorts_Click(object sender, EventArgs e)
        {
            if (lstBoardSetupFiles.SelectedItems.Count > 0)
            {
                string path = Environment.CurrentDirectory;
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\"));
                string[] lines = System.IO.File.ReadAllLines(@newPath + lstBoardSetupFiles.SelectedItem.ToString());
                string[] ports = lines; //copy lines array to ports array to cut it later
                Array.Resize(ref ports, 5); //cut array to only 5 elements. (number of ports/boards)
                setPorts(ports);

                for (int i = 5; i < lines.Length; i++) //i=4 to start after the 5 lines that have the port names
                {
                    string[] words = lines[i].Split(' '); //split the current line in words
                    layersDict[Int32.Parse(words[1])] = new string[] {words[2], words[3]}; //assign the value for the board and motor for the specified layer
                    //example line: 'Layer 1 Board1 MotorX'
                }
            }
            else
            {
                MessageBox.Show("Make sure you have selected a file from the listbox", "File Not Selected");
            }

        }

       

        

    }
}
