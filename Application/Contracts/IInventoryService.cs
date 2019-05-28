namespace CleanArchitecture.Application.Contracts
{
    public interface IInventoryService
    {
        void NotifySaleOcurred(int productId, int quantity);
    }
}