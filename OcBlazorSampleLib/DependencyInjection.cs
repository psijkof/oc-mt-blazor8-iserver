using Microsoft.Extensions.DependencyInjection;
using OcBlazorSampleLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcBlazorSampleLib;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationDependecies(this IServiceCollection services)
    {
        return services;
    }
}
