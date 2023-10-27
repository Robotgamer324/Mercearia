use Mercearia

go

declare @Id int
declare @Nome VARCHAR(150)
declare @NomeUsuario VARCHAR(150)
declare @Senha VARCHAR(150)
declare @Ativo BIT

set @Id =  8
set @Nome ='Erisvaldo'
set @NomeUsuario = 'Brasileiro'
set @Senha = '124'
set @Ativo = 1

update Usuario set
Nome = @Nome,
NomeUsuario = @NomeUsuario,
Senha = @Senha,
Ativo = @Ativo
where Id = @Id

insert into Usuario(Nome, NomeUsuario, Senha,Ativo)
values(@Nome, @NomeUsuario, @Senha, @Ativo)

select* from Usuario

delete from Usuario where id=6