namespace Web.Market;

public static class MarketPage
{
    public static string Page(List<MarketItem> items)
    {
        return $"""
        <section>
            <h2>Market</h2>
            {MarketTable.Table(items)}
        </section>
        """;
    }
}