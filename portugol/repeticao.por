programa {
  funcao inicio() {

    real nota1, nota2, nota3
    real media
    cadeia nomeAluno
    caracter resposta
    cadeia enter

//  M�dia
//    Entrada de dados.
    escreva("\nInsira a 1� nota do aluno.\n")
    leia(nota1)
    escreva("\nInsira a 2� nota do aluno.\n")
    leia(nota2)
    escreva("\nInsira a 3� nota do aluno.\n")
    leia(nota3)
    escreva("\nInsira o nome do aluno.\n")
    leia(nomeAluno)

//    Processamento.
    media = (nota1 + nota2 + nota3) / 3


//  Menu
    limpa()
    escreva("\nEscolha uma op��o.\n")
    escreva("\n1 - Informar aluno e m�dias\n")
    escreva("\n2 - Exibir m�dia\n")
    escreva("\n3 - Sair\n")

    leia(resposta)

    se(resposta == '1') {
       limpa()

       escreva("\nA m�dia das 3 notas de "+nomeAluno+" foi "+media+".\n")
       escreva("\nPressione Enter para continuar.")
       leia(enter)
    }
    senao {
      se(resposta == '2') {
        limpa()

        escreva("Medias: "+media)
        escreva("\nPressione Enter para acontinuar.")
        leia(enter)
      }
    }
    enquanto(resposta != '3') {
      limpa()

      escreva("\nEscolha uma op��o.\n")
      escreva("\n1 - Informar aluno e m�dias\n")
      escreva("\n2 - Exibir m�dia\n")
      escreva("\n3 - Sair\n")
    
      leia(resposta)

      se(resposta == '1') {
        limpa()

        escreva("\nA m�dia das 3 notas de "+nomeAluno+" foi "+media+".\n")

        escreva("\nPressione Enter para continuar.")
        leia(enter)
      }
      senao {
        se(resposta == '2') {
          limpa()

          escreva("Medias: "+media)
          
          escreva("\nPressione Enter para acontinuar.")
          leia(enter)
        }
      }
    }
  }
}