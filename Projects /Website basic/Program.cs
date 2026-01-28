var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 
     Results.Content("""
    <html>
        <head>
            <title>Hello C#</title>
        </head>
        <body>
            <h1>Hello World from C# Website 🚀</h1>
        </body>
    </html>
    """, "text/html")
);

app.Run();
