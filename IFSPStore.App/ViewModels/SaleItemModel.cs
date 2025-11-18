namespace IFSPStore.App.ViewModels;

public record SaleItemModel(
    int Id,
    string Product,
    int ProductId,
    int Quantity,
    decimal UnitaryValue,
    decimal TotalValue
);
