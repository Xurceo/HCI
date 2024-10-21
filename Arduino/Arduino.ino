int i = 0;
int led = 13;
int button = 4;

void setup() {
  Serial.begin(9600);
  pinMode(led, OUTPUT);
  pinMode(button, INPUT);
}
void loop() {
  if (digitalRead(button))
  {
    Serial.println(1);
  }
  else
  {
    Serial.println(0);
  }
  delay(200);
}