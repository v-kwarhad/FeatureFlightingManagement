﻿using AppInsights.EnterpriseTelemetry.Context;

namespace Microsoft.PS.FlightingService.Caching
{
    public static class CacheLogContext
    {
        public static DependencyContextMetadata GetMetadata(string host, string redisCommand, string key) => new DependencyContextMetadata
        {
            DependencyName = $"{redisCommand} {key}",
            DependencyType = "REDIS",
            RequestDetails = $"{host} {redisCommand} {key}",
            TargetSystemName = host,
            ShouldLogPerformance = true
        };
    }
}