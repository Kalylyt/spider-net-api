# 🕸️ SpiderNet API

Sistema distribuído de registro de missões do Homem-Aranha desenvolvido em **.NET 10**.

---

## 🧠 Contexto

Após eventos do multiverso, o Homem-Aranha precisa registrar suas missões para controle e consulta.

A **SpiderNet API** permite que sistemas externos registrem e consultem missões do herói.

---

## 🚀 Tecnologias utilizadas

* C#
* .NET 10
* ASP.NET Web API
* Swagger

---

## 📦 Funcionalidades

✔ Registrar novas missões (POST)
✔ Consultar todas as missões (GET)
✔ Validação de nível de perigo (1 a 10)

---

## 📁 Estrutura do Projeto

```
SpiderNetApi/
 ├── Controllers/
 │    └── MissoesController.cs
 ├── Models/
 │    └── MissaoAranha.cs
 ├── Program.cs
```

---

## 🔗 Endpoints

### 📥 GET - Listar missões

```
GET /api/missoes
```

---

### 📤 POST - Criar missão

```
POST /api/missoes
```

### Exemplo de JSON:

```json
{
  "id": 1,
  "vilaoEnfrentado": "Duende Verde",
  "localizacao": "Ponte de Queensboro",
  "nivelPerigo": 9,
  "resolvido": true
}
```

---

## 🧪 Testes

A API foi testada utilizando:

* Swagger

---

## 📸 Evidências

* POST funcionando
está nas pastas como imagens
* GET retornando dados
está nas pastas como imagens
---

## ⚠️ Observações

* Os dados são armazenados em memória
* Ao reiniciar a aplicação, os dados são perdidos

---

## 💡 Futuras melhorias

* Integração com banco de dados
* Autenticação
* Filtros de busca

---

## 🕷️ Frase motivacional

> "Com grandes poderes vêm grandes responsabilidades."
> — Peter Parker

---

## 👨‍💻 Autor

Desenvolvido por Kalyl Cordeiro Lopes
