namespace Web.Market;

public static class MarketTable
{
    public static string Table(List<MarketItem> items)
    {
        var rows = string.Join("", items.Select(MarketRows.Row));

        return $"""
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Price</th>
                </tr>
            </thead>
            <tbody>
                {rows}
            </tbody>
        </table>
        """;
    }
}