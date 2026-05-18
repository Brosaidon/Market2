namespace Web.Layout;

public static class LayoutEndpoints
{
    public static void MapLayout(this WebApplication app)
    {
        app.MapGet("/", () => Results.Content(LayoutHtml.Page("<p>Home</p>"),
        "text/html")
    );
    }
}
