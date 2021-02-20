﻿using System;

namespace Wischi.LD46.KeepItAlive.BridgeNet
{
    public static class TreeConfigurations
    {
        public static TreeConfiguration ReleaseConfig { get; }
            = new TreeConfigurationBuilder()
            {
                FullGrownTree = TimeSpan.FromDays(365 * 2), // two years
                TickRate = TimeSpan.FromMinutes(15),
                WaterMax = TimeSpan.FromDays(16),
                WaterMin = TimeSpan.FromDays(5),
                ScreenRefreshRate = TimeSpan.FromMinutes(1),
                DurationUntilDeadWhenUnhealthy = TimeSpan.FromDays(14),
                DurationUntilFullHealthWhenHealthy = TimeSpan.FromDays(14),
                InitialWaterLevel = 0.3,
                SettingPrefix = "bonsai"
            }.Build();

        public static TreeConfiguration DebugConfig { get; }
            = new TreeConfigurationBuilder()
            {
                FullGrownTree = TimeSpan.FromMinutes(1),
                TickRate = TimeSpan.FromMilliseconds(10),
                WaterMax = TimeSpan.FromSeconds(16),
                WaterMin = TimeSpan.FromSeconds(5),
                ScreenRefreshRate = TimeSpan.FromMilliseconds(100),
                DurationUntilDeadWhenUnhealthy = TimeSpan.FromSeconds(10),
                DurationUntilFullHealthWhenHealthy = TimeSpan.FromSeconds(10),
                InitialWaterLevel = 1,
                SettingPrefix = "debug"
            }.Build();


        public static TreeConfiguration LudumDare46Test { get; }
            = new TreeConfigurationBuilder()
            {
                FullGrownTree = TimeSpan.FromHours(2),
                TickRate = TimeSpan.FromMilliseconds(100),
                ScreenRefreshRate = TimeSpan.FromMilliseconds(1000),
                WaterMax = TimeSpan.FromMinutes(15),
                WaterMin = TimeSpan.FromMinutes(30),
                DurationUntilDeadWhenUnhealthy = TimeSpan.FromMinutes(15),
                DurationUntilFullHealthWhenHealthy = TimeSpan.FromMinutes(15),
                InitialWaterLevel = 0.3,
                SettingPrefix = "LD46"
            }.Build();
    }
}