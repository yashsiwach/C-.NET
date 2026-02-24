namespace emptyCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseStaticFiles();
            //app.MapDefaultControllerRoute();
            //app.MapGet("/", () => "Hello World!");
            //app.Run(async(context)=> {
            //    await context.Response.WriteAsync("okbooss");
            //    });
            //app.Use(async (context,next) => {
            //    await context.Response.WriteAsync("okboosps");
            //    await next(context);
            //});
            //app.Run(async (context) => {
            //    await context.Response.WriteAsync("okbooss");
            //});
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapControllers();
           
            //app.UseRouting();
            //app.UseEndpoints(static endpoints =>
            //{
            //    endpoints.MapGet("/Home", async (context) =>
            //    {
            //        await context.Response.WriteAsync("this is home");
            //    });
            //    endpoints.MapPost("/Home", async (context) =>
            //    {
            //        await context.Response.WriteAsync("this is home");
            //    });
            //    endpoints.MapPut("/Home", async (context) =>
            //    {
            //        await context.Response.WriteAsync("this is home");
            //    });
            //    endpoints.MapDelete("/Home", async (context) =>
            //    {
            //        await context.Response.WriteAsync("this is home");
            //    });
            //});
            //app.Run(async (HttpContext context) =>
            //{
            //    await context.Response.WriteAsync("this is main");
            //});
            //app.Map("/Home", () => "Hello World!");
            //app.MapGet("/Home", () => "Hello World!");
            //app.MapPost("/Home", () => "Hello World!");
            //app.MapPut("/Home", () => "Hello World!");
            //app.MapDelete("/Home", () => "Hello World!");
            app.Run();
        }
    }
}
