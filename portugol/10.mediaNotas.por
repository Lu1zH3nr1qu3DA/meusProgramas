//�10 - Fa�a um algoritmo que leia tr�s notas obtidas por um aluno, e imprima na tela a m�dia das notas.
programa {

  funcao inicio() {

    real nota1, nota2, nota3
    real media
    cadeia nomeAluno

//  Entrada de dados.
    escreva("\nInsira a 1� nota do aluno.\n")
    leia(nota1)
    escreva("\nInsira a 2� nota do aluno.\n")
    leia(nota2)
    escreva("\nInsira a 3� nota do aluno.\n")
    leia(nota3)
    escreva("\nInsira o nome do aluno.\n")
    leia(nomeAluno)

//  Processamento.
    media = (nota1 + nota2 + nota3) / 3

//  Sa�da de dados.
    escreva("\nA m�dia das 3 notas de "+nomeAluno+" foi "+media+".\n")
  
  }

}