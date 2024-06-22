// 10 - Faça um algoritmo que leia três notas obtidas por um aluno, e imprima na tela a média das notas.
programa {

  funcao inicio() {

    real nota1, nota2, nota3
    real media
    cadeia nomeAluno

//  Entrada de dados.
    escreva("\nInsira a 1ª nota do aluno.\n")
    leia(nota1)
    escreva("\nInsira a 2ª nota do aluno.\n")
    leia(nota2)
    escreva("\nInsira a 3ª nota do aluno.\n")
    leia(nota3)
    escreva("\nInsira o nome do aluno.\n")
    leia(nomeAluno)

//  Processamento.
    media = (nota1 + nota2 + nota3) / 3

//  Saída de dados.
    escreva("\nA média das 3 notas de "+nomeAluno+" foi "+media+".\n")
  
  }

}