using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Layout;

namespace Web.Market;

public static class MarketEndpoints
{
    public static void MapMarket(this WebApplication app)
    {
        app.MapGet("/market", () =>
        {
            var items = Enumerable.Range(10, 10)
                .Select(id => new MarketItem
                {
                    Id = id,
                    Name = $"Item{id}",
                    Price = id * 10
                })
                .ToList();

            var content = MarketPage.Page(items);

            return Results.Content(
               LayoutHtml.Page(content),
               "text/html"
           );
        });
    }
}
public class MarketItem
{
    public int Id { get; init; }
    public string Name { get; init; } = "";
    public int Price { get; init; }
}
