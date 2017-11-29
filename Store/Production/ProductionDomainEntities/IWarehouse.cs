namespace Store.Production.ProductionDomainEntities
    {
    public interface IWarehouse
        {
        string Location { get; set; }
        int Capacity { get; set; }
        bool IsPhoneStored(IPhone phone);
        int GetPhoneQuantity(IPhone phone);
        void StorePhone(IPhone phone, int quantity);
        bool HasBoardersRestrictions();
        }
    }
