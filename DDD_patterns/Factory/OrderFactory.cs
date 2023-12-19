using DDD_patterns.Aggregates;
using DDD_patterns.Repositories;

namespace DDD_patterns.Factory;

public class OrderFactory
{
    private readonly OrderRepository _repository = new OrderRepository();
    

    public void CreateAggregates()
    {
        try
        {
            var newOrder = new Order
            {
                DetailsOrder = CreateDetailsOrder(),
                Address = "Some address",
                Products = new []{"Fruits"},
                Status = Status.OK
            };
            _repository.Set(newOrder);
        }
        catch (Exception e)
        {
            throw new Exception();
        }
        
    }

    private DetailsOrder CreateDetailsOrder()
    {
        return new DetailsOrder
        {
            Id = new Guid(),
            Sum = 3,
            DateTime = DateTime.Now
        };
    }
}