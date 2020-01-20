--CREATE DATABASE dbsispec;

--GRANT CONNECT ON DATABASE dbsispec TO tudeia;

CREATE SCHEMA IF NOT EXISTS sispec;

--CREATE ROLE tudeia 
--WITH nosuperuser NOCREATEDB LOGIN NOINHERIT PASSWORD '123456';

GRANT USAGE ON SCHEMA sispec TO tudeia;


CREATE TABLE IF NOT EXISTS sispec.pessoa (
  id SERIAL NOT NULL,
  nome_pessoa VARCHAR(45) NOT NULL,
  cpf VARCHAR(45) NULL,
  contato_pessoa VARCHAR(45) NULL,
  email_pessoa VARCHAR(45) NOT NULL,
  data_nascimento VARCHAR(45) NOT NULL,
  CONSTRAINT pk_pessoa PRIMARY KEY (id_pessoa));
  
GRANT SELECT, INSERT, UPDATE, DELETE ON TABLE  sispec.Pessoa TO tudeia;

CREATE TABLE IF NOT EXISTS sispec.participante (
  id SERIAL NOT NULL,
  id_pessoa INT NOT NULL,
  CONSTRAINT pk_participante PRIMARY KEY (id_participante),
  CONSTRAINT fk_i_pessoa FOREIGN KEY (id_pessoa) REFERENCES sispec.pessoa (id_pessoa)
);

GRANT SELECT, INSERT, UPDATE, DELETE ON TABLE  sispec.Participante TO tudeia;

CREATE TABLE IF NOT EXISTS sispec.Palestrante (
  id INT NOT NULL,
  id_pessoa INT NOT NULL,
  CONSTRAINT pk_palestrante PRIMARY KEY (id_palestrante),
  CONSTRAINT fk_p_pessoa FOREIGN KEY (id_pessoa) REFERENCES sispec.Pessoa (id_pessoa)    
);

GRANT SELECT, INSERT, UPDATE, DELETE ON TABLE  sispec.Palestrante TO tudeia;

CREATE TABLE IF NOT EXISTS sispec.local (
  id INT NOT NULL,
  nome_local VARCHAR(45) NOT NULL,
  capacidade INT NOT NULL,
  CONSTRAINT pk_local PRIMARY KEY (id_local)
);

GRANT SELECT, INSERT, UPDATE, DELETE ON TABLE  sispec.local TO tudeia;

CREATE TABLE IF NOT EXISTS sispec.palestra (
  id_[evento_generico] INT NOT NULL,
  tema INT NOT NULL,
  descricao TEXT NULL,
  data_realizacao DATE NOT NULL,
  tempo_duracao TIME NOT NULL,
  tipo VARCHAR(40) NOT NULL,
  disponivel BOOLEAN NOT NULL,
  palestrante INT NOT NULL,
  inscrito_pec INT NOT NULL,
  LOCAL INT NOT NULL,
  CONSTRAINT pk_pec PRIMARY KEY (id_pec),
  CONSTRAINT fk_pe_parcipante FOREIGN KEY (inscrito_pec) REFERENCES sispec.Participante (id_participante)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_pe_palestrante FOREIGN KEY (palestrante) REFERENCES sispec.Palestrante (id_palestrante)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_pe_local FOREIGN KEY (LOCAL) REFERENCES sispec.Local (id_local)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
    
GRANT SELECT, INSERT, UPDATE, DELETE ON TABLE  sispec.palestra TO tudeia;

CREATE TABLE IF NOT EXISTS sispec.evento (
  id_[evento_generico] INT NOT NULL,
  tema INT NOT NULL,
  descricao TEXT NULL,
  data_realizacao DATE NOT NULL,
  tempo_duracao TIME NOT NULL,
  tipo VARCHAR(40) NOT NULL,
  disponivel BOOLEAN NOT NULL,
  palestrante INT NOT NULL,
  inscrito_pec INT NOT NULL,
  LOCAL INT NOT NULL,
  CONSTRAINT pk_pec PRIMARY KEY (id_pec),
  CONSTRAINT fk_pe_parcipante FOREIGN KEY (inscrito_pec) REFERENCES sispec.Participante (id_participante)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_pe_palestrante FOREIGN KEY (palestrante) REFERENCES sispec.Palestrante (id_palestrante)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_pe_local FOREIGN KEY (LOCAL) REFERENCES sispec.Local (id_local)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
    
GRANT SELECT, INSERT, UPDATE, DELETE ON TABLE  sispec.evento TO tudeia;


CREATE TABLE IF NOT EXISTS sispec.[evento_generico] (
  id INT NOT NULL,
  tema INT NOT NULL,
  descricao TEXT NULL,
  inscritos_curso INT NOT NULL,,
  LOCAL INT NOT NULL,
  CONSTRAINT pk_[evento_generico] PRIMARY KEY (id_[evento_generico]),
  CONSTRAINT fk_c_inscritos FOREIGN KEY (inscritos_[evento_generico]) REFERENCES sispec.[evento_generico] (id_inscritos)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_c_orientador FOREIGN KEY (palestrante) REFERENCES sispec.Palestrante (id_palestrante)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_pe_local FOREIGN KEY (LOCAL) REFERENCES sispec.Local (id_local)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
    
GRANT SELECT, INSERT, UPDATE, DELETE ON TABLE  sispec.curso TO tudeia;

CREATE TABLE IF NOT EXISTS sispec.curso (
  id_[evento_generico] INT NOT NULL,
  data_inicio DATE NOT NULL,
  data_fim DATE NOT NULL,
  tempo_duracao_fim DATE NOT NULL,
  pre_requisitos VARCHAR(200) NULL,
  ferramentas_utilizadas VARCHAR(200)NULL,
  orientador INT NOT NULL,
  inscritos_curso INT NOT NULL,
  LOCAL INT NOT NULL,
  CONSTRAINT pk_curso PRIMARY KEY (id_curso),
  CONSTRAINT fk_c_inscritos FOREIGN KEY (inscritos_curso) REFERENCES sispec.curso (id_inscritos)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_c_orientador FOREIGN KEY (palestrante) REFERENCES sispec.Palestrante (id_palestrante)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_pe_local FOREIGN KEY (LOCAL) REFERENCES sispec.Local (id_local)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
