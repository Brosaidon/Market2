

namespace Web.marketHtml;

public static class MarketHtml
{
    public static string Page(string content)
    => $"""
<body>

<script src="https://unpkg.com/htmx.org@1.9.12"></script>

<h2>Market</h2>

<table border="1">
    <tr hx-get="/select/food" hx-target="#details" hx-swap="innerHTML">
        <td>Food</td>
        <td>80</td>
    </tr>

    <tr hx-get="/select/metal" hx-target="#details" hx-swap="innerHTML">
        <td>Metal</td>
        <td>120</td>
    </tr>
</table>

<hr>

<div id="details">
    Click a commodity
</div>
</body>
</html>
""";
}