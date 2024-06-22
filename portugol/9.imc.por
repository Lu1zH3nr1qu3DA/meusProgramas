//9 - Fa�a um algoritmo que calcule o IMC (�ndice de Massa Corporal) de uma pessoa, leia o seu peso e sua altura e imprima na tela sua condi��o�
//de acordo com a tabela abaixo:


//  F�rmula do IMC = peso / (altura) �

//            Tabela Condi��es IMC
//  Abaixo de 18,5�   ��|�Abaixo do peso����������
//  Entre 18,6 e 24,9�  |�Peso ideal (parab�ns)��
//  Entre 25,0 e 29,9�  |�Levemente acima do peso
//  Entre 30,0 e 34,9   |�Obesidade grau I�
//  Entre 35,0 e 39,9�  |�Obesidade grau II (severa)
//  Maior ou igual a 40�|�Obesidade grau III (m�rbida)

programa {

  funcao inicio() {
    real peso
    real altura
    real imc
    cadeia teclado

    escreva("Calculadora IMC\n")
    escreva("\nInsira seu peso.\n")
    leia(peso)
    escreva("\nInsira sua altura.\n")
    leia(altura)

    imc = peso / (altura * altura)
    escreva("\n"+imc)

    se(imc < 18.5) {
       escreva("\n\nVoc� est� abaixo do peso ideal.\n")
    }
    senao {
      se(18.5 <= imc e imc < 25.0) {
        escreva("\n\nVoc� est� no peso ideal.\n")
      }
      senao {
        se(25.0 <= imc e imc < 30.0) {
          escreva("\n\nVoc� est� acima do peso ideal.\n")
        }
        senao {
          se(30.0 <= imc e imc < 35.0) {
            escreva("\n\nVoc� est� obeso (grau I).\n")
          }
          senao {
            se(35.0 <= imc e imc < 40.0) {
              escreva("\n\nVoc� est� obeso (grau II - severa).\n")
            }
            senao {
              se(imc >= 40.0) {
                escreva("\n\nVoc� est� obeso (grau III - m�rbida).\n")
              }
            }
          }
        }
      }
    }

    escreva("\n\nO IMC ideal � entre 18,5 e 25,0.\n")
  }
}
