// C++ code

//SEMÁFORO - TESTE


//Constantes e Variáveis
//Software <-> Hardware
const int verde1 = 13;
const int amarelo1 = 12;
const int vermelho1 = 11;
const int verde2 = 10;
const int amarelo2 = 9;
const int vermelho2 = 8;
//SETUP
void setup()
{
  //Energia (SAÍDA)
  pinMode(verde1, OUTPUT);
  pinMode(amarelo1, OUTPUT);
  pinMode(vermelho1, OUTPUT);
  //Estado padrão (DESL.)
  digitalWrite(verde1, LOW);
  digitalWrite(amarelo1, LOW);
  digitalWrite(vermelho1, LOW);
}

void loop()
{
  //FRAME 1 - SEMÁFORO 1 (VERDE) E SEMÁFORO 2 (VERMELHO)
  //Semáforo 1 (Verde)
  digitalWrite(verde1, HIGH);
  digitalWrite(amarelo1, LOW);
  digitalWrite(vermelho1, LOW);
  //Semáforo 2 (Vermelho)
  digitalWrite(verde2, LOW);
  digitalWrite(amarelo2, LOW);
  digitalWrite(vermelho2, HIGH);
  delay(2000);
  
  //FRAME 2 - SEMÁFORO 1 (AMARELO) E SEMÁFORO 2 (VERMELHO)
  //Semáforo 1 (Amarelo)
  digitalWrite(verde1, LOW);
  digitalWrite(amarelo1, HIGH);
  digitalWrite(vermelho1, LOW);
  //Semáforo 2 (Vermelho)
  digitalWrite(verde2, LOW);
  digitalWrite(amarelo2, LOW);
  digitalWrite(vermelho2, HIGH);
  delay(2000);
  
  //FRAME 3 - SEMÁFORO 1 (VERMELHO) E SEMÁFORO 2 (VERDE)
  //Semáforo 1 (Vermelho)
  digitalWrite(verde1, LOW);
  digitalWrite(amarelo1, LOW);
  digitalWrite(vermelho1, HIGH);
  //Semáforo 2 (Verde)
  digitalWrite(verde2, HIGH);
  digitalWrite(amarelo2, LOW);
  digitalWrite(vermelho2, LOW);
  delay(2000);
  
  //FRAME 4 - SEMÁFORO 1 (VERMELHO) E SEMÁFORO 2 (AMARELO)
  //Semáforo 1 (Vermelho)
  digitalWrite(verde1, LOW);
  digitalWrite(amarelo1, LOW);
  digitalWrite(vermelho1, HIGH);
  //Semáforo 2 (Amarelo)
  digitalWrite(verde2, LOW);
  digitalWrite(amarelo2, HIGH);
  digitalWrite(vermelho2, LOW);
  delay(2000);
}