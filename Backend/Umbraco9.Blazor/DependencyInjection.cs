﻿using Microsoft.Extensions.DependencyInjection;
using Umbraco9.Blazor.Services;
using Umbraco9.Core.Services;

namespace Umbraco9.Blazor
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomBlazorServices(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddSingleton<IContentDeliveryService, ContentDeliveryService>();
            return services;
        }
    }
}
