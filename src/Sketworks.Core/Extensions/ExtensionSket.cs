using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Sketworks.Core.Extensions;

/// <summary>
///     This extension class is used for Dependency injections
/// </summary>
public static class ExtensionSket
{
    /// <summary>
    ///     Initial setup for Sket for dependency injection.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="settings"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static IServiceCollection AddSketWorks(
        this IServiceCollection services)
    {


        return services;
    }


    /// <summary>
    ///     Use to add services by namespace name
    /// </summary>
    /// <param name="services"></param>
    /// <param name="searchNamespace"></param>
    /// <param name="userRepo"></param>
    /// <returns></returns>
    public static IServiceCollection SketAddServices(this IServiceCollection services, string? searchNamespace,
        string? userRepo = null)
    {
        return AddServices(services, searchNamespace, userRepo);
    }

    /// <summary>
    /// Auto DI
    /// </summary>
    /// <param name="services"></param>
    /// <param name="searchNamespace"></param>
    /// <param name="userRepo"></param>
    /// <returns></returns>
    public static IServiceCollection AddServices(IServiceCollection services, string? searchNamespace,
        string? userRepo = null)
    {
        // //get assemblies
        //
        // var loadAssemblies = AppDomain.CurrentDomain.GetAssemblies();
        // var types = (from d in loadAssemblies
        //              where !d.IsDynamic
        //              from type in d?.ExportedTypes
        //              where type.BaseType?.Namespace != null && type.BaseType.Namespace.Contains(searchNamespace)
        //              where type.Namespace != null && !type.Namespace.Contains(searchNamespace)
        //              select type).AsEnumerable();
        //
        //
        // foreach (var type in types)
        // {
        //     //Todo improve logic to support repository own interfaces
        //
        //
        //     if (type.BaseType.Name.Contains(userRepo ?? typeof(SketUserRepository<>).Name) && !type.IsAbstract)
        //     {
        //         Type customInterface;
        //
        //         var typeInterfaces = type.GetInterfaces().ToList()
        //             .Find(i => Regex.IsMatch(i.Name, typeof(ISketUserRepository<>).Name));
        //
        //         if (typeInterfaces is not null)
        //         {
        //             customInterface = typeInterfaces;
        //             services.Add(new(customInterface, type, ServiceLifetime.Scoped));
        //         }
        //     }
        //
        //     services.Add(new(type, type, ServiceLifetime.Scoped));
        // }

        return services;
    }


}