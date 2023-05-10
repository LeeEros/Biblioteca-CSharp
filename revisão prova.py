pessoas = [
    {'nome':'Maria','idade':25,'salario':3000},
    {'nome':'João','idade':32,'salario':5000},
    {'nome':'Ana','idade':20,'salario':2000},
    {'nome':'Pedro','idade':40,'salario':8000},
    {'nome':'Mariana','idade':27,'salario':4000}
]

def media_salario(pessoas):
    s=0
    for dados in pessoas:
        s= dados['salario']+s
        m=s/len(pessoas)
    print(f'Média:{m}')

print(media_salario(pessoas))

def mais_velho(pessoas):
    maior=0
    velho=[]
    for dados in pessoas:
        if dados['idade']>maior:
            maior=dados['idade']
            velho = dados['nome']
    print(f'A pessoa mais velha é {velho} com {maior} anos')

print(mais_velho(pessoas))