USE bd_biblioteca;

CREATE TABLE tb_emprestimo (
	emprestimo_id smallint PRIMARY KEY AUTO_INCREMENT,
    cliente_cpf VARCHAR(11),
    livro_isbn VARCHAR(13),
    emprestimo_data DATE,
    emprestimo_devolucao DATE,
    FOREIGN KEY (cliente_cpf) references tb_cliente(cliente_cpf),
    FOREIGN KEY (livro_isbn) references tb_livro(livro_isbn)
)
DEFAULT CHARSET = utf8;tb_usuario