

using DDD_patterns.Aggregates;

namespace DDD_patterns.Repositories;

public class OrderRepository
{
    public void Set(Order order)
    {
        try
        {   
            //Отправляем в базу данных
        }
        catch (Exception e)
        {
            throw new Exception();
        }
    }
}