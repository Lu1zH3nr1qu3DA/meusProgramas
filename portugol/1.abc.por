//1 - Fa�a um algoritmo que leia os valores de A, B e C,�e em seguida imprima na tela�a soma entre A e B. Depois mostre se a soma � menor que C.
programa
{
	
	funcao inicio()
	{
		inteiro valorA = 0
		inteiro valorB = 0
		inteiro valorC = 0
		inteiro somaAB = 0

		escreva("\nInsira o valor A.\n")
		leia(valorA)
		escreva("\nInsira o valor B.\n")
		leia(valorB)
		escreva("\nInsira o valor C.\n")
		leia(valorC)
		somaAB = valorA + valorB
		escreva("\n\nA + B = "+somaAB+"\n")
		se(somaAB < valorC) {
			escreva("\nA soma de A e B � menor que C.\n"+somaAB+" < "+valorC+"\n")
		} senao {
			escreva("\nA soma de A e B n�o � menor que C."+somaAB+" > "+valorC+"\n")
		}
	}
}