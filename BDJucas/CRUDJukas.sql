use JukasBank

delete from Cliente where idCliente = 7
delete from Conta where idConta > 0
select * from Conta
select * from Cliente
insert into Cliente
values ('Paulo','12312312363',null,'13998654745','paulito@hotmail.com','rua palmeiras','1','78945612','Praia Grande','SP','Masculino','01/01/2001',4000,'111111')

select * from Conta

insert into Conta
values (6,8000,2000,'Corrente','Ativa','06/06/2006',5000,'111111')

create procedure ps_ValidarAcesso
@cpf char (11),
@senhaLogin char (06)
as 
select * from cliente
where cpf = @cpf and senhaLogin = @senhaLogin

exec ps_ValidarLogin 

create procedure ps_BuscaContasId
@idcliente int
as
select * from conta
where idcliente = @idcliente

exec ps_buscaContasPorIdCliente 1

create procedure pi_Cliente 
@nome varchar (120),
@cpf char (11),
@rg char (9),
@celular varchar (20),
@email varchar (200),
@logradouro varchar (200),
@numerologradouro varchar (5),
@cep char (8),
@cidade varchar (30),
@estado char (2),
@genero varchar (20),
@datanasc datetime,
@renda numeric (10,2),
@senhalogin char (6)
as 
insert into Cliente
values (@nome,@cpf,@rg,@celular,@email,@logradouro,@numerologradouro,@cep,@cidade,@estado,@genero,@datanasc,@renda,@senhalogin)

exec pi_Cliente ('paulo','11122233344456',null,'13997584875','pauloogmail.com','rua ipanema','58','11144456','Praia Grande','São Paulo','Masculino','01/01/2001',1000,'123456')

select * from Cliente
select * from Conta

/*criar conta*/
create procedure pi_Conta
@idcliente int,
@aberturaconta datetime,
@saldo numeric(10,2),
@statusconta varchar(10),
@tipoconta varchar(30),
@limite numeric(10,2),
@senhaconta char(8)
as
insert into conta (idcliente,aberturaconta,saldo,statusConta,tipoconta,limite,senhaconta)
values (@idcliente,@aberturaconta,@saldo,@statusConta,@tipoconta, @limite, @senhaconta)
select @@identity as 'ultimoID'



create procedure pu_AlterarSenha
@idCliente int,
@senhaLogin char (6)
as
update Cliente
set senhaLogin = @senhaLogin
where idCliente = @idCliente	


create procedure ps_ValidarSenha
@idconta int,
@senhaConta char (6)
as
select * from Conta
where idconta = @idconta and senhaConta = @senhaConta




create procedure pu_alterarCliente
@idCliente int,
@nome varchar(120),
@cpf char(11),
@rg char(9),
@celular varchar(20),
@email varchar(200),
@logradouro varchar(200),
@numerologradouro varchar(5),
@cep char(8),
@cidade varchar(30),
@estado char(2),
@genero varchar(20),
@datanasc datetime,
@renda numeric(10,2),
@senhaLogin char(6)
as 
update Cliente
set 
nome = @nome,
cpf = @cpf,
rg = @rg,
celular = @celular,
email = @email,
logradouro = @logradouro,
numeroLogradouro = @numeroLogradouro,
cep = @cep,
cidade = @cidade,
estado = @estado,
genero = @genero,
datanasc = @datanasc,
renda = @renda
where idCliente = @idCliente


create procedure pu_AlterarConta
@idconta int,
@idcliente int,
@saldo numeric(10,2),
@limite numeric(10,2),
@tipoconta varchar(30),
@statusconta varchar(20),
@encerramentoconta datetime,
@senhaconta char (6)
as
update Conta
set
idcliente = @idcliente,
saldo = @saldo,
limite = @limite,
tipoconta = @tipoconta,
statusconta = @statusconta,
encerramentoconta = @encerramentoconta,
senhaConta = @senhaConta
where idconta = @idconta