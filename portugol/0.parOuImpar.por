//	0 - Fa�a um algoritmo que determine se um n�mero � Par ou ͍mpar.
programa {

	funcao inicio() {	

//		Vari�veis
//			Entrada
		inteiro numero 
//			Processamento
		inteiro divisao, soma

//			Processamento
		escreva("Digite um n�mero.\n")	//Informa o usu�rio para que digite o valor da vari�vel numero.
		leia(numero)	//L� o valor digitado pelo usu�rio e d� o valor para a vari�vel numero.
		divisao = numero % 2	//Divide o valor da vari�vel n�mero por 2.
		se(numero == 0) {
			escreva("O n�mero � Par.")
		}
		senao {
			escreva("O n�mero � �mpar.")
		}
	}
}