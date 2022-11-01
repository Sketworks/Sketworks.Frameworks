using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;

namespace Sketworks.Core.Extensions;

public static class ExtensionSketStaticRouteDirectory
{
    /// <summary>
    ///     Set the fallback and static page for the route
    /// </summary>
    /// <example>
    ///     app.SketStaticFileDirectory("setup")
    /// </example>
    /// <param name="resourcePath"> Set the directory name in your presentational directory</param>
    public static WebApplication UseSwStaticDirectoryFallBack(this WebApplication app,
        string resourcePath)
    {
        try
        {
            var directory = Path.Combine(app.Environment.ContentRootPath, resourcePath, "wwwroot");

            SetStaticFiles(app, directory);


            app.UseEndpoints(endpoint =>
            {
                string? path = null;
                if (resourcePath.Contains("admin", StringComparison.CurrentCultureIgnoreCase))
                {
                    path = "sw";
                }

                endpoint.MapFallbackToPage($"/{path ?? resourcePath}" + "/{*clientroutes:nonfile}",
                    $"/{resourcePath}/_{resourcePath}");
            });


            return app;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private static void SetStaticFiles(WebApplication app, string directory)
    {
        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider =
                new PhysicalFileProvider(directory),
            RequestPath = ""
        });
    }

    /// <summary>
    ///     Use this to set different static folder location
    /// </summary>
    /// <param name="resourcePath"> Set the relative path to your static folder</param>
    /// <param name="reqPath">Set the path location to access from your app</param>
    public static void SketStaticFileDirectory(this IApplicationBuilder app, string resourcePath,
        string? reqPath)
    {
        try
        {
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider =
                    new PhysicalFileProvider(Path.Combine(Environment.CurrentDirectory, resourcePath)),
                RequestPath = reqPath ?? ""
            });
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
