using Web.Layout;
using Web.marketHtml;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(LayoutHtml.Page("<p>Welcome to Market</p>"),
        "text/html")
);

app.MapGet("/market", () => Results.Content(MarketHtml.Page(""), "text/html"));

app.Run();
