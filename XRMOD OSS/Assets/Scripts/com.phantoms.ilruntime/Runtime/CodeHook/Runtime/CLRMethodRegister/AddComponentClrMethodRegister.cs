// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ILRuntime.Runtime.CodeHook.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.CLRBinding.Adapter;
using ILRuntime.Reflection;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using UnityEngine;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace com.Phantoms.ILRuntime.Runtime
{
    public class AddComponentClrMethodRegister : AbstractRegister
    {
        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);
            var tmp_AddComponentMethod = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(i => i.Name == "AddComponent" && i.GetGenericArguments().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_AddComponentMethod, AddComponent);
        }

        /// <summary>
        /// AddComponent
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException"></exception>
        private unsafe StackObject* AddComponent(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;

            var ptr = __esp - 1;
            GameObject instance = StackObject.ToObject(ptr, __domain, __mStack) as GameObject;
            if (instance == null)
                throw new NullReferenceException();
            __intp.Free(ptr);

            var tmp_GenericArgument = __method.GenericArguments;
            if (tmp_GenericArgument is not {Length: 1}) return __esp;
            var tmp_Type = tmp_GenericArgument[0];
            object tmp_Res;
            if (tmp_Type is CLRType)
            {
                tmp_Res = instance.AddComponent(tmp_Type.TypeForCLR);
            }
            else
            {
                //We need to create the code in ARExperience manually
                //We could not use `new` key word to create the MonoBehaviour
                //new ILTypeInstance(tmp_Type as ILType, false);

                ILTypeInstance tmp_ILInstance = new ILTypeInstance(tmp_Type as ILType, false);

                //Add the adapter for our game object
                if (tmp_ILInstance.CLRInstance.GetType() == typeof(UIMonoBehaviourAdaptor.Adapter))
                {
                    var tmp_AdapterInstance = instance.AddComponent<UIMonoBehaviourAdaptor.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.Awake();
                }
                else if (tmp_ILInstance.CLRInstance.GetType() == typeof(XRBaseInteractableAdapter.Adapter))
                {
                    var tmp_AdapterInstance = instance.AddComponent<XRBaseInteractableAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;

                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.DoAwake();
                }
                else if (tmp_ILInstance.CLRInstance.GetType() == typeof(XRBaseInteractorAdapter.Adapter))
                {
                    var tmp_AdapterInstance = instance.AddComponent<XRBaseInteractorAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.DoAwake();
                }
                else if (tmp_ILInstance.CLRInstance.GetType() == typeof(XRGrabInteractableAdapter.Adapter))
                {
                    var tmp_AdapterInstance = instance.AddComponent<XRGrabInteractableAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.DoAwake();
                }
                else if (tmp_ILInstance.CLRInstance.GetType() ==
                         typeof(ActionBasedContinuousMoveProviderAdapter.Adapter))
                {
                    var tmp_AdapterInstance = instance.AddComponent<ActionBasedContinuousMoveProviderAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.DoAwake();
                }
                else if (tmp_ILInstance.CLRInstance.GetType() == typeof(ConstrainedMoveProviderAdapter.Adapter))
                {
                    var tmp_AdapterInstance = instance.AddComponent<ConstrainedMoveProviderAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.DoAwake();
                }
                else if (tmp_ILInstance.CLRInstance.GetType() ==
                         typeof(DeviceBasedContinuousMoveProviderAdapter.Adapter))
                {
                    var tmp_AdapterInstance = instance.AddComponent<DeviceBasedContinuousMoveProviderAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.DoAwake();
                }
                else if (tmp_ILInstance.CLRInstance.GetType() ==
                         typeof(DeviceBasedContinuousTurnProviderAdapter.Adapter))
                {
                    var tmp_AdapterInstance = instance.AddComponent<DeviceBasedContinuousTurnProviderAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.DoAwake();
                }
                else if (tmp_ILInstance.CLRInstance.GetType() ==
                         typeof(DeviceBasedSnapTurnProviderAdapter.Adapter))
                {
                    var tmp_AdapterInstance = instance.AddComponent<DeviceBasedSnapTurnProviderAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.DoAwake();
                }
                else if (tmp_ILInstance.CLRInstance.GetType() ==
                         typeof(GrabMoveProviderAdapter.Adapter))
                {
                    var tmp_AdapterInstance = instance.AddComponent<GrabMoveProviderAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.DoAwake();
                }
                else if (tmp_ILInstance.CLRInstance.GetType() ==
                         typeof(LocomotionProviderAdapter.Adapter))
                {
                    var tmp_AdapterInstance = instance.AddComponent<LocomotionProviderAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.DoAwake();
                }
                else if (tmp_ILInstance.CLRInstance.GetType() ==
                         typeof(TeleportationProviderAdapter.Adapter))
                {
                    var tmp_AdapterInstance = instance.AddComponent<TeleportationProviderAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.DoAwake();
                }
                else
                {
                    var tmp_AdapterInstance = instance.AddComponent<MonoBehaviourAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    tmp_Res = tmp_AdapterInstance.ILInstance;
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }

                    tmp_AdapterInstance.Awake();
                }
            }

            return ILIntepreter.PushObject(ptr, __mStack, tmp_Res);
        }
    }
}