--�������� ���� ������
Create DATABASE RuslanVahitovDB

--������������ ��������� ����
--USE RuslanVahitovDB

--������� ���������
CREATE TABLE Products
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(30),
	amount INT,
	unMeasured NVARCHAR(10),
)

--USE RuslanVahitovDB
--������ ��� ����� � ������� Product
INSERT Products VALUES ('iPhone 7', 5, '.��')
INSERT Products VALUES ('Xiaomi note 4x', 15, '.��')
INSERT Products VALUES ('samsung a51', 6, '.��')
INSERT Products VALUES ('samsung a71', 4, '.��')
INSERT Products VALUES ('samsung s20', 3, '.��')

INSERT Products VALUES ('������', 8, '.��')
INSERT Products VALUES ('���', 21, '.��')
INSERT Products VALUES ('�����', 10, '.��')

INSERT Products VALUES ('����', 3, '.��')
INSERT Products VALUES ('�����', 4, '.��')
INSERT Products VALUES ('�����', 5, '.��')

INSERT Products VALUES ('����', 3, '.��')
INSERT Products VALUES ('Nisan Primera', 6, '.��')
INSERT Products VALUES ('Toyota mark 2', 1, '.��')
INSERT Products VALUES ('���-2107', 4, '.��')

--������� ���������
CREATE TABLE Category(
	id INT IDENTITY  PRIMARY KEY,
	name NVARCHAR(20)
)

INSERT Category VALUES ('�������')
INSERT Category VALUES ('�������')
INSERT Category VALUES ('��������')
INSERT Category VALUES ('������')
INSERT Category VALUES ('����')
INSERT Category VALUES ('�� ����')

--������� ��� ��������� ������ �� ������(�������)
CREATE TABLE Prod_Categ(
	id INT IDENTITY PRIMARY KEY,
	product INT,
	category INT
)

INSERT Prod_Categ VALUES ('1','1')
INSERT Prod_Categ VALUES ('1','2')
INSERT Prod_Categ VALUES ('2','1')
INSERT Prod_Categ VALUES ('2','2')
INSERT Prod_Categ VALUES ('2','6')
INSERT Prod_Categ VALUES ('3','1')
INSERT Prod_Categ VALUES ('3','2')

INSERT Prod_Categ VALUES ('4','3')
INSERT Prod_Categ VALUES ('5','3')
INSERT Prod_Categ VALUES ('6','3')
INSERT Prod_Categ VALUES ('6','6')

INSERT Prod_Categ VALUES ('7','4')
INSERT Prod_Categ VALUES ('8','4')
INSERT Prod_Categ VALUES ('9','4')

INSERT Prod_Categ VALUES ('10','5')
INSERT Prod_Categ VALUES ('11','5')
INSERT Prod_Categ VALUES ('12','5')
INSERT Prod_Categ VALUES ('13','6')

SELECT Products.name AS Product, Category.name AS Category 
FROM Products
LEFT JOIN Prod_Categ ON Products.id = Prod_Categ.product
LEFT JOIN Category ON Prod_Categ.product = Category.id