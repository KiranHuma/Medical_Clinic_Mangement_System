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