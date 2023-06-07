# Controller Tarefa  

POST > Cad User  
https://localhost:44399/api/usuario

{
  "nome": "",
  "email": "",
  "senha": "Ta12346!",
  "confirmacaosenha": "Ta12346!"
}

POST > Login User
https://localhost:44399/api/usuario/login

{
  "email": "email",
  "senha": "senha"
}

POST > Cad Tarefas
https://localhost:44399/api/tarefa/sincronizar

[{
  "IdTarefaApi": 0,
  "IdTarefaApp": 1,
  "Titulo": "Tarefa de exemplo",
  "DataHora": "2023-06-06T10:00:00",
  "Local": "Sala de reuniões",
  "Descricao": "Realizar uma reunião de equipe",
  "Tipo": "Reunião",
  "Concluido": false,
  "Excluido": false,
  "Criado": "2023-06-06T08:00:00",
  "Atualizado": "2023-06-06T09:30:00",
  "UsuarioId": "18f1cab2-b785-4328-a3bb-ec5026c94701",
  "Usuario": null
  }]


GET > Obter Tarefas 
https://localhost:44399/api/tarefa/restaurar
 


 







}