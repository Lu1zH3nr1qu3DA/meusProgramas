programa {
//    Vari�veis.
    cadeia nome = ""
    inteiro faltas = 0
    real nota1 = 0.0
    real nota2 = 0.0
    real nota3 = 0.0
    real nota4 = 0.0
    real media = 0.0
    cadeia situacao = ""
    cadeia resposta = ""

  funcao inicio() {

//    Entrada de dados.
    escreva("Insira o nome do aluno.\n")
    leia(nome)
    limpa()
    escreva("Insira o n�mero de faltas.\n")
    leia(faltas)
    limpa()
    escreva("Insira a nota do 1� Bimestre.\n")
    leia(nota1)
    limpa()
    escreva("Insira a nota do 2� Bimestre.\n")
    leia(nota2)
    limpa()
    escreva("Insira a nota do 3� Bimestre.\n")
    leia(nota3)
    limpa()
    escreva("Insira a nota do 4� Bimestre.\n")
    leia(nota4)

//    Processamento.
    media = (nota1 + nota2 + nota3 + nota4) / 4

    se(faltas > 12) {
      situacao = "Reprovado pelo n�mero de faltas."
    }
    senao {
      se(media >= 7) {
        situacao = "Aprovado."
      }
      senao {
        se(media > 5 e media < 7) {
          situacao = "Exame."
        }
        senao {
          se(media < 5) {
            situacao = "Reprovado."
          }
        }
      }
    }

//    Sa�das de dados.
    enquanto(resposta != "4") {
      limpa()

      escreva("Escolha uma op��o.")
      escreva("\n\n1 - Exibir Notas e Faltas")
      escreva("\n2 - Exibir M�dia")
      escreva("\n3 - Exibir Situa��o")
      escreva("\n4 - Sair\n\n")

      leia(resposta)

      se(resposta == "1") {
        f1()
      }
      senao {
        se(resposta == "2") {
          f2()
        }
        senao {
          se (resposta == "3") {
          f3()
          }
        }
      }
    }
  }






  funcao f1() {
          limpa()

          escreva("Nome: "+nome)
          escreva("\n\nFaltas:  "+faltas)
          escreva("\n\nNotas:")
          escreva("\n1� Bimestre:  "+nota1+"\n")
          escreva("2� Bimestre:  "+nota2+"\n")
          escreva("3� Bimestre:  "+nota3+"\n")
          escreva("4� Bimestre:  "+nota4)

          escreva("\n\nPressione ENTER para Continuar.")
          leia(resposta)
  }
  funcao f2() {
    limpa()

    escreva("Nome: "+nome)
    escreva("\nM�dia: "+media)
      
    escreva("\n\nPressione ENTER para Continuar.")
    leia(resposta)
  }
  funcao f3() {
    limpa()

    escreva("Nome: "+nome)
    escreva("\nSitua��o: "+situacao)
        
    escreva("\n\nPressione ENTER para Continuar.")
    leia(resposta)
  }
}