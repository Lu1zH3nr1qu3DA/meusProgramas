programa {
//    Variáveis.
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
    escreva("Insira o número de faltas.\n")
    leia(faltas)
    limpa()
    escreva("Insira a nota do 1º Bimestre.\n")
    leia(nota1)
    limpa()
    escreva("Insira a nota do 2º Bimestre.\n")
    leia(nota2)
    limpa()
    escreva("Insira a nota do 3º Bimestre.\n")
    leia(nota3)
    limpa()
    escreva("Insira a nota do 4º Bimestre.\n")
    leia(nota4)

//    Processamento.
    media = (nota1 + nota2 + nota3 + nota4) / 4

    se(faltas > 12) {
      situacao = "Reprovado pelo número de faltas."
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

//    Saídas de dados.
    enquanto(resposta != "4") {
      limpa()

      escreva("Escolha uma opção.")
      escreva("\n\n1 - Exibir Notas e Faltas")
      escreva("\n2 - Exibir Média")
      escreva("\n3 - Exibir Situação")
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
          escreva("\n1º Bimestre:  "+nota1+"\n")
          escreva("2º Bimestre:  "+nota2+"\n")
          escreva("3º Bimestre:  "+nota3+"\n")
          escreva("4º Bimestre:  "+nota4)

          escreva("\n\nPressione ENTER para Continuar.")
          leia(resposta)
  }
  funcao f2() {
    limpa()

    escreva("Nome: "+nome)
    escreva("\nMédia: "+media)
      
    escreva("\n\nPressione ENTER para Continuar.")
    leia(resposta)
  }
  funcao f3() {
    limpa()

    escreva("Nome: "+nome)
    escreva("\nSituação: "+situacao)
        
    escreva("\n\nPressione ENTER para Continuar.")
    leia(resposta)
  }
}