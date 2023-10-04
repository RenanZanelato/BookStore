-- Preenchimento da tabela Autores
INSERT INTO Autores (nome, data_nascimento, nacionalidade) VALUES
('Akira Toriyama', '1955-04-05', 'Japonesa'),
('Eiichiro Oda', '1975-01-01', 'Japonesa'),
('Masashi Kishimoto', '1974-11-08', 'Japonesa'),
('Tite Kubo', '1977-06-26', 'Japonesa'),
('Hajime Isayama', '1986-08-29', 'Japonesa'),
('Takehiko Inoue', '1967-01-12', 'Japonesa'),
('Yoshihiro Togashi', '1966-04-27', 'Japonesa'),
('Kentarou Miura', '1966-07-11', 'Japonesa'),
('Tsugumi Ohba', NULL, 'Japonesa'),
('Rumiko Takahashi', '1957-10-10', 'Japonesa');

-- Preenchimento da tabela Categorias
INSERT INTO Categorias (nome) VALUES
('Shonen'),
('Shojo'),
('Seinen'),
('Josei'),
('Kodomo'),
('Harem'),
('Slice of Life'),
('Mecha'),
('Fantasia'),
('Sci-Fi');

-- Preenchimento da tabela Livros
INSERT INTO Livros (titulo, isbn, data_publicacao, preco, quantidade_estoque, autor_id, categoria_id) VALUES
('Dragon Ball', '978-4-08-872496-1', '1985-09-10', 9.99, 100, 1, 1),
('One Piece', '978-4-08-872509-1', '1997-12-24', 9.99, 100, 2, 1),
('Naruto', '978-4-08-872573-2', '1999-09-03', 9.99, 100, 3, 1),
('Bleach', '978-4-08-872670-8', '2001-08-17', 9.99, 100, 4, 1),
('Attack on Titan', '978-4-08-872708-8', '2009-09-09', 9.99, 100, 5, 1),
('Slam Dunk', '978-4-08-872737-8', '1990-10-08', 9.99, 100, 6, 1),
('Hunter x Hunter', '978-4-08-872746-0', '1998-06-04', 9.99, 100, 7, 1),
('Berserk', '978-4-08-872787-3', '1990-08-25', 9.99, 100, 8, 3),
('Death Note', '978-4-08-872853-5', '2003-12-01', 9.99, 100, 9, 1),
('Inuyasha', '978-4-08-872870-2', '1996-11-13', 9.99, 100, 10, 1);