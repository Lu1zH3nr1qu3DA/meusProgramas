//6 - Fa�a um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.
programa
{
	
	funcao inicio()
	{
		real valor
		real porCento
    real cincoPorCento
		real resultado


		escreva("Insira um valor.\n")
		leia(valor)
		porCento = valor / 100
    cincoPorCento = porCento * 5
		resultado = valor - cincoPorCento
		
		escreva("O reajuste de 5% desse valor �:\n"+resultado+"\n")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 175; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */