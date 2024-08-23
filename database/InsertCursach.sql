use CетьМагазиновСантехники

insert into Categories(nameCategories)
values('Душевные кабины'),
('Ванны'),
('Смесители'),
('Котлы'),
('Радиаторы секционные'),
('Унитазы'),
('Раковины и умывальники'),
('Полотенце-сушители'),
('Души'),
('Фильтры для воды'),
('Без категории')
insert into Stores(adressStore)
values('Саратовская область, город Солнечногорск, ул. Балканская, 42'),
('Смоленская область, город Подольск, проезд Сталина, 81'),
('Свердловская область, город Ногинск, пер. Домодедовская, 29'),
('Свердловская область, город Красногорск, пл. Косиора, 80'),
('Томская область, город Луховицы, спуск Косиора, 40'),
('Мурманская область, город Лотошино, пер. Ленина, 79'),
('Томская область, город Шаховская, шоссе Ладыгина, 09'),
('Рязанская область, город Волоколамск, пр. Домодедовская, 94'),
('Новосибирская область, город Сергиев Посад, наб. Бухарестская, 74'),
('Читинская область, город Наро-Фоминск, спуск Гоголя, 82'),
('Без фильтрации по магазину')
insert into Products(nameProduct, priceProduct, purchasePriceProduct, AmountInStocksProduct, IDCategories,ImagePath)
values('Кабина душевая 90х90 высокий поддон, тонированные стекла Domani-Spa Delight Slim 99 high DS01DS99HBT00','26205','20000','100','1','images/1.jpg'),
('Ванна акриловая Roca BeCool 170х80 прямоугольная с ручками с монтажным комплектом (каркас, слив/перелив) ZRU9302852+ZRU9302853','34557','30000','100','2','images/2.jpg'),
('Смеситель для кухни гибкий Lemark Linara LM0415C','4946','4000','100','3','images/3.jpg'),
('Котел газовый Fondital Minorca Plus CTFS 24 настенный CMKR02CA24','47300','35000','100','4','images/4.jpg'),
('Радиатор НРЗ 500/100 ОПТИМА алюминиевый литой РА500/100','650','300','100','5','images/5.jpg'),
('Безободковый подвесной унитаз VitrA Nest 5176B003-6233, с функцией биде, с системой дозирования моющих и дезодорирующих средств, крышка микролифт','51817','40000','100','6','images/6.jpg'),
('Раковина Jacob Delafon Terrace, без подсветки, 100 х 49 см, EXC112-00','98850','60000','100','7','images/7.jpg'),
('Полотенцесушитель водяной Омега высота 80 см, ширина 60 см, нижнее подключение','60000','40000','100','8','images/8.jpg'),
('Верхний душ Axor Shower Heaven 10628000,120x30 см, 3 режима струи, с держателем','1730830','1200000','100','9','images/9.jpg'),
('Фильтр обратного осмоса Гейзер Престиж М с баком 12 литров и краном №7 20007','13565','10000','100','10','images/10.jpg')
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
values('OOO "AOX"','Иван Васильевич','89503345010')
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
values('Администратор-директор','asdf','asdf'),
('Продавец-консультат','asdg','asdg')
insert into Employees(nameEmployee,phoneEmployee,adressEmployee,experienceEmployee,IDStoreEmployee,IDCategoriesEmployee,IDJobTitleEmployee)
values('Петров Вениамин Владимирович','76402250521','Саратовская область, город Солнечногорск, ул. Балканская, 42','20','1',null,'1'),
('Гришин Александр Владимирович','77747886708','Смоленская область, город Подольск, проезд Сталина, 81','18','2',null,'1'),
('Мамонтовa Инга Сергеевна','79514780181','Свердловская область, город Ногинск, пер. Домодедовская, 29','10','3',null,'1'),
('Блинов Роберт Максимович','70649336707','Свердловская область, город Красногорск, пл. Косиора, 80','9','4','1','2'),
('Григорьев Иван Алексеевич','78332952567','Томская область, город Луховицы, спуск Косиора, 40','8','5','2','2'),
('Ильин Станислав Алексеевич','73505294840','Мурманская область, город Лотошино, пер. Ленина, 79','1','6','3','2'),
('Журавлёвa Ярослава Сергеевна','73454136429','Томская область, город Шаховская, шоссе Ладыгина, 09','4','7','4','2'),
('Гущин Сергей Фёдорович','71948739272','Рязанская область, город Волоколамск, пр. Домодедовская, 94','7','8','5','2'),
('Кононов Всеволод Александрович','7079563016','Новосибирская область, город Сергиев Посад, наб. Бухарестская, 74','26','9','6','2'),
('Романовa Анна Максимовна','7436204398','Читинская область, город Наро-Фоминск, спуск Гоголя, 82','31','10','7','2')
insert into PaintingColors(namePC,pricePC)
values('Белый','0'),
('Чёрный','2000'),
('Коричневый','1500'),
('Красный','5000'),
('Аквамарин','3000'),
('Серо-буро-малиновый','15000'),
('Фиолетовый','4000'),
('Шоколадный','2000'),
('Коралловый','7000'),
('Тёмно-оранжевый','6000')
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