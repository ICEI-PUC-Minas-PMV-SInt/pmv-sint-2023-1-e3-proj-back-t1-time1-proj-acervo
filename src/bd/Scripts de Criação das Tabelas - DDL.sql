-- Criar tabela tbl_book
CREATE TABLE tbl_book (
  id_book INT NOT NULL,
  title_book VARCHAR(255) NOT NULL,
  type_book VARCHAR(255) NOT NULL,
  author_book VARCHAR(255) NOT NULL,
  stand_book VARCHAR(255) NOT NULL,
  year_book INT NOT NULL,
  is_reserved_book BOOLEAN NOT NULL DEFAULT FALSE,
  PRIMARY KEY (id_book)
);

-- Criar tabela tbl_user
CREATE TABLE tbl_user (
  id_user INT NOT NULL,
  name_user VARCHAR(255) NOT NULL,
  cpf_user VARCHAR(11) NOT NULL,
  password_user VARCHAR(255) NOT NULL,
  email_user VARCHAR(255) NOT NULL,
  phone_user VARCHAR(20) NOT NULL,
  did_reserve_user BOOLEAN NOT NULL DEFAULT FALSE,
  id_reserve INT NULL,
  PRIMARY KEY (id_user)
);

-- Criar tabela tbl_reserve
CREATE TABLE tbl_reserve (
  id_reserve INT NOT NULL,
  id_user INT NOT NULL,
  id_book INT NOT NULL,
  date_reserve DATETIME NOT NULL,
  PRIMARY KEY (id_reserve),
  FOREIGN KEY (id_user) REFERENCES tbl_user(id_user),
  FOREIGN KEY (id_book) REFERENCES tbl_book(id_book)
);
