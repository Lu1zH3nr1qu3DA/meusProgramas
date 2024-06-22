programa {
  
  inclua biblioteca Matematica --> m

  funcao inicio() {
  real f = 0.0
  real c = 0.0

  escreva("Calculadora de Temperatura - Fahrenheit para Celsius")
  escreva("\n\nInsira uma temperatura em Fahrenheit.\n")
  leia(f)

  c = 5 * (f - 32) / 9
  c = m.arredondar(c, 0)

  limpa()

  escreva("A temperatura "+f+"°F é equivalente a "+c+"°C.\n\n")
  }
}