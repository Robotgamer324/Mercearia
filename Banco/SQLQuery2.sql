alter table Produto 
add codigoDeBarras int

select * from Produto
use Mercearia
 go
insert into Produto(Nome,Preco,Estoque,codigoDeBarras)
values('Shampo',10 ,10, 1234567891)
go


update Produto set codigoDeBarras = '1234567891'where Estoque = 12;

declare @codigoDeBarras varchar(150);
set @codigoDeBarras='s'
select Id, Nome, Preco,Estoque,codigoDeBarras from Produto where Nome Like @codigoDeBarras;

create table Produto( ID INT IDENTITY(1,1) PRIMARY KEY,Nome varchar(150), Preco float, Estoque int, codigoDeBarras varchar(15))


);


