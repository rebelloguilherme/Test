# Test Paradigma

Repositório com soluções para os desafios técnicos propostos.

## Estrutura do Projeto

```
Test/
├── Test1/
│   └── Tarefa1.sql        # Solução SQL
└── Test2/
    └── Tarefa2/           # Solução C# (.NET 8)
        ├── Program.cs
        └── ArvoreBinariaMax.cs
```

---

## Tarefa 1 - SQL

Arquivo: `Test1/Tarefa1.sql`

### Descrição

Query SQL para encontrar o funcionário com o maior salário em cada departamento.

### Modelo de Dados

O script cria duas tabelas:

- **Pessoa**: armazena funcionários com `Id`, `Nome`, `Salario` e `DeptId`
- **Departamento**: armazena departamentos com `Id` e `Nome`

### Solução

Utiliza `ROW_NUMBER()` com `PARTITION BY` para rankear os salários dentro de cada departamento, retornando apenas o primeiro colocado de cada grupo.

```sql
SELECT Departamento, Pessoa, Salario
FROM (
    SELECT
        d.Nome AS Departamento,
        p.Nome AS Pessoa,
        p.Salario,
        ROW_NUMBER() OVER (
            PARTITION BY p.DeptId
            ORDER BY p.Salario DESC
        ) AS numeroLinha
    FROM Pessoa p
    INNER JOIN Departamento d ON p.DeptId = d.Id
) AS Ranking
WHERE NumeroLinha = 1;
```

---

## Tarefa 2 - Árvore Binária Máxima

Diretório: `Test2/Tarefa2/`

### Descrição

Implementação em C# de uma árvore binária onde a raiz é o maior elemento do array de entrada. Os elementos à esquerda da raiz (no array original) compõem os galhos da esquerda, e os à direita compõem os galhos da direita.

### Requisitos

- .NET 8.0

### Como Executar

```bash
cd Test2/Tarefa2
dotnet run
```

### Estrutura

**ArvoreBinariaMax.cs**

Classe principal que implementa a lógica da árvore:

- `Raiz`: maior valor do array
- `GalhosEsquerda`: elementos que estavam antes da raiz no array original, ordenados de forma decrescente
- `GalhosDireita`: elementos que estavam depois da raiz no array original, ordenados de forma decrescente

**Program.cs**

Contém exemplos de uso com três cenários diferentes:

```
Cenário 1: [3, 2, 1, 6, 0, 5]
Cenário 2: [7, 5, 13, 9, 1, 6, 4]
Cenário 3: [7, 5, 8, 13, 9, 29, 100, 1, 6, 4, 99, 50]
```

### Exemplo de Saída

```
Cenário 1
Array de entrada: [3, 2, 1, 6, 0, 5]
Raiz: 6
Galhos da esquerda: 3, 2, 1
Galhos da direita: 5, 0
```

### Algoritmo

1. Encontra o índice do maior elemento no array (esse será a raiz)
2. Percorre o array separando os elementos:
   - Elementos antes do índice da raiz vão para `GalhosEsquerda`
   - Elementos depois do índice da raiz vão para `GalhosDireita`
3. Ordena ambas as listas em ordem decrescente
