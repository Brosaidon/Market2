using Web.Layout;
using Web.Market;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapMarket();
app.MapLayout();
app.Run();
