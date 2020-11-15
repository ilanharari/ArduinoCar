//LED defined for starting the game!
#define LED_PIN = 11;

//define output pin for our car
#define THROTTLE_PIN = 9;

//values for throttle
#define maxForward = 190;
#define zeroThrottle = 100;
#define maxReverse = 77;

void setup() 
{
  //initialize the pins as outputs
  pinMode(THROTTLE_PIN, OUTPUT);
  pinMode(LED_PIN, OUTPUT);

  //turn LED off untill game starts
  digitalWrite(LED_PIN, LOW);
  
  //This will give us a 10 seconds before the setup starts
  analogWrite(THROTTLE_PIN, zeroThrottle);
  delay(10000);

  //Game starts, turn on LED
  digitalWrite(LED_PIN, HIGH);
  
  //Initialize serial mointor
  Serial.begin(9600);
}

//this is like a while(true) loop
void loop(){
  char input;
  //Read the serial port
  if(Serial.available()){
    input = Serial.read();
  }
  //Move backwards at constant speed if the answer is wrong
  if(input == 'F'){
    analogWrite(THROTTLE_PIN, maxReverse); 
    Serial.println('F');
    serialState = 1;
  }
  //Move forward for one second if user gets answer right
  else if(input == 'T' && serialState){
    analogWrite(THROTTLE_PIN, maxForward);
    Serial.println('T');
    delay(1000);
    analogWrite(THROTTLE_PIN, maxReverse);
    serialState = 0;
  }
  //Stop the car when game is done
  else{// if(input == 'S')
    analogWrite(THROTTLE_PIN, zeroThrottle);
    Serial.println('S');
  }    
}
