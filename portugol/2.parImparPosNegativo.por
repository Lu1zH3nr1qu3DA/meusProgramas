//2 - Faça um algoritmo para receber um número qualquer e imprimir na tela se o número é par ou ímpar, positivo ou negativo.
programa {
	funcao inicio() {
		inteiro numero
		inteiro divisao
		inteiro resultado
		inteiro soma
		
		escreva("Digite um número.\n")
		leia(numero)
		divisao = numero / 2
		soma = divisao + divisao	
		se(soma == numero) {
			escreva("O número é par.\n")
		} senao {
			escreva("O número é ímpar.\n")
		}
		se(numero > 0) {
			escreva("O número é positivo.\n")
		} senao {
			escreva("O número é negativo.\n")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 536; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */