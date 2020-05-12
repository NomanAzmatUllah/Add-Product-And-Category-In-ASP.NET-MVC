create database category_products

use category_products



create table tbl_category
(

cat_id int identity primary key,
cat_name nvarchar(30)
)

create table product(

pro_id int identity primary key,
pro_name nvarchar(30) unique,
c_date datetime,
Mod_date datetime,
pro_description nvarchar(100),
pro_image nvarchar(max),
quanitity int,
price int,
fk_tbl_category int foreign key references tbl_category(cat_id)
) 




select * from tbl_category 

select * from product 


