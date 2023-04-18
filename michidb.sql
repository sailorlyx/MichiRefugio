create table GUSTA
(
	id int not null primary key identity,
	descripcion varchar(45)
);

create table ODIA
(
	id int not null primary key identity,
	descripcion varchar(45)
);

CREATE TABLE GATO
(
	id int not null primary key identity,
	nombre varchar(45) not null,
	edad tinyint not null,
	genero char(1),
	descripcion text not null,
	adoptado tinyint not null,
	foto varchar(255)
);

CREATE TABLE USUARIO 
(
	id int not null primary key identity,
	nombre varchar(40) not null,
	apellido varchar(40) not null,
	apellido2 varchar(40) not null,
	email varchar(255) not null,
	contrase�a varchar(255) not null,
	telefono char(9) not null,
	admin tinyint not null,
	
);

CREATE TABLE FORMULARIO 
(
	id int not null primary key identity,
	nombre varchar(40) not null,
	apellido varchar(40) not null,
	apellido2 varchar(40) not null,
	email varchar(255) not null,
	contrase�a varchar(255) not null,
	telefono char(9) not null,
	idGato int not null,
	FOREIGN KEY (idGato) references GATO (id)
);

CREATE TABLE GUSTA_GATO
(
	idGusta int not null,
	idGato int not null,
	FOREIGN KEY (idGusta) REFERENCES GUSTA (id),
	FOREIGN KEY (idGato) REFERENCES GATO (id),
);

CREATE TABLE ODIA_GATO
(
	idOdia int not null,
	idGato int not null,
	FOREIGN KEY (idOdia) REFERENCES ODIA (id),
	FOREIGN KEY (idGato) REFERENCES GATO (id),
);

CREATE TABLE USUARIO_GATO
(
	idUsuario int not null,
	idGato int not null,
	fechaInicio varchar(10) not null,
	adoptado tinyint not null,
	fechaAdoptado varchar(10),
	FOREIGN KEY (idUsuario) REFERENCES USUARIO (id),
	FOREIGN KEY (idGato) REFERENCES GATO (id),
);

INSERT INTO GUSTA(descripcion)
values
('Dormir'),
('Dar mimos'),
('Saltar'),
('Jugar'),
('Recibir mimos'),
('Esconderse'),
('Dar sustos')
;

INSERT INTO ODIA(descripcion)
values
('Ejercicio'),
('Ba�arse'),
('Recibir mimos'),
('Dar mimos')
;

INSERT INTO GATO(nombre, edad, genero, descripcion, adoptado)
values
('Sans�n', '1', 'M', 'Sans�n es un gatito de 1 a�o y medio muy amoroso y dormil�n. Lo encontramos solo en un descampado, era el �nico de su familia que habia podido sobrevivir. Sus cosas favoritas en este mundo son comer, dormir y jugar un poco de vez en cuando. �Hemos dicho ya que le gusta dormir? Est� completamente sano, desparasitado y esterilizado.', '0'),
('Sombra', '2', 'H', 'Sombra es una gatita de 2 a�os que encontramos en un contenedor junto a su hermanita Kuma. Las dos est�n a salvo con nosotros, pero ambas buscan un lugar donde poder jugar y dar todo el amor que tienen dentro. Es una gatita mega cari�osa, le encanta jugar con todos y saltar por todas partes. �Tiene mucha energ�a! Est� completamente sana, desparasitada y esterilizada.', '0'),
('Kuma', '2', 'H', 'Kuma es una gatita de 2 a�os, muy cari�osa y dormilona, la encontramos junto a su hermanita Sombra en un contenedor. Es un poco t�mida al principio, pero cuando coge confianza, a Kuma le encanta acurrucarse y echarse la siesta. Est� completamente sana, desparasitada y esterilizada.', '0'),
('Onyx', '2', 'M', 'Onyx es un gatito de 2 a�os y medio, muy travieso y juguet�n al que le encanta estar con otros animales. Sus cosas favoritas son jugar a esconderse y dar sustos a sus dem�s compa�eros. Est� completamente sano, desparasitado y esterilizado.', '0'),
('Tupu', '4', 'H', 'Tupu es una gatita de 4 a�itos muy cari�osa y relajada. Es muy tranquila y reservada, pero le encanta estar con humanos y animales y dar mimos. Sus cosas favoritas son dormir al lado de su humano/a preferido/a y que le den mogoll�n de amor. Est� completamente sana, desparasitada y esterilizada.', '0'),
('Catra', '1', 'H', 'Catra es una gatita de 1 a�ito que nos trajeron nuestros compa�eros del Michi Refugio. Es muy muy muy juguetona y le encanta salir corriendo por todas partes. Sus cosas favoritas en este mundo son jugar con cualquier cosa que se encuentra y correr, �no sab�is lo r�pida que es! Est� completamente sana, desparasitada y esterilizada.', '0')
;

INSERT INTO USUARIO(nombre, apellido, apellido2, email, contrase�a, telefono, admin)
values
('Lili', 'Sailor', 'Saturno', 'lilisaturno@hotmail.com', 'Michimiau1234', '684097811', '1'),
('�ngel', 'S�nchez', 'Pastor', 'angelsp@hotmail.com', 'Calculadora5678', '685984767', '1')
;

INSERT INTO GUSTA_GATO(idGato, idGusta)
values
('1', '2'),
('2', '4'),
('3', '7'),
('4', '8'),
('5', '6'),
('6', '5')
;

INSERT INTO ODIA_GATO(idGato, idOdia)
values
('1', '1'),
('2', '2'),
('3', '1'),
('4', '2'),
('5', '1'),
('6', '4')
;
