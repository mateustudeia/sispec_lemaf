CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" varchar(150) NOT NULL,
    "ProductVersion" varchar(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

CREATE SCHEMA IF NOT EXISTS sispec;

CREATE TABLE sispec."Locais" (
    "Id" serial NOT NULL,
    "Nome" text NULL,
    "Capacidade" integer NOT NULL,
    CONSTRAINT "PK_Locais" PRIMARY KEY ("Id")
);

CREATE TABLE sispec.pessoa (
    id serial NOT NULL,
    nome text NOT NULL,
    cpf text NOT NULL,
    contato text NOT NULL,
    email text NOT NULL,
    data_nascimento timestamp without time zone NOT NULL,
    CONSTRAINT "PK_pessoa" PRIMARY KEY (id)
);

CREATE TABLE sispec."Evento" (
    "Id" serial NOT NULL,
    "Tema" text NULL,
    "Descricao" text NULL,
    "IdLocal" integer NOT NULL,
    "Discriminator" text NOT NULL,
    "DataInicio" timestamp without time zone NULL,
    "DataFim" timestamp without time zone NULL,
    "TempoDuracao" timestamp without time zone NULL,
    "PreRequisitos" text NULL,
    "FerramentasUtilizadas" text NULL,
    "IdPessoa" integer NULL,
    "Entreterimento_DataInicio" timestamp without time zone NULL,
    "Entreterimento_DataFim" timestamp without time zone NULL,
    "Entreterimento_IdPessoa" integer NULL,
    "Data" timestamp without time zone NULL,
    "tempoDuracao" timestamp without time zone NULL,
    "Palestra_IdPessoa" integer NULL,
    CONSTRAINT "PK_Evento" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Evento_pessoa_IdPessoa" FOREIGN KEY ("IdPessoa") REFERENCES sispec.pessoa (id) ON DELETE CASCADE,
    CONSTRAINT "FK_Evento_pessoa_Entreterimento_IdPessoa" FOREIGN KEY ("Entreterimento_IdPessoa") REFERENCES sispec.pessoa (id) ON DELETE CASCADE,
    CONSTRAINT "FK_Evento_Locais_IdLocal" FOREIGN KEY ("IdLocal") REFERENCES sispec."Locais" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Evento_pessoa_Palestra_IdPessoa" FOREIGN KEY ("Palestra_IdPessoa") REFERENCES sispec.pessoa (id) ON DELETE CASCADE
);

CREATE TABLE sispec."InscritoEvento" (
    "IdPessoa" integer NOT NULL,
    "IdEvento" integer NOT NULL,
    CONSTRAINT "PK_InscritoEvento" PRIMARY KEY ("IdPessoa", "IdEvento"),
    CONSTRAINT "FK_InscritoEvento_Evento_IdEvento" FOREIGN KEY ("IdEvento") REFERENCES sispec."Evento" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_InscritoEvento_pessoa_IdPessoa" FOREIGN KEY ("IdPessoa") REFERENCES sispec.pessoa (id) ON DELETE CASCADE
);

CREATE INDEX "IX_Evento_IdPessoa" ON sispec."Evento" ("IdPessoa");

CREATE INDEX "IX_Evento_Entreterimento_IdPessoa" ON sispec."Evento" ("Entreterimento_IdPessoa");

CREATE INDEX "IX_Evento_IdLocal" ON sispec."Evento" ("IdLocal");

CREATE INDEX "IX_Evento_Palestra_IdPessoa" ON sispec."Evento" ("Palestra_IdPessoa");

CREATE INDEX "IX_InscritoEvento_IdEvento" ON sispec."InscritoEvento" ("IdEvento");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20200121031835_Evolution 01', '2.1.14-servicing-32113');

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20200121033126_Evolution_02', '2.1.14-servicing-32113');

ALTER TABLE sispec."Evento" DROP CONSTRAINT "FK_Evento_pessoa_IdPessoa";

ALTER TABLE sispec."Evento" DROP CONSTRAINT "FK_Evento_pessoa_Entreterimento_IdPessoa";

ALTER TABLE sispec."Evento" DROP CONSTRAINT "FK_Evento_Locais_IdLocal";

ALTER TABLE sispec."Evento" DROP CONSTRAINT "FK_Evento_pessoa_Palestra_IdPessoa";

ALTER TABLE sispec."InscritoEvento" DROP CONSTRAINT "FK_InscritoEvento_Evento_IdEvento";

ALTER TABLE sispec."Evento" DROP CONSTRAINT "PK_Evento";

ALTER TABLE sispec."Evento" RENAME TO "Eventos";
ALTER TABLE sispec."Eventos" SET SCHEMA sispec
ALTER TABLE sispec."Eventos" RENAME COLUMN "Id" TO "Entreterimento_id";

ALTER INDEX sispec."IX_Evento_Palestra_IdPessoa" RENAME TO "IX_Eventos_Palestra_IdPessoa";

ALTER INDEX sispec."IX_Evento_IdLocal" RENAME TO "IX_Eventos_IdLocal";

ALTER INDEX sispec."IX_Evento_Entreterimento_IdPessoa" RENAME TO "IX_Eventos_Entreterimento_IdPessoa";

ALTER INDEX sispec."IX_Evento_IdPessoa" RENAME TO "IX_Eventos_IdPessoa";

ALTER TABLE sispec."Eventos" ADD "EventoId" integer NULL;

ALTER TABLE sispec."Eventos" ADD "Entreterimento_EventoId" integer NULL;

ALTER TABLE sispec."Eventos" ADD "IdTipo" integer NOT NULL DEFAULT 0;

ALTER TABLE sispec."Eventos" ADD "Tipo" text NOT NULL DEFAULT '';

ALTER TABLE sispec."Eventos" ADD "Palestra_EventoId" integer NULL;

ALTER TABLE sispec."Eventos" ADD CONSTRAINT "PK_Eventos" PRIMARY KEY ("Entreterimento_id");

CREATE INDEX "IX_Eventos_EventoId" ON sispec."Eventos" ("EventoId");

CREATE INDEX "IX_Eventos_Entreterimento_EventoId" ON sispec."Eventos" ("Entreterimento_EventoId");

CREATE INDEX "IX_Eventos_Palestra_EventoId" ON sispec."Eventos" ("Palestra_EventoId");

ALTER TABLE sispec."Eventos" ADD CONSTRAINT "FK_Eventos_Eventos_EventoId" FOREIGN KEY ("EventoId") REFERENCES sispec."Eventos" ("Entreterimento_id") ON DELETE RESTRICT;

ALTER TABLE sispec."Eventos" ADD CONSTRAINT "FK_Eventos_pessoa_IdPessoa" FOREIGN KEY ("IdPessoa") REFERENCES sispec.pessoa (id) ON DELETE CASCADE;

ALTER TABLE sispec."Eventos" ADD CONSTRAINT "FK_Eventos_Eventos_Entreterimento_EventoId" FOREIGN KEY ("Entreterimento_EventoId") REFERENCES sispec."Eventos" ("Entreterimento_id") ON DELETE RESTRICT;

ALTER TABLE sispec."Eventos" ADD CONSTRAINT "FK_Eventos_pessoa_Entreterimento_IdPessoa" FOREIGN KEY ("Entreterimento_IdPessoa") REFERENCES sispec.pessoa (id) ON DELETE CASCADE;

ALTER TABLE sispec."Eventos" ADD CONSTRAINT "FK_Eventos_Locais_IdLocal" FOREIGN KEY ("IdLocal") REFERENCES sispec."Locais" ("Id") ON DELETE CASCADE;

ALTER TABLE sispec."Eventos" ADD CONSTRAINT "FK_Eventos_Eventos_Palestra_EventoId" FOREIGN KEY ("Palestra_EventoId") REFERENCES sispec."Eventos" ("Entreterimento_id") ON DELETE RESTRICT;

ALTER TABLE sispec."Eventos" ADD CONSTRAINT "FK_Eventos_pessoa_Palestra_IdPessoa" FOREIGN KEY ("Palestra_IdPessoa") REFERENCES sispec.pessoa (id) ON DELETE CASCADE;

ALTER TABLE sispec."InscritoEvento" ADD CONSTRAINT "FK_InscritoEvento_Eventos_IdEvento" FOREIGN KEY ("IdEvento") REFERENCES sispec."Eventos" ("Entreterimento_id") ON DELETE CASCADE;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20200122033459_Evolution_03', '2.1.14-servicing-32113');

