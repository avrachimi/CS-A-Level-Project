using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduinoComputingProject
{
    public class ArduinoBoardClass
    {


        public SerialPort serialPort = new SerialPort();

        //to store the degrees to move
        public int degX = 0;
        public int degY = 0;
        public int degZ = 0;
        public int degE1 = 0;

        //dir set to 1 since 1 turns clockwise
        int dirX = 1;
        int dirY = 1;
        int dirZ = 1;
        int dirE1 = 1;

        public void moveMotors()
        {
            assignValues();
            string output = dirX + "," + degX + ",motorX;" + //Each line is for each motor's parameters
                            dirY + "," + degY + ",motorY;" +
                            dirZ + "," + degZ + ",motorZ;" +
                            dirE1 + "," + degE1 + ",motorE1;";

            if (!serialPort.IsOpen) //only send commands if the port is open
            {
                try //to make sure that the program doesn't crash
                {
                    serialPort.Open();
                    serialPort.Write(output); //send the command to the board
                    serialPort.Close(); //close the port 
                }
                catch
                {
                    //don't do anything. this kind of error is handled in main form
                    //MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                }
            }
        }






        private void assignValues() //the board takes values like deg:180 dir:0 instead of deg:-180. this method converts the values so that they are readable by the board
        {
            //---X------------
            if (degX < 0)
            {
                dirX = 0;
                degX = -degX;
            }

            //---Y------------
            if (degY < 0)
            {
                dirY = 0;
                degY = -degY;
            }

            //---Z------------
            if (degZ < 0)
            {
                dirZ = 0;
                degZ = -degZ;
            }

            //---E1------------
            if (degE1 < 0)
            {
                dirE1 = 0;
                degE1 = -degE1;
            }
        }

        public void moveHome()
        {
            string output = "home";

            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.Open();
                    serialPort.Write(output);
                    serialPort.Close();
                }
                catch
                {
                    //don't do anything. this kind of error is handled in main form
                    //MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                }
            }
        }

    }
}
