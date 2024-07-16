--use Exercicio_Escola_2 --para qual banco quer utolozar
CREATE TABLE ALUNO
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(100) NOT NULL, --pode ser NVARCHAR, ele alocar espaço variiável, e do lado é o tamanho máximo
	--Nome NVARCHAR(100) NOT NULL --insiro Paloma, ele irá ocupar 6 espaços
	Endereco VARCHAR(200), --endereao pode ser nulo?
	Email VARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE PROFESSOR
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(100) NOT NULL,
	Departamento VARCHAR(100) NOT NULL,
	Email VARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE CURSO
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Titulo VARCHAR(100) NOT NULL,
Descricao TEXT,
ProfessorId INT,
FOREIGN KEY (ProfessorId) REFERENCES Professor(Id),
)

CREATE TABLE PERFIL
(
AlunoId INT PRIMARY KEY,
DataNascimento DATE,
Telefone VARCHAR(20),
FOREIGN KEY (AlunoId) REFERENCES Aluno(Id),
)

--outra forma de fazer que não permita fazer mais de um perfil
--CREATE TABLE PERFIL
--(
-- PerfilId INT IDENTITY(1,1) PRIMARY KEY,
--AlunoId INT UNIQUE,
--DataNascimento DATE,
--Telefone VARCHAR(20),
--FOREIGN KEY (AlunoId) REFERENCES Aluno(Id),
--)
CREATE TABLE MATRICULA
(
PRIMARY KEY (AlunoId, CursoId),
StatusMatricula VARCHAR(10) NOT NULL CHECK (StatusMatricula IN ('ativa', 'concluida')),
--DataMatricula DATE, -- faltou esse
--StatusMatricula BIT,  --boolean 0 ou 1, pode ter mais status
AlunoId int NOT NULL,
CursoId int NOT NULL,
FOREIGN KEY (AlunoId) REFERENCES Aluno(Id),
FOREIGN KEY (CursoId) REFERENCES Curso(Id)
)

ALTER TABLE MATRICULA
ADD DataMatricula DATE;

INSERT INTO ALUNO (Nome, Endereco, Email) VALUES
  ('Ana Silva', 'Rua das Flores, 123', 'ana.silva@email.com'),
  ('Joao Oliveira', 'Avenida Brasil, 456', 'joao.oliveira@email.com'),
  ('Maria Costa', 'Rua Sao Paulo, 789', 'maria.costa@email.com'),
  ('Pedro Souza', 'Alameda Santos, 1011', 'pedro.souza@email.com'),
  ('Carlos Pereira', 'Rua do Com�rcio, 1213', 'carlos.pereira@email.com');

INSERT INTO PROFESSOR (Nome, Departamento, Email) VALUES
  ('Dr. Roberto Almeida', 'Ciencia da Computacao', 'roberto.almeida@universidade.com.br'),
  ('Dra. Ana Costa', 'Engenharia Eletrica', 'ana.costa@universidade.com.br'),
  ('Dr. Paulo Silva', 'Engenharoa Ambiental', 'paulo.silva@universidade.com.br'),
  ('Dra. Maria Oliveira', 'Engenharia Eletrica', 'maria.oliveira@universidade.com.br'),
  ('Dr. Carlos Gomes', 'Engenharia da Computacao', 'carlos.gomes@universidade.com.br');

INSERT INTO CURSO (Titulo, Descricao, ProfessorId) VALUES
  ('Introducao a Programacao', 'Este curso introduz os conceitos basicos de programacao utilizando a linguagem Python.', 1),
  ('Estrutura de Dados', 'Neste curso, o aluno aprendera os principais conceitos e estruturas de dados em Ciencia da computacao.', 1),
  ('Algoritmos e Complexidade', 'Este curso aborda os fundamentos de algoritmos e sua analise de complexidade.', 1),
  ('Banco de Dados', 'Neste curso, o aluno aprendera os conceitos basicos de banco de dados relacional e SQL.', 2),
  ('Desenvolvimento Web', 'Este curso introduz os conceitos e tecnologias para desenvolvimento de websites e aplicaoes web.', 2);

INSERT INTO PERFIL (AlunoId, DataNascimento, Telefone) VALUES
  (1, '1990-01-01', '(11) 9999-1234'),
  (2, '1992-02-02', '(12) 9999-2345'),
  (3, '1994-03-03', '(13) 9999-3456'),
  (4, '1996-04-04', '(14) 9999-4567'),
  (5, '1998-05-05', '(15) 9999-5678');
-- Se estiver adicionando valores para todas as colunas da tabela, 
--não será necessário especificar os nomes das colunas na consulta SQL.
/*modificar para incluir a data*/
INSERT INTO MATRICULA (AlunoId, CursoId, StatusMatricula) VALUES
  (1, 1, 'ativa'),
  (1, 2, 'concluida'),
  (1, 3, 'ativa'),
  (2, 1, 'ativa'),
  (2, 2, 'ativa'),
  (3, 1, 'concluida'),
  (4, 1, 'ativa'),
  (4, 4, 'ativa'),
  (5, 2, 'concluida'),
  (5, 5, 'ativa');

UPDATE MATRICULA
SET DataMatricula = '2024-07-12' 
WHERE AlunoId = 1 AND CursoId = 1;
UPDATE MATRICULA
SET DataMatricula = '2024-06-12'
WHERE AlunoId = 1 AND CursoId = 2;

  ALTER TABLE Matricula
  ADD Nota int

  AlTER TABLE Matricula
  ALTER COLUMN Nota DECIMAL(4,2)

  UPDATE MATRICULA
  SET Nota = '7.45'
  WHERE AlunoId = 1 AND CursoId = 1;

  --TRUNCATE TABLE MATRICULA --apaga todos os dados da tabela
  --DROP TABLE MATRICULA --apaga a tabela

  DELETE MATRICULA WHERE AlunoId = 1 -- remove uma linha da tabela matricula

  -- como inserir dados de outra tabela
  CREATE TABLE PESSOAS
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(100) NOT NULL
)
INSERT INTO PESSOAS select nome from ALUNO

--
-- inner : interseção, fornece uma visão geral das matrículas, 
-- mostrando o nome do aluno, o título do curso e o nome do professor associado a cada matrícula.
select 
a.Nome as ALUNO,
c.Titulo as CURSO,
p.nome as PROFESSOR
from MATRICULA as m
inner join ALUNO as a on a.Id = m.AlunoId
inner join CURSO as c on m.CursoId = c.Id
inner join PROFESSOR as p on p.Id = c.ProfessorId;

--left e right
-- group by
-- order by
-- count
-- having (having count(*))
-- case e case when
-- distinct