using DDD_patterns.Aggregates;
using DDD_patterns.Repositories;

namespace DDD_patterns.Factory;

public class BuyerFactory
{
    private readonly BuyerRepository _repository = new BuyerRepository();
    

    public void CreateAggregates()
    {
        try
        {
            var newBuyer = new Buyer
            {
                Client = CreateClient(),
                MethodBuy = MethodBuy.Card,
                TypeCard = TypeCard.MIR
            };
            _repository.Set(newBuyer);
            
        }
        catch (Exception e)
        {
            throw new Exception();
        }
        
    }

    private Client CreateClient()
    {
        return new Client
        {
            Id = new Guid(),
            Address = "Elsewhere",
            Name = "Polina",
            Surname = "Melnichuk"
        };
    }
}