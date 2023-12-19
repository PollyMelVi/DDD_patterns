using DDD_patterns.Factory;

//Фабрики
var buyerFactory = new BuyerFactory();
var orderFactory = new OrderFactory();


//Создание агрегата покупателя
try
{
buyerFactory.CreateAggregates();
Console.WriteLine("Агрегат покупателя успешно создан!");
}
catch (Exception e)
{
    Console.WriteLine("Ошибка создания покупателя!");
}



//Создание агрегата заказа
try
{
    orderFactory.CreateAggregates();
    Console.WriteLine("Агрегат заказа успешно создан!");
}
catch (Exception e)
{
    Console.WriteLine("Ошибка создания заказа!");
}



