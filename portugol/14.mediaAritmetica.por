programa {
  funcao inicio() {

//  Vari�veis
    cadeia nome
    real nota1, nota2
    real media
    cadeia situacao
    inteiro faltas
    cadeia resposta
    cadeia enter

//  M�dia
//    Entrada de dados.
    escreva("\nInsira o nome do aluno.\n")
    leia(nome)
    limpa()
    escreva("\nInsira o n�mero de faltas.\n")
    leia(faltas)
    limpa()
    escreva("\nInsira a 1� nota do aluno.\n")
    leia(nota1)
    limpa()
    escreva("\nInsira a 2� nota do aluno.\n")
    leia(nota2)

//    Processamento.
    media = (nota1 + nota2) / 2

    se(media >= 7) {
      situacao = "Aprovado."
    }
    senao se(media > 5 e media < 7) {
        situacao = "Exame."
    }
    senao se(media < 5) {
        situacao = "Reprovado."
    }
    
    se(faltas > 12) {
      situacao = "Reprovado pelo n�mero de faltas."
    }

//  Menu

    enquanto(resposta != "4") {
      limpa()

      escreva("\nEscolha uma op��o.\n")
      escreva("\n1 - Informar Disciplina e Notas\n")
      escreva("\n2 - Calcular a M�dia\n")
      escreva("\n3 - Calcular a Situa��o\n")
      escreva("\n4 - Sair\n")

      leia(resposta)

      se(resposta == "1") {
        limpa()

        escreva("\nNome: "+nome+"\n\nNotas:\n"+nota1+"\n"+nota2)

        escreva("\nPressione ENTER para Continuar.")
        leia(enter)
      }
      senao se(resposta == "2") {
          limpa()

          escreva("\nNome: "+nome+"\n\nMedia: "+media)
          
          escreva("\nPressione ENTER para Continuar.")
          leia(enter)
      }
      senao se (resposta == "3") {
        limpa()

        escreva("Nome: "+nome+"\n\nSitua��o: "+situacao)
        
        escreva("\nPressione ENTER para Continuar.")
        leia(enter)
      }
    }
  }
}