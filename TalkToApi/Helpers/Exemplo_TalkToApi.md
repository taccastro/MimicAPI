API TALK TO API 

Para executar no swagger trocar url para > https://localhost:44327/index.html

POST > LOGIN
https://localhost:44327/api/usuario/login
{
    "email":"JOSE@GMAIL.COM",
    "senha":"123456aA!"
}

GET > Obter Todos
https://localhost:44327/api/usuario

Obter com links colocar no accept do postman : application/vnd.talkto.hateoas+json
application/vnd.talkto.hateoas+json

GET > Obter 1
https://localhost:44327/api/usuario/42bdc651-91b4-4934-bbb9-64d9e7a8a36e



#Mensagens

GET > Obter Mensagem 
https://localhost:44327/api/mensagem/42bdc651-91b4-4934-bbb9-64d9e7a8a36e/abc12ade-47ca-4d65-8a10-33e577bf57d7

POST > Cadastrar Mensagem 
https://localhost:44327/api/mensagem/
{
   "deId": "42bdc651-91b4-4934-bbb9-64d9e7a8a36e",
   "paraId": "abc12ade-47ca-4d65-8a10-33e577bf57d7",
   "texto": "AVANTI PALESTRA ! OS PORKO É LOKO",
   "criado": "2023-06-16T18:19:15.725Z"
}

PATH > Atualizar Mensagem 
https://localhost:44327/api/mensagem/6
[
    { 
     "op": "replace",
    "path": "texto",
    "value": "ATUALIZANDO MSG"
    }
]

exemplo 2:
    { 
     "op": "add",
    "path": "excluido",
    "value": true
    }






















POST > Cadastro
https://localhost:44327/api/usuario/
{
"nome":"TalkToApi",
"email":"tiagocastro@teste.com.br",
"senha":"Ta12346!",
"confirmacaosenha":"Ta12346!"
}








}