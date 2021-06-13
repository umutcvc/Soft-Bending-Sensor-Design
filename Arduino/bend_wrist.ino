const int flexpin = A0;
const float VCC = 5;
const float R_DIV = 5000.0;
const float flatResistance = 6200.0;
const float bendResistance = 9000.0;
#define WINDOW_SIZE 5
int INDEX = 0;
int VALUE = 0;
int SUM = 0;
int READINGS[WINDOW_SIZE];

void setup(){
  Serial.begin(115200);
int AVERAGED = 0;
  pinMode(flexpin,INPUT);
}

void loop(){
  SUM = SUM - READINGS[INDEX];       // Remove the oldest entry from the sum
  VALUE = analogRead(flexpin);        // Read the next sensor value
  READINGS[INDEX] = VALUE;           // Add the newest reading to the window
  SUM = SUM + VALUE;                 // Add the newest reading to the sum
  INDEX = (INDEX+1) % WINDOW_SIZE;   // Increment the index, and wrap to 0 if it exceeds the window size
 // AVERAGED = SUM / WINDOW_SIZE; 
  int ADCflex = SUM / WINDOW_SIZE; //AVERAGED
  float Vflex = ADCflex*VCC/1023.0;
  float Rflex = R_DIV*(VCC/Vflex-1.0);
  int angle = map(Rflex, flatResistance, bendResistance,0,180);
  Serial.println(angle);
  delay(50);
}
