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

    escreva("Insira o dia que você nasceu.\n")
    leia(dia)
    escreva("Insira o mês que você nasceu.\n")
    leia(mes)
    escreva("Insira o ano que você nasceu.\n")
    leia(ano)

    tempo = ((cal.ano_atual() - ano) * 365) + ((cal.mes_atual() - mes) * 30) + (cal.dia_mes_atual() - dia)

    anos = tempo / 365
    meses = anos * 30
    semanas = tempo / 7
    dias = tempo

    escreva("\nVocê viveu, aproximadamente:   "+dias+" dias;")
    escreva("\nO que é equivalente a:         "+semanas+" semanas;")
    escreva("\nOu também:                     "+meses+" meses;")
    escreva("\nOu também:                     "+anos+" anos.\n")
  }
}
