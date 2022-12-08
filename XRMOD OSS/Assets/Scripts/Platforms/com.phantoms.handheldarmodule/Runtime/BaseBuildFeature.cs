// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.ARAlgorithm.Runtime.
// //
// // The com.Phantoms.ARAlgorithm.Runtime cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using HandheldARModule.Runtime.FeaturesDecorator;
using HandheldARModule.Runtime.Models;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime
{
    public abstract class BaseBuildFeature<T> where T : AbstractDecorator, new()
    {
        protected T Create(params object[] _data)
        {
            T tmp_AlgorithmDecorator = null;
            var tmp_Decorator = CheckAlreadyDecorator();
            if (tmp_Decorator != null)
            {
                return tmp_Decorator;
            }

            if (_data != null && _data.Length == 0)
            {
                System.Type[] tmp_Types = new System.Type[_data.Length];
                for (int tmp_Idx = 0; tmp_Idx < tmp_Types.Length; tmp_Idx++)
                {
                    tmp_Types[tmp_Idx] = _data[tmp_Idx].GetType();
                }

                var tmp_Ctors = typeof(T).GetConstructor(tmp_Types);
                tmp_AlgorithmDecorator = (T) tmp_Ctors.Invoke(_data);
            }
            else
            {
                tmp_AlgorithmDecorator = new T();
            }

            var tmp_ARComp = IocContainer.GetIoc.Resolve<ARComponentModel>();
            tmp_ARComp.AbstractDecorators.Add(typeof(T), tmp_AlgorithmDecorator);
            tmp_AlgorithmDecorator.StartAlgorithm();
            return tmp_AlgorithmDecorator;
        }

        protected void ReleaseFeature()
        {
            var tmp_Feature = CheckAlreadyDecorator();
            if (tmp_Feature != null)
                tmp_Feature.StopAlgorithm();
        }

        private T CheckAlreadyDecorator()
        {
            if (IocContainer.GetIoc.Resolve<ARComponentModel>().AbstractDecorators
                .TryGetValue(typeof(T), out var tmp_Decorator))
                return tmp_Decorator as T;
            return null;
        }
    }
}