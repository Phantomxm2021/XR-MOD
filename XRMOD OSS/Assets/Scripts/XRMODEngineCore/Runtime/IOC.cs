// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineCore.Runtime.
// //
// // The XRMODEngineCore.Runtime cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace XRMODEngineCore.Runtime
{
    public class Ioc
    {
        public Dictionary<Type, object> InstanceMap { get; private set; }

        public Ioc()
        {
            InstanceMap = new Dictionary<Type, object>();
        }

        public bool Register<T>(T _instance) where T : class
        {
            return InstanceMap.TryAdd(typeof(T), _instance);
        }

        public bool UnRegister<T>() where T : class
        {
            if (!InstanceMap.TryGetValue(typeof(T), out var tmp_Instance)) return false;

            switch (tmp_Instance)
            {
                case IReleaseCommand tmp_Command:
                    tmp_Command.Release();
                    break;
                case IModule tmp_Module:
                    tmp_Module.StopModule();
                    break;
            }

            InstanceMap.Remove(typeof(T));
            return true;
        }


        public bool UnRegister(Type _type)
        {
            if (!InstanceMap.TryGetValue(_type, out var tmp_Instance)) return false;

            switch (tmp_Instance)
            {
                case IReleaseCommand tmp_Command:
                    tmp_Command.Release();
                    break;
                case IModule tmp_Module:
                    tmp_Module.StopModule();
                    break;
            }

            InstanceMap.Remove(_type);
            return true;
        }

        public void UnRegisterAll()
        {
            List<Type> tmp_Objects = InstanceMap.Select(_pair => _pair.Key).ToList();
            foreach (var tmp_Obj in tmp_Objects)
            {
                UnRegister(tmp_Obj);
            }
        }

        public T Resolve<T>() where T : class
        {
            return InstanceMap.TryGetValue(typeof(T), out var tmp_ResolveObj) == true ? (T) tmp_ResolveObj : default(T);
        }
    }
}