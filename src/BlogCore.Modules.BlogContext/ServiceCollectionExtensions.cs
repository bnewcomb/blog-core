﻿using Microsoft.Extensions.DependencyInjection;

namespace BlogCore.Modules.BlogContext
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlogModule(this IServiceCollection services)
        {
            return services;
        }
    }
}
