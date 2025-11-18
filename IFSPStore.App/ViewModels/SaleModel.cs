using IFSPStore.Domain.Entities;
namespace IFSPStore.App.ViewModels;

public record SaleModel(
    int Id,
    DateTime Date,
    decimal TotalValue,
    string Salesman,
    int SalesmanId,
    string Customer,
    int CustomerId,
    List<SaleItem> Items
);
