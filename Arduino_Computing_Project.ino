// Pins for the RAMPS board
const int X_STEP_PIN         = 54;
const int X_DIR_PIN          = 55;
const int X_ENABLE_PIN       = 38; 

const int Y_STEP_PIN         = 60;
const int Y_DIR_PIN          = 61;
const int Y_ENABLE_PIN       = 56;  

const int Z_STEP_PIN         = 46;
const int Z_DIR_PIN          = 48;
const int Z_ENABLE_PIN       = 62; 

const int E1_STEP_PIN         = 26;
const int E1_DIR_PIN          = 28;
const int E1_ENABLE_PIN       = 24;

String inputValue = ""; 

//steps that each motor has moved. Adds/Subtracts steps as the motors move in diff. directions
int stepsX = 0;
int stepsY = 0;
int stepsZ = 0;
int stepsE1 = 0;


#include <Stepper.h>

//define motors with their pins
Stepper motorX( 6200, X_STEP_PIN, X_DIR_PIN );
Stepper motorY( 6200, Y_STEP_PIN, Y_DIR_PIN );
Stepper motorZ( 6200, Z_STEP_PIN, Z_DIR_PIN );
Stepper motorE1( 6200, E1_STEP_PIN, E1_DIR_PIN );

const int stepsPerRevolution = 200;

bool shouldExecute = false;

void setup() {

  Serial.begin(9600); //start serial communication

  //set the pins as outputs
  pinMode(X_STEP_PIN  , OUTPUT);
  pinMode(X_DIR_PIN    , OUTPUT);
  pinMode(X_ENABLE_PIN    , OUTPUT);
  
  pinMode(Y_STEP_PIN  , OUTPUT);
  pinMode(Y_DIR_PIN    , OUTPUT);
  pinMode(Y_ENABLE_PIN    , OUTPUT);
  
  pinMode(Z_STEP_PIN  , OUTPUT);
  pinMode(Z_DIR_PIN    , OUTPUT);
  pinMode(Z_ENABLE_PIN    , OUTPUT);

  pinMode(E1_STEP_PIN  , OUTPUT);
  pinMode(E1_DIR_PIN    , OUTPUT);
  pinMode(E1_ENABLE_PIN    , OUTPUT);

  //for motors to work, their ENABLE pin has to be set to LOW
  digitalWrite(X_ENABLE_PIN    , LOW);
  digitalWrite(Y_ENABLE_PIN    , LOW);
  digitalWrite(Z_ENABLE_PIN    , LOW);
  digitalWrite(E1_ENABLE_PIN    , LOW);

  //set motors' speed(rpm)
  motorX.setSpeed(60);
  motorY.setSpeed(60);
  motorZ.setSpeed(60);
  motorE1.setSpeed(60);
}

void loop() {

  //move motors if we get input
  if (shouldExecute) {
    decodeInput(inputValue, ',');
  }
}

void moveAll(int degX, int degY, int degZ, int degE1) {
  
  int stepsToMoveX = (64 * degX) / 360 * stepsPerRevolution;
  int stepsToMoveY = (64 * degY) / 360 * stepsPerRevolution;
  int stepsToMoveZ = (64 * degZ) / 360 * stepsPerRevolution;
  int stepsToMoveE1 = (64 * degE1) / 360 * stepsPerRevolution;
  
  for (int i = 0; i < 8; i++) //the .step function doesn't work if i use the total steps in one call. so i use a for loop and split the number of steps
  {
    motorX.step(stepsToMoveX);
  }
  stepsX = 8 * stepsToMoveX; //assign steps that the motor has moved to the stepsX variable

  //repeat the same for all other motors
  for (int i = 0; i < 8; i++)
  {
    motorY.step(stepsToMoveY);
  }
  stepsY = 8 * stepsToMoveY;

  for (int i = 0; i < 8; i++)
  {
    motorZ.step(stepsToMoveZ);
  }
  stepsZ = 8 * stepsToMoveZ;

  for (int i = 0; i < 8; i++)
  {
    motorE1.step(stepsToMoveE1);
  }
  stepsE1 = 8 * stepsToMoveE1;
}

void moveHome() {

  for (int i = 0; i < 8; i++) //use the for loop again to split the steps
  {
    motorX.step(-stepsX/8); //change direction with '-' and divide the steps by 8 because before they were multiplied by 8
  }

  //repeat for al motors
  for (int i = 0; i < 8; i++)
  {
    motorY.step(-stepsY/8);
  }

  for (int i = 0; i < 8; i++)
  {
    motorZ.step(-stepsZ/8);
  }

  for (int i = 0; i < 8; i++)
  {
    motorE1.step(-stepsE1/8);
  }
}

//if serial input is received then input the string in inputValue
void serialEvent() {
  if (Serial.available() > 0) {
    inputValue = Serial.readString();
  }
  shouldExecute = true; // true so that decodeInput will be executed in the main loop
  
}

//used to decode the input string into motor movements
void decodeInput(String data, char separator) //separator is used to know where to separate each part of the string
{
  int found = 0;
  String input = "";
  int maxIndex = data.length()-1;
  int lastIndex = 0;
  String lastKeyword = "";
  int tempValue = 1; //temporary value to store the input integers
  //degrees for each motor
  int X = 0;
  int Y = 0;
  int Z = 0;
  int E1 = 0;
  
  if ( data == "home") //move all motors to home position
  {
    moveHome();
  }
  else //if not home, then move motors the amount of degrees specified
  {
      //loop through each char of the string
      for(int i=0; i<=maxIndex; i++){
          //if separator is found, split the string
          if(data.charAt(i)==separator)
          {
             found++; //separator found
             input = data.substring(lastIndex, i); //split string
             lastIndex = i + 1; //use this so that the next split starts from the correct position, not the beginning
             
           //if 0 or 1 then it's the direction of the motor
           if (input.toInt() == 0) 
           {
             tempValue = -1;
           } 
           else if (input.toInt() == 1) 
           {
             tempValue = 1;
           } 
           //with this method there is a limitation and the user can't move the motor 1 degree, but the motor has a physical limit of minimun 1.8 degree movement
           else //if not 0 or 1 then assign the degrees to tempValue
           {
             tempValue = tempValue * input.toInt();
           }
        } 
        else if (data.charAt(i) == ';') // ';' is the separator for each motor
        {
          lastKeyword = data.substring(lastIndex, i);
          lastIndex = i + 1;
          //depending on the keyword, assign the degrees value to the correct motor
          if ( lastKeyword == "motorX") 
          {
            X = tempValue;
          } 
          else if ( lastKeyword == "motorY") 
          {
            Y = tempValue;
          } 
          else if ( lastKeyword == "motorZ") 
          {
            Z = tempValue;
          }
          else if ( lastKeyword == "motorE1") 
          {
            E1 = tempValue;
          }
        }
      }
      moveAll(X,Y,Z,E1); //move motors
  }
  shouldExecute = false; //false so that it doesn't execute the same code again in the main loop
}





