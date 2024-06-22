programa {
  funcao inicio() {
    inteiro n1 = 0
    inteiro n2 = 0
    inteiro r = 0

    enquanto(n1 <= 10) {
      enquanto(n2 <= 9) {
        r = n1 * n2
        escreva(""+n1+" x "+n2+" = "+r+"\n")
        n2 = n2 + 1
      }
      r = n1 * n2
      escreva(""+n1+" x "+n2+" = "+r+"\n")
      n1 = n1 + 1
      n2 = 0
    }
  }
}