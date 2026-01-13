-- Criação das tabelas
CREATE TABLE Pessoa (
    Id INT IDENTITY (1, 1),
    Nome VARCHAR(100),
    Salario VARCHAR(255),
    DeptId INT
);

CREATE TABLE Departamento (
    Id INT IDENTITY (1, 1),
    Nome VARCHAR(100)
);

-- Inserção de dados
INSERT INTO Departamento (Nome) VALUES ('TI');

INSERT INTO Departamento (Nome) VALUES ('Vendas');

INSERT INTO Pessoa (Nome, Salario, DeptId) VALUES ('Joe', 70000, 1);

INSERT INTO Pessoa (Nome, Salario, DeptId) VALUES ('Henry', 80000, 2);

INSERT INTO Pessoa (Nome, Salario, DeptId) VALUES ('Sam', 60000, 2);

INSERT INTO Pessoa (Nome, Salario, DeptId) VALUES ('Max', 90000, 1);

-- (Resposta) Query para encontrar a pessoa com o maior salário em cada departamento
SELECT Departamento, Pessoa, Salario
FROM (
        SELECT
            d.Nome AS Departamento, p.Nome AS Pessoa, p.Salario, ROW_NUMBER() OVER (
                PARTITION BY
                    p.DeptId
                ORDER BY p.Salario DESC
            ) AS numeroLinha
        FROM Pessoa p
            INNER JOIN Departamento d ON p.DeptId = d.Id
    ) AS Ranking
WHERE
    NumeroLinha = 1;