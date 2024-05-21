namespace OrderShopCart.Domain;

public interface IAggregateRoot
{
    ICollection<IDomainEvent> Events { get; }

    void ClearEvents();
}
