programa {

  inclua biblioteca Matematica --> matematica

  funcao inicio() {

    cadeia nomeProprietario = ""
    real valorTerreno = 0.0
    inteiro tamanhoTerreno = 0
    real valorEntrada = 0.0
    inteiro numeroParcelas = 0
    real valorParcela = 0.0
    real valorParcelaArredondado = 0.0
    real valorMetroQuadrado = 0.0
    real valorMetroQuadradoArredondado = 0.0


    escreva("Calculadora de Financiamento\n\n")
    escreva("Insira o nome do Proprietário.\n")
    leia(nomeProprietario)
    limpa()
    escreva("Insira o valor do terreno.\n")
    leia(valorTerreno)
    limpa()
    escreva("Insira o tamanho do terreno (m²).\n")
    leia(tamanhoTerreno)
    limpa()
    escreva("Insira o valor da entrada.\n")
    leia(valorEntrada)
    limpa()
    escreva("Insira o número de parcelas.\n")
    leia(numeroParcelas)
    limpa()


    valorParcela = (valorTerreno - valorEntrada) / numeroParcelas
    valorParcelaArredondado = matematica.arredondar(valorParcela, 2)
    
    valorMetroQuadrado = valorTerreno / tamanhoTerreno
    valorMetroQuadradoArredondado = matematica.arredondar(valorMetroQuadrado, 2)


    inteiro numero = 1
    enquanto(numero <= numeroParcelas) {
      escreva("Parcela "+numero+" - Valor: R$"+valorParcelaArredondado+"\n")
      numero = numero + 1
    }
    escreva("\nValor real:    R$"+valorParcela+"\n")
    escreva("\nValor / m²:    R$"+valorMetroQuadradoArredondado)
    escreva("\nValor / m² (real):    R$"+valorMetroQuadrado)
  }
}