--Inserir Registros na tabela tbl_book
INSERT INTO tbl_book (id_book, title_book, type_book, author_book, stand_book, year_book, is_reserved_book)
VALUES (1, '1984', 'Ficção', 'George Orwell', 'A2', 1949, TRUE),
       (2, 'Dom Casmurro', 'Romance', 'Machado de Assis', 'B1', 1899, FALSE),
       (3, 'O Pequeno Príncipe', 'Infantil', 'Antoine de Saint-Exupéry', 'B2', 1943, FALSE);

--Inserir Registros na tabela tbl_user
INSERT INTO tbl_user (id_user, name_user, cpf_user, password_user, email_user, phone_user, did_reserve_user, id_reserve)
VALUES (1, 'Maria Souza', '09876543210', 'senha456', 'maria.souza@gmail.com', '(21) 98765-4321', TRUE, 1),
       (2, 'Pedro Santos', '45678901234', 'senha789', 'pedro.santos@gmail.com', '(31) 91234-5678', FALSE, NULL),
       (3, 'Ana Lima', '56789012345', 'senhaabc', 'ana.lima@gmail.com', '(41) 98765-4321', TRUE, 2);


--Inserir Registros na tabela tbl_reserve
INSERT INTO tbl_reserve (id_reserve, id_user, id_book, date_reserve) VALUES
(6, 1, 2, '2023-03-15 10:30:00'),
(7, 3, 1, '2023-03-16 14:45:00'),
(8, 2, 3, '2023-03-17 09:15:00');

--Atualiza o type_book para "Fantasia", onde o id for 1
UPDATE tbl_book SET type_book = 'Fantasia' WHERE id_book = 1;

--Atualiza o phone_user para "(11) 91234-5678", onde o id for 1
UPDATE tbl_user SET phone_user = '(11) 91234-5678' WHERE id_user = 2;

--Atualiza o date_reserve para "2022-04-15 15:30:00", onde o id for 3
UPDATE tbl_reserve SET date_reserve = '2022-04-15 15:30:00' WHERE id_reserve = 3;

--Projetar todos os registros da tabela tbl_book
SELECT * FROM tbl_book;

--Projetar todos os registros da tabela tbl_reserve
SELECT * FROM tbl_reserve;

--Projetar todos os registros da tabela tbl_reserve
SELECT * FROM tbl_user;