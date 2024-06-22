//12 - Desenvolver um algoritmo que simule o controle de um caixa, podendo lan�ar valores,
//tanto � cr�dito quanto � d�bito e com a op��o de saldo de valores, o algoritmo deve 
//usar um menu igual a op��o abaixo:
//
//Sistema de Controle de Caixa
//1 - Cr�dito
//2 - D�bito
//3 - Saldo
//4 - Sair

programa {

  funcao inicio() {
    
    real credito = 0.0
    real debito = 0.0
    real valor = 0.0
    real saldo = 0.0
    cadeia resposta = ""

    escreva("Sistema de Controle de Caixa\n")
    escreva("\nPressione ENTER para Continuar.\n")
    escreva("\"s\" para Sair.\n")
    leia(resposta)
    
    enquanto(resposta != "s") {
      limpa()
      escreva("Sistema de Controle de Caixa\n")
      escreva("\nDigite uma op��o.")
      escreva("\n1 - Cr�dito\n")
      escreva("2 - D�bito\n")
      escreva("3 - Saldo\n")
      escreva("\"s\" para Sair.\n")
      leia(resposta)
      limpa()

      se(resposta == "1") {
        escreva("\nInsira o valor de cr�dito.\nR$")
        leia(valor)
        credito = credito + valor
      }
      senao se(resposta == "2") {
        escreva("\nInsira o valor de d�bito.\nR$")
        leia(valor)
        debito = debito + valor
      }
      senao se(resposta == "3") {
        saldo = credito - debito
        escreva("\nVoc� tem um saldo de R$"+saldo+".\n")
        escreva("\nPessione ENTER para Continuar.\n")
        leia(resposta)
      }
    }
  }
}
