-- Criação da tabela Autores
CREATE TABLE Autores (
    autor_id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    data_nascimento DATE,
    nacionalidade VARCHAR(50)
);

-- Criação da tabela Categorias
CREATE TABLE Categorias (
    categoria_id SERIAL PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);

-- Criação da tabela Livros
CREATE TABLE Livros (
    livro_id SERIAL PRIMARY KEY,
    titulo VARCHAR(100) NOT NULL,
    isbn VARCHAR(20) UNIQUE NOT NULL,
    data_publicacao DATE,
    preco DECIMAL(10, 2) NOT NULL,
    quantidade_estoque INT NOT NULL,
    autor_id INT NOT NULL,
    categoria_id INT NOT NULL,
    FOREIGN KEY (autor_id) REFERENCES Autores(autor_id),
    FOREIGN KEY (categoria_id) REFERENCES Categorias(categoria_id)
);