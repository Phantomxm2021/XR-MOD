// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Utility
{
    public  class LocationUtility:IUtility
    {
        private static double ToRadians(double _angle)
        {
            return (Math.PI / 180) * _angle;
        }

        // Haversine distance
        public static double DistanceBetweenPoints(Vector2 _p1, Vector2 _p2)
        {
            double R = 6371e3; // Earth's radius in metres
            double radLat1 = ToRadians(_p1.x);
            double radLat2 = ToRadians(_p2.x);
            double radLon1 = ToRadians(_p1.y);
            double radLon2 = ToRadians(_p2.y);
            double deltaLat = radLat2 - radLat1;
            double deltaLon = radLon2 - radLon1;

            // the square of half the chord length between the points
            double tmp_A = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) + Math.Cos(radLat1) * Math.Cos(radLat2) *
                Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
            // angular distance in radians
            double tmp_C = 2 * Math.Atan2(Math.Sqrt(tmp_A), Math.Sqrt(1 - tmp_A));
            // distance in metres
            double tmp_D = R * tmp_C;

            return tmp_D;
        }
    }
}