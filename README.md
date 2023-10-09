### **Teste Back-end C#**
Criação de API RESTful para manutenção de tabelas Grupo e Clientes através do cadastro de Gerente.

#### **Tecnologias**
C# .NET 6

Postgresql 14

#### **Autenticação**
JWT Bearer

#### **EndPoints**
O campo id é do Gerente para verificação do nível
#### **Autenticação:**
`   `Método: Post

`         `/api/auth
#### **Grupo:**
#### `	`**Criar:**
`		`Método: POST

`                `/api/Gerente/{id}/grupo
#### `	`**Editar:**
`		`Método: PUT

`                `/api/Gerente/{id}/grupo/{idGrupo}
#### `	`**Excluir:**
`		`Método: DELETE

`                `/api/Gerente/{id}/grupo/{idGrupo}
#### **Cliente:**
#### `	`**Adicionar:**
`		`Método: POST

`                `/api/Gerente/{id}/cliente
#### `	`**Remover:**
`		`Método: DELETE

`                `/api/Gerente/{id}/cliente/{idCliente}


