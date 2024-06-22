programa {
  funcao inicio() {
    inteiro n1 = 0
    inteiro n2 = 0
    inteiro r = 0

    escreva("Insira um número para exibir sua tabuada.\n")
    leia(n1)

    enquanto(n2 <= 10) {
      r = n1 * n2
      escreva(""+n1+" x "+n2+" = "+r+"\n")
      n2 = n2 + 1
    }
  }
}
