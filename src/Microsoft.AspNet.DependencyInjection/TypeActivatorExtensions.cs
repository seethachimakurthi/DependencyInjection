﻿using System;

namespace Microsoft.AspNet.DependencyInjection
{
    public static class TypeActivatorExtensions
    {
        public static T CreateInstance<T>(this ITypeActivator activator, IServiceProvider serviceProvider, params object[] parameters)
        {
            if (activator == null)
            {
                throw new ArgumentNullException("activator");
            }

            return (T)activator.CreateInstance(serviceProvider, typeof(T), parameters);
        }
    }
}