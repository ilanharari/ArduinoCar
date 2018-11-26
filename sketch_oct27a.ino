//LED defined for starting the game!
const int LED_PIN = 11;

//define output pin for our car
const int THROTTLE_PIN = 9;

//values for throttle
const int maxForward = 190;
const int zeroThrottle = 100;
const int maxReverse = 77;

//read from serial port
byte input;

bool serialState = 1;

void setup() 
{
  //initialize the pins as outputs
  pinMode(THROTTLE_PIN, OUTPUT);
  pinMode(LED_PIN, OUTPUT);

  //turn LED off untill game starts
  digitalWrite(LED_PIN, LOW);
  
  //This will give us a few seconds before the setup starts
  analogWrite(THROTTLE_PIN, zeroThrottle);
  delay(10000);

  //Game starts, turn on LED
  digitalWrite(LED_PIN, HIGH);
  
  //initialize serial mointor(optional)
  Serial.begin(9600);
}

//this is like a while(true) loop
void loop()
{
  //Read the serial port
  if(Serial.available())
  {
    input = Serial.read();
  }
  //Move backwards at constant speed if the answer is wrong, 70 == F in ascii
  if(input == 70)
  {
    analogWrite(THROTTLE_PIN, maxReverse); 
    Serial.println('F');
    serialState = 1;
  //Move forward for one second if user gets answer right, 84 == T in ascii
  }else if(input == 84 && serialState)
  {
    analogWrite(THROTTLE_PIN, maxForward);
    Serial.println('T');
    delay(1000);
    analogWrite(THROTTLE_PIN, maxReverse);
    serialState = 0;
  //Stop the car when game is done, 83 == S in ascii
  }else if(input == 83)
  {
    analogWrite(THROTTLE_PIN, zeroThrottle);
    Serial.println('S');
  }    
}
