use C����������������������

insert into Categories(nameCategories)
values('�������� ������'),
('�����'),
('���������'),
('�����'),
('��������� ����������'),
('�������'),
('�������� � �����������'),
('���������-��������'),
('����'),
('������� ��� ����'),
('��� ���������')
insert into Stores(adressStore)
values('����������� �������, ����� �������������, ��. ����������, 42'),
('���������� �������, ����� ��������, ������ �������, 81'),
('������������ �������, ����� �������, ���. �������������, 29'),
('������������ �������, ����� �����������, ��. �������, 80'),
('������� �������, ����� ��������, ����� �������, 40'),
('���������� �������, ����� ��������, ���. ������, 79'),
('������� �������, ����� ���������, ����� ��������, 09'),
('��������� �������, ����� �����������, ��. �������������, 94'),
('������������� �������, ����� ������� �����, ���. ������������, 74'),
('��������� �������, ����� ����-�������, ����� ������, 82'),
('��� ���������� �� ��������')
insert into Products(nameProduct, priceProduct, purchasePriceProduct, AmountInStocksProduct, IDCategories,ImagePath)
values('������ ������� 90�90 ������� ������, ������������ ������ Domani-Spa Delight Slim 99 high DS01DS99HBT00','26205','20000','100','1','images/1.jpg'),
('����� ��������� Roca BeCool 170�80 ������������� � ������� � ��������� ���������� (������, ����/�������) ZRU9302852+ZRU9302853','34557','30000','100','2','images/2.jpg'),
('��������� ��� ����� ������ Lemark Linara LM0415C','4946','4000','100','3','images/3.jpg'),
('����� ������� Fondital Minorca Plus CTFS 24 ��������� CMKR02CA24','47300','35000','100','4','images/4.jpg'),
('�������� ��� 500/100 ������ ����������� ����� ��500/100','650','300','100','5','images/5.jpg'),
('������������ ��������� ������ VitrA Nest 5176B003-6233, � �������� ����, � �������� ����������� ������ � �������������� �������, ������ ���������','51817','40000','100','6','images/6.jpg'),
('�������� Jacob Delafon Terrace, ��� ���������, 100 � 49 ��, EXC112-00','98850','60000','100','7','images/7.jpg'),
('����������������� ������� ����� ������ 80 ��, ������ 60 ��, ������ �����������','60000','40000','100','8','images/8.jpg'),
('������� ��� Axor Shower Heaven 10628000,120x30 ��, 3 ������ �����, � ����������','1730830','1200000','100','9','images/9.jpg'),
('������ ��������� ������ ������ ������� � � ����� 12 ������ � ������ �7 20007','13565','10000','100','10','images/10.jpg')
insert into ProductsInStores(IDProductsPIS,IDStorePIS,AmountPIS)
values('1','10','5'),
('2','9','5'),
('3','8','5'),
('4','7','5'),
('5','6','5'),
('6','5','5'),
('7','4','5'),
('8','3','5'),
('9','2','5'),
('10','1','5')
insert into Provider(nameProvider, contactDetailsProvider,phoneProvider)
values('OOO "AOX"','���� ����������','89503345010')
insert into Supplies(IDProviderSupplie)
values('1'),
('1'),
('1'),
('1'),
('1'),
('1'),
('1'),
('1'),
('1'),
('1')
insert into ProductsInSupplies(IDProductPISupplies,IDSuppliesPISupplies,amountPISupplies)
values ('1','1','2')
insert into ProductsInSupplies(IDProductPISupplies,IDSuppliesPISupplies,amountPISupplies)
values('2','2','3')
insert into ProductsInSupplies(IDProductPISupplies,IDSuppliesPISupplies,amountPISupplies)
values('3','3','4')
insert into ProductsInSupplies(IDProductPISupplies,IDSuppliesPISupplies,amountPISupplies)
values('4','5','1')
insert into ProductsInSupplies(IDProductPISupplies,IDSuppliesPISupplies,amountPISupplies)
values('5','7','1')
insert into ProductsInSupplies(IDProductPISupplies,IDSuppliesPISupplies,amountPISupplies)
values('6','8','1')
insert into ProductsInSupplies(IDProductPISupplies,IDSuppliesPISupplies,amountPISupplies)
values('7','4','4')
insert into ProductsInSupplies(IDProductPISupplies,IDSuppliesPISupplies,amountPISupplies)
values('8','6','3')
insert into ProductsInSupplies(IDProductPISupplies,IDSuppliesPISupplies,amountPISupplies)
values('9','9','2')
insert into ProductsInSupplies(IDProductPISupplies,IDSuppliesPISupplies,amountPISupplies)
values('10','10','3')
insert into JobTitle(nameJT,loginJT,passwordJT)
values('�������������-��������','asdf','asdf'),
('��������-����������','asdg','asdg')
insert into Employees(nameEmployee,phoneEmployee,adressEmployee,experienceEmployee,IDStoreEmployee,IDCategoriesEmployee,IDJobTitleEmployee)
values('������ �������� ������������','76402250521','����������� �������, ����� �������������, ��. ����������, 42','20','1',null,'1'),
('������ ��������� ������������','77747886708','���������� �������, ����� ��������, ������ �������, 81','18','2',null,'1'),
('��������a ���� ���������','79514780181','������������ �������, ����� �������, ���. �������������, 29','10','3',null,'1'),
('������ ������ ����������','70649336707','������������ �������, ����� �����������, ��. �������, 80','9','4','1','2'),
('��������� ���� ����������','78332952567','������� �������, ����� ��������, ����� �������, 40','8','5','2','2'),
('����� ��������� ����������','73505294840','���������� �������, ����� ��������, ���. ������, 79','1','6','3','2'),
('�������a �������� ���������','73454136429','������� �������, ����� ���������, ����� ��������, 09','4','7','4','2'),
('����� ������ Ը�������','71948739272','��������� �������, ����� �����������, ��. �������������, 94','7','8','5','2'),
('������� �������� �������������','7079563016','������������� �������, ����� ������� �����, ���. ������������, 74','26','9','6','2'),
('�������a ���� ����������','7436204398','��������� �������, ����� ����-�������, ����� ������, 82','31','10','7','2')
insert into PaintingColors(namePC,pricePC)
values('�����','0'),
('׸����','2000'),
('����������','1500'),
('�������','5000'),
('���������','3000'),
('����-����-���������','15000'),
('����������','4000'),
('����������','2000'),
('����������','7000'),
('Ҹ���-���������','6000')
insert into Checks(IDEmployeeCheck)
values('4'),
('6'),
('7'),
('9'),
('5'),
('7'),
('9'),
('10'),
('7'),
('6')
insert into ProductsInCheck(IDCheckPIC,IDProductPIC,IDPaintingColorPIC)
values('1','10','1')
insert into ProductsInCheck(IDCheckPIC,IDProductPIC,IDPaintingColorPIC)
values('2','1','3')
insert into ProductsInCheck(IDCheckPIC,IDProductPIC,IDPaintingColorPIC)
values('3','4','5')
insert into ProductsInCheck(IDCheckPIC,IDProductPIC,IDPaintingColorPIC)
values('4','7','7')
insert into ProductsInCheck(IDCheckPIC,IDProductPIC,IDPaintingColorPIC)
values('5','9','9')
insert into ProductsInCheck(IDCheckPIC,IDProductPIC,IDPaintingColorPIC)
values('6','8','2')
insert into ProductsInCheck(IDCheckPIC,IDProductPIC,IDPaintingColorPIC)
values('7','3','4')
insert into ProductsInCheck(IDCheckPIC,IDProductPIC,IDPaintingColorPIC)
values('8','6','6')
insert into ProductsInCheck(IDCheckPIC,IDProductPIC,IDPaintingColorPIC)
values('9','5','8')
insert into ProductsInCheck(IDCheckPIC,IDProductPIC,IDPaintingColorPIC)
values('10','2','10')