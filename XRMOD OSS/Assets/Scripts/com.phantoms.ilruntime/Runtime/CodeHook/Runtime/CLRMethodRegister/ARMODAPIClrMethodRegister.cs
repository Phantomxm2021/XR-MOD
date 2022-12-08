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
using com.Phantoms.ARMODPackageTools.Runtime;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.Utils;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.Video;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace com.Phantoms.ILRuntime.Runtime
{
    public class ARMODAPIClrMethodRegister : AbstractRegister
    {
        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);
            Type tmp_APIType = typeof(com.Phantoms.ARMODAPI.Runtime.API);
            var tmp_LoadAssetOfType = tmp_APIType.GetMethods().ToList()
                .Find(_i => _i.Name == "LoadAsset" && _i.GetGenericArguments().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_LoadAssetOfType, LoadAssetOfType);


            var tmp_Args = new Type[] {typeof(System.String), typeof(System.String)};
            var tmp_Method =
                tmp_APIType.GetMethod("LoadAssetAsync", ConstData.CONST_BINDING_FLAGS, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, LoadAssetOfTypeAsync);
        }

        private unsafe  StackObject* LoadAssetOfType(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            var tmp_GenericArgument = __method.GenericArguments;

            if (tmp_GenericArgument == null || tmp_GenericArgument.Length != 1) return __esp;
            var tmp_Type = tmp_GenericArgument[0];

            if (tmp_Type.TypeForCLR == typeof(GameObject))
            {
                LoadGenericResource<GameObject>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(Texture2D))
            {
                LoadGenericResource<Texture2D>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(Material))
            {
                LoadGenericResource<Material>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(VideoClip))
            {
                LoadGenericResource<VideoClip>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(AudioClip))
            {
                LoadGenericResource<AudioClip>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(Animation))
            {
                LoadGenericResource<Animation>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(Sprite))
            {
                LoadGenericResource<Sprite>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(SpriteAtlas))
            {
                LoadGenericResource<SpriteAtlas>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(Font))
            {
                LoadGenericResource<Font>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(TextAsset))
            {
                LoadGenericResource<TextAsset>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(Shader))
            {
                LoadGenericResource<Shader>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(PhysicMaterial))
            {
                LoadGenericResource<PhysicMaterial>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(ComputeShader))
            {
                LoadGenericResource<ComputeShader>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }

            return __ret;
        }


        private unsafe StackObject* LoadAssetOfTypeAsync(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);


            System.String @_wannaLoadAssetName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_projectName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            var tmp_GenericArgument = __method.GenericArguments;

            if (tmp_GenericArgument == null || tmp_GenericArgument.Length != 1) return __esp;
            var tmp_Type = tmp_GenericArgument[0];

            if (tmp_Type.TypeForCLR == typeof(GameObject))
            {
                return LoadGenericResourceAsync<GameObject>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(Texture2D))
            {
                return LoadGenericResourceAsync<Texture2D>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(Material))
            {
                return LoadGenericResourceAsync<Material>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(VideoClip))
            {
                return LoadGenericResourceAsync<VideoClip>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(AudioClip))
            {
                return LoadGenericResourceAsync<AudioClip>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(Animation))
            {
                return LoadGenericResourceAsync<Animation>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(Sprite))
            {
                return LoadGenericResourceAsync<Sprite>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(SpriteAtlas))
            {
                return LoadGenericResourceAsync<SpriteAtlas>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(Font))
            {
                return LoadGenericResourceAsync<Font>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(TextAsset))
            {
                return LoadGenericResourceAsync<TextAsset>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(Shader))
            {
                return LoadGenericResourceAsync<Shader>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(PhysicMaterial))
            {
                return LoadGenericResourceAsync<PhysicMaterial>(__mStack, @_projectName, @_wannaLoadAssetName,
                    __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(ComputeShader))
            {
                return LoadGenericResourceAsync<ComputeShader>(__mStack, @_projectName, @_wannaLoadAssetName,
                    __ret);
            }

            return __ret;
        }

        private unsafe StackObject* LoadGenericResourceAsync<T>(AutoList  __mStack, string _projectName,
            string _wannaLoadAssetName, StackObject* __ret) where T : UnityEngine.Object
        {
            var result_of_this_method =
                BasePackageLoaderUtility.LoadAssetFromPackage<T>(@_projectName, @_wannaLoadAssetName);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        private unsafe void LoadGenericResource<T>(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack,
            StackObject* ptr_of_this_method, AppDomain __domain) where T : UnityEngine.Object
        {
            System.Action<T> @_loadedCallback =
                (System.Action<T>) typeof(System.Action<UnityEngine.GameObject>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_wannaLoadedAssetName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_projectName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            BasePackageLoaderUtility.LoadAssetFromPackage(@_projectName, @_wannaLoadedAssetName, @_loadedCallback);
        }
    }
}