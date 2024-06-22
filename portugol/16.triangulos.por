programa {
  funcao inicio() {
  	real a = 0.0
  	real b = 0.0
  	real c = 0.0

    escreva("Insira o valor do lado A:  ")
  	leia(a)
    escreva("Insira o valor do lado B:  ")
    leia(b)
    escreva("Insira o valor do lado C:  ")
    leia(c)

    escreva(tipoTri(a, b, c))
  }





  funcao cadeia tipoTri(real a, real b, real c) {
    se(a != b e b != c) {
      retorne "Escaleno"
    }
    senao {
      se(a == b e b == c) {
        retorne "Equilátero"
      }
      senao {
        retorne "Isóceles"
      }
    }
  }
}
