﻿using System;

namespace Kros.AspNetCore.ServiceDiscovery
{
    /// <summary>
    /// Interface which describe provider for obtaining service address.
    /// </summary>
    public interface IServiceDiscoveryProvider
    {
        /// <summary>
        /// Gets the service URI.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <returns>Service URI if exist.</returns>
        /// <exception cref="ArgumentException">If service <paramref name="serviceName"/> does not exist.</exception>
        Uri GetService(string serviceName);

        /// <summary>
        /// Gets the specific path.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <param name="pathName">Name of the path.</param>
        /// <returns>
        /// URI <paramref name="serviceName"/><paramref name="pathName"/>
        /// </returns>
        /// <exception cref="ArgumentException">If service <paramref name="serviceName"/> does not exist.</exception>
        Uri GetPath(string serviceName, string pathName);

        /// <summary>
        /// Gets the service URI.
        /// </summary>
        /// <param name="serviceType">Enum with service type.</param>
        /// <returns>Service URI if exist.</returns>
        /// <exception cref="ArgumentException">If service <paramref name="serviceType"/> does not exist.</exception>
        Uri GetService(Enum serviceType);

        /// <summary>
        /// Gets the specific path.
        /// </summary>
        /// <param name="serviceType">Enum with service type.</param>
        /// <param name="pathName">Name of the path.</param>
        /// <returns>
        /// URI <paramref name="serviceType"/><paramref name="pathName"/>
        /// </returns>
        /// <exception cref="ArgumentException">If service <paramref name="serviceType"/> does not exist.</exception>
        Uri GetPath(Enum serviceType, string pathName);
    }
}
