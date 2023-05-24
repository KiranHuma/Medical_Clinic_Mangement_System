
CREATE DATABASE mainClinicDb;


CREATE TABLE add_invent_tbl (
    inven_Id int IDENTITY(1,1) PRIMARY KEY,
    int_date varchar(255),
    Qty_or_pcs varchar(255),
    packing varchar(255),
    in_prod_single_price varchar(255),
    in_prod_grand_price varchar(255),
    in_add_by varchar(255),
    in_total_quantity varchar(255),
    address varchar(255),
    status varchar(255),
    
  
)

CREATE TABLE sell_tbl (
    sell_Id int IDENTITY(1,1) PRIMARY KEY,
    sell_date datetime,
    patient_Name nvarchar(max),
    product_list nvarchar(max),
    patient_Status nvarchar,
    price float,
    profit_price float,
    in_total_quantity bigint,
    sell_total_quantity bigint,
    sell_by nvarchar(max),
    
  
)
