

using DDD_patterns.Aggregates;

namespace DDD_patterns.Repositories;

public class BuyerRepository
{
    
    public void Set(Buyer buyer)
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