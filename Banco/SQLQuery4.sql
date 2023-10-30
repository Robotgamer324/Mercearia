select *from cliente 

declare @Id int;
declare @Nome varchar(150);
declare @Fone varchar(15);

set @Nome ='Erisvaldo';
set @Fone = 123456789012345

insert into Cliente ( Nome, Fone )
values(@Nome, @Fone);

select *from Cliente