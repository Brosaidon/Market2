namespace Web.Layout;

public static class LayoutHtml
{
    public static string Page(string content)
    => $"""
        <!doctype html>
        <html>
        <head>
            <meta charset="utf-8">
            <title>Market</title>
            <link rel="stylesheet" href="https://unpkg.com/@picocss/pico@latest/css/pico.min.css">
            <script src="https://unpkg.com/htmx.org@1.9.10"></script>
        </head>
        <body class="container">
        <header>
            <h1>Market</h1>
        </header>
            <main id="content">
           {content} 
            </main>

            <footer>
                <p>Market &copy; 2026</p>
            </footer>
        </body>
        </html>
        """;
}