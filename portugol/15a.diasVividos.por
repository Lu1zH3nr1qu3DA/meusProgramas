programa {
  
  inclua biblioteca Calendario --> cal
  
  funcao inicio() {
    inteiro ano = 0
    inteiro mes = 0
    inteiro dia = 0
    inteiro anos = 0
    inteiro meses = 0
    inteiro semanas = 0
    inteiro dias = 0
    inteiro tempo = 0

    escreva("Insira o dia que voc� nasceu.\n")
    leia(dia)
    escreva("Insira o m�s que voc� nasceu.\n")
    leia(mes)
    escreva("Insira o ano que voc� nasceu.\n")
    leia(ano)

    tempo = ((cal.ano_atual() - ano) * 365) + ((cal.mes_atual() - mes) * 30) + (cal.dia_mes_atual() - dia)

    anos = tempo / 365
    meses = anos * 30
    semanas = tempo / 7
    dias = tempo

    escreva("\nVoc� viveu, aproximadamente:   "+dias+" dias;")
    escreva("\nO que � equivalente a:         "+semanas+" semanas;")
    escreva("\nOu tamb�m:                     "+meses+" meses;")
    escreva("\nOu tamb�m:                     "+anos+" anos.\n")
  }
}
