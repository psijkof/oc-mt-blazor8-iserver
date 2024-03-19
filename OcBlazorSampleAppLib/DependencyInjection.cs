using Microsoft.Extensions.DependencyInjection;
using OcBlazorSampleAppLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcBlazorSampleAppLib;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationDependecies(this IServiceCollection services)
    {
        return services;
    }
}
