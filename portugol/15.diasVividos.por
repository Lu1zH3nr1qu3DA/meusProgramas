programa {
  
  inclua biblioteca Calendario --> cal
  
  funcao inicio() {
    inteiro ano = 0
    inteiro mes = 0
    inteiro dia = 0
    inteiro anos = 0
    inteiro meses = 0
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
    meses = cal.mes_atual()
    dias = cal.dia_mes_atual()

    escreva("\nVoc� viveu, aproximadamente:   "+anos+" anos, "+meses+" meses, e "+dias+" dias.\n\n")
  }
}
