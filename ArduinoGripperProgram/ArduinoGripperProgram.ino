#define pinClk 4
#define pinCw 3
#define delayUs 500


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(pinClk, OUTPUT);
  pinMode(pinCw, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() > 0) {
    char inByte = Serial.read();
    switch (inByte) {
      case '0':
        digitalWrite(pinCw, LOW);
        digitalWrite(pinClk, HIGH);
        delayMicroseconds(delayUs);
        digitalWrite(pinClk, LOW);
        delayMicroseconds(delayUs);
        break;
      case '1':
        digitalWrite(pinCw, HIGH);
        digitalWrite(pinClk, HIGH);
        delayMicroseconds(delayUs);
        digitalWrite(pinClk, LOW);
        delayMicroseconds(delayUs);
        break;
      default:
        break;
    }
  }
}
