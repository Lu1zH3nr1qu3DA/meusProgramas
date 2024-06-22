programa {
  funcao inicio() {

    real nota1, nota2, nota3
    real media
    cadeia nomeAluno
    caracter resposta
    cadeia enter

//  Média
//    Entrada de dados.
    escreva("\nInsira a 1ª nota do aluno.\n")
    leia(nota1)
    escreva("\nInsira a 2ª nota do aluno.\n")
    leia(nota2)
    escreva("\nInsira a 3ª nota do aluno.\n")
    leia(nota3)
    escreva("\nInsira o nome do aluno.\n")
    leia(nomeAluno)

//    Processamento.
    media = (nota1 + nota2 + nota3) / 3


//  Menu
    limpa()
    escreva("\nEscolha uma opção.\n")
    escreva("\n1 - Informar aluno e médias\n")
    escreva("\n2 - Exibir média\n")
    escreva("\n3 - Sair\n")

    leia(resposta)

    se(resposta == '1') {
       limpa()

       escreva("\nA média das 3 notas de "+nomeAluno+" foi "+media+".\n")
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

      escreva("\nEscolha uma opção.\n")
      escreva("\n1 - Informar aluno e médias\n")
      escreva("\n2 - Exibir média\n")
      escreva("\n3 - Sair\n")
    
      leia(resposta)

      se(resposta == '1') {
        limpa()

        escreva("\nA média das 3 notas de "+nomeAluno+" foi "+media+".\n")

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