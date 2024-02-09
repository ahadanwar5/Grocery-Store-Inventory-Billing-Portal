create database samarqand

create table category (
	Cid int NOT NULL IDENTITY(1,1),
	Cname varchar(255) NOT NULL,
	CDescription varchar(255),
	PRIMARY KEY (Cid)		
)

create table product (
	ProdId int NOT NULL,
	ProdName varchar(255) NOT NULL,
	ProdPrice int NULL,
	ProdQty int NULL,
	ProdCat int NULL,
	PRIMARY KEY (ProdId),
	FOREIGN KEY (ProdCat) REFERENCES category(Cid)
)

create table customer (
	CustId int NOT NULL IDENTITY (1,1),
	Cname varchar(255) NOT NULL,
	Cphone varchar(255) NULL
	PRIMARY KEY (CustId)
)

create table employee (
	EmpId int NOT NULL IDENTITY (1,1),
	Ename varchar(255) NOT NULL,
	Ephone varchar(255) NULL,
	Eaddress varchar(255) NULL,
	Eusername varchar(255) NOT NULL,
	Epassword varchar(255) NOT NULL,
	PRIMARY KEY (EmpId),
	UNIQUE (Eusername)
)

create table orders (
	OrderId int NOT NULL,
	CustId int NOT NULL,
	PRIMARY KEY (OrderId),
	FOREIGN KEY (CustId) REFERENCES customer(CustId)
)

create table order_details (
	OrderId int NOT NULL,
	ProdId int NOT NULL,
	ProdQty int NOT NULL,
	Subtotal int NULL,
	FOREIGN KEY (OrderId) REFERENCES orders(OrderId) ON DELETE CASCADE,
	FOREIGN KEY (ProdId) REFERENCES product(ProdId)
)

create table payment(
	PaymentID int NOT NULL IDENTITY (1,1),
	OrderId int NOT NULL,
	CustId int NOT NULL,
	billdate date NOT NULL,
	total int not null,
	EmpId int not null 

	PRIMARY KEY (PaymentID),
	FOREIGN KEY (OrderId) REFERENCES orders(OrderId),
	FOREIGN KEY (CustID) REFERENCES customer(CustID),
	FOREIGN KEY (EmpId) REFERENCES employee(EmpId)
)

create table productlog(
ProdId int Not null, 
newPrice int NULL,
oldPrice int NULL, 
DateofChange date NULL,
	FOREIGN KEY (ProdId) REFERENCES product(ProdID)
)

CREATE TRIGGER productlogdetails
    ON  product
  After update
AS declare  @ProductID int, @oldPrice int , @newPrice int , @dateofchange date
BEGIN

Select  @ProductID=ProdId,@newPrice=ProdPrice from inserted
Select @oldPrice=ProdPrice from deleted
set @dateofchange= getdate();

 IF(@newPrice!=@oldPrice)
 Begin
 
 insert into productlog(ProdID, newPrice, oldPrice,DateofChange) values (@ProductID, @newPrice, @oldPrice, @dateofchange)
 END

END


@OrderId int,
@Euser varchar(255)
AS
BEGIN 
Declare @total int 
SET @total=(Select SUM(Subtotal) 
	From order_details
	Where OrderId=@OrderId 
	Group BY OrderId)  

declare @date date 
set @date=getdate();
declare @customerID int
set @customerID= (Select CustId from orders where @OrderId=OrderId)

declare @Eid int
SET @Eid = (Select EmpId from employee where employee.Eusername = @Euser)

insert into payment values (@OrderId, @customerID, @date, @total, @Eid )	

END

CREATE TRIGGER subTotal
    ON  order_details
    AFTER INSERT
AS declare @Price int , @Quan int , @Total int, @Orderid int, @ProductID int 
BEGIN
Select
@Orderid=OrderId,
@Quan=ProdQty,
@ProductID=ProdId from inserted 
Select @Price = ProdPrice from product where ProdId=@ProductID

SET @Total = (@Price * @Quan) 

Update order_details 
SET Subtotal=@Total
where order_details.OrderId= @Orderid AND order_details.ProdId = @ProductID
END
GO


create procedure spOrderInsert
@OrderId int,
@CustId int,
@ProdId int,
@ReqQty int
AS
BEGIN
	DECLARE @order_check int;
	SET @order_check = (Select OrderId from orders where OrderId = @OrderId)
	DECLARE @avail_qty int;
	SET @avail_qty = (Select ProdQty from product where ProdId = @ProdId)
	DECLARE @previous_qty int;
	SET @previous_qty = (Select ProdQty from order_details where ProdId=@ProdId AND OrderId = @OrderId)
	
	if (@order_check is NULL)
		BEGIN
			if (@avail_qty >= @ReqQty)
				BEGIN
					insert into orders values (@OrderId,@CustId)
					insert into order_details (OrderId,ProdId,ProdQty) values (@OrderId,@ProdId,@ReqQty)
					UPDATE product SET ProdQty = @avail_qty - @ReqQty WHERE ProdId = @ProdId
				END
			else
				BEGIN
					print ('Not Enough Stock')
				END
		END

	else
		BEGIN
			if (@avail_qty >= @ReqQty)
				BEGIN
					if (@previous_qty is NULL)
						BEGIN
							insert into order_details (OrderId,ProdId,ProdQty) values (@OrderId,@ProdId,@ReqQty)
							UPDATE product SET ProdQty = @avail_qty - @ReqQty WHERE ProdId = @ProdId
						END
					
					else
						BEGIN
							UPDATE order_details SET order_details.ProdQty = @previous_qty + @ReqQty 
							WHERE order_details.OrderId=@OrderId AND order_details.ProdId = @ProdId
							DECLARE @price int;
							SET @price = (Select ProdPrice from product where ProdId = @ProdId)
							UPDATE order_details SET Subtotal = ProdQty * @price 
							WHERE order_details.OrderId=@OrderId AND order_details.ProdId = @ProdId

							UPDATE product SET ProdQty = @avail_qty - @ReqQty WHERE ProdId = @ProdId
						END		
					
				END
			else
				BEGIN
					print ('Not Enough Stock')
				END
		END
END

create procedure spCartRemove
@ProdId int,
@newQty int
AS
BEGIN
	DECLARE @prevQty int;
	SET @prevQty = (Select ProdQty from product where @ProdId = ProdId)

	UPDATE product SET ProdQty = @prevQty + @newQty
END


--===========TESTING AREA BELOW=================



insert into employee values ('Ahad','03494328407','Ali View Park','ahad','password')
insert into employee values ('Noor','01234567891','Minar e Pakistan','noor','password')

select * from employee

insert into customer values ('Ahad','03494328407')
insert into customer values ('Behzad','03494328407')

select * from product
select * from customer
select * from orders
select * from order_details
select * from payment

SELECT p.ProdId,p.ProdName,od.ProdQty as 'Qty',p.ProdPrice as 'Unit Price',od.Subtotal
                from orders o INNER JOIN order_details od ON o.OrderId = od.OrderId 
				INNER JOIN customer c ON o.CustId = c.CustId
                INNER JOIN product p ON p.ProdId = od.ProdId WHERE o.OrderId = 503

	
Select billdate from payment where OrderId = 503

select Cname from customer where CustId = (select CustId from payment where OrderId = 503)