const int buttonPin = 2; // Pin connected to the push button
const int ledPin = 13;   // Pin connected to the LED


const char* morseCode[] = {"-.", "..", "...", ".-", "-.","-"}; 

void setup() {
  pinMode(buttonPin, INPUT); // Set the push button pin as input
  pinMode(ledPin, OUTPUT);   // Set the LED pin as output
}

void loop() {
  if (digitalRead(buttonPin) == HIGH) { // Check if the push button is pressed
    blinkName(); // Start blinking the name in Morse code
  }
}

void blinkName() {
  for (int i = 0; i < sizeof(morseCode) / sizeof(morseCode[0]); i++) {
    const char* letter = morseCode[i];
    for (int j = 0; letter[j] != '\0'; j++) {
      if (letter[j] == '.') {
        digitalWrite(ledPin, HIGH); // Turn on the LED for dot
        delay(250); // Dot duration
        digitalWrite(ledPin, LOW); // Turn off the LED
        delay(250); // Inter-element gap
      } else if (letter[j] == '-') {
        digitalWrite(ledPin, HIGH); // Turn on the LED for dash
        delay(750); // Dash duration
        digitalWrite(ledPin, LOW); // Turn off the LED
        delay(250); // Inter-element gap
      }
    }
    delay(500); // Inter-letter gap
  }
  delay(1000);
}
