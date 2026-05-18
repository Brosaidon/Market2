namespace Web.Market;

public static class MarketRows
{
    public static string Row(MarketItem item)
    {
        return $"""
            <tr>
                <td>{item.Name}</td>
                <td>{item.Price}</td>
            </tr>
        """;
    }
}