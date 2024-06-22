//5 - Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse 
//usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.293,20).
programa
{
	
	funcao inicio()
	{
		real salarioMinimo = 1293.20
		real salario
		real resultado

		escreva("Insira seu sal�rio.\n")
		leia(salario)
		resultado = salario / salarioMinimo
		escreva("Voc� ganha "+resultado+" Sal�rios m��nimos.\n")
		
	}
}