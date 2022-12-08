using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Generated
{
    unsafe class LeanAudioOptions_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LeanAudioOptions);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("setFrequency", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setFrequency_0);
            args = new Type[]{typeof(UnityEngine.Vector3[])};
            method = type.GetMethod("setVibrato", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setVibrato_1);
            args = new Type[]{};
            method = type.GetMethod("setWaveSine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setWaveSine_2);
            args = new Type[]{};
            method = type.GetMethod("setWaveSquare", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setWaveSquare_3);
            args = new Type[]{};
            method = type.GetMethod("setWaveSawtooth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setWaveSawtooth_4);
            args = new Type[]{};
            method = type.GetMethod("setWaveNoise", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setWaveNoise_5);
            args = new Type[]{typeof(global::LeanAudioOptions.LeanAudioWaveStyle)};
            method = type.GetMethod("setWaveStyle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setWaveStyle_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("setWaveNoiseScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setWaveNoiseScale_7);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("setWaveNoiseInfluence", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setWaveNoiseInfluence_8);

            field = type.GetField("waveStyle", flag);
            app.RegisterCLRFieldGetter(field, get_waveStyle_0);
            app.RegisterCLRFieldSetter(field, set_waveStyle_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_waveStyle_0, AssignFromStack_waveStyle_0);
            field = type.GetField("vibrato", flag);
            app.RegisterCLRFieldGetter(field, get_vibrato_1);
            app.RegisterCLRFieldSetter(field, set_vibrato_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_vibrato_1, AssignFromStack_vibrato_1);
            field = type.GetField("modulation", flag);
            app.RegisterCLRFieldGetter(field, get_modulation_2);
            app.RegisterCLRFieldSetter(field, set_modulation_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_modulation_2, AssignFromStack_modulation_2);
            field = type.GetField("frequencyRate", flag);
            app.RegisterCLRFieldGetter(field, get_frequencyRate_3);
            app.RegisterCLRFieldSetter(field, set_frequencyRate_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_frequencyRate_3, AssignFromStack_frequencyRate_3);
            field = type.GetField("waveNoiseScale", flag);
            app.RegisterCLRFieldGetter(field, get_waveNoiseScale_4);
            app.RegisterCLRFieldSetter(field, set_waveNoiseScale_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_waveNoiseScale_4, AssignFromStack_waveNoiseScale_4);
            field = type.GetField("waveNoiseInfluence", flag);
            app.RegisterCLRFieldGetter(field, get_waveNoiseInfluence_5);
            app.RegisterCLRFieldSetter(field, set_waveNoiseInfluence_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_waveNoiseInfluence_5, AssignFromStack_waveNoiseInfluence_5);
            field = type.GetField("useSetData", flag);
            app.RegisterCLRFieldGetter(field, get_useSetData_6);
            app.RegisterCLRFieldSetter(field, set_useSetData_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_useSetData_6, AssignFromStack_useSetData_6);
            field = type.GetField("stream", flag);
            app.RegisterCLRFieldGetter(field, get_stream_7);
            app.RegisterCLRFieldSetter(field, set_stream_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_stream_7, AssignFromStack_stream_7);


            app.RegisterCLRCreateDefaultInstance(type, () => new global::LeanAudioOptions());
            app.RegisterCLRCreateArrayInstance(type, s => new global::LeanAudioOptions[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* setFrequency_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @frequencyRate = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LeanAudioOptions instance_of_this_method = (global::LeanAudioOptions)typeof(global::LeanAudioOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setFrequency(@frequencyRate);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setVibrato_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3[] @vibrato = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LeanAudioOptions instance_of_this_method = (global::LeanAudioOptions)typeof(global::LeanAudioOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setVibrato(@vibrato);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setWaveSine_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LeanAudioOptions instance_of_this_method = (global::LeanAudioOptions)typeof(global::LeanAudioOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setWaveSine();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setWaveSquare_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LeanAudioOptions instance_of_this_method = (global::LeanAudioOptions)typeof(global::LeanAudioOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setWaveSquare();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setWaveSawtooth_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LeanAudioOptions instance_of_this_method = (global::LeanAudioOptions)typeof(global::LeanAudioOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setWaveSawtooth();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setWaveNoise_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LeanAudioOptions instance_of_this_method = (global::LeanAudioOptions)typeof(global::LeanAudioOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setWaveNoise();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setWaveStyle_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LeanAudioOptions.LeanAudioWaveStyle @style = (global::LeanAudioOptions.LeanAudioWaveStyle)typeof(global::LeanAudioOptions.LeanAudioWaveStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LeanAudioOptions instance_of_this_method = (global::LeanAudioOptions)typeof(global::LeanAudioOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setWaveStyle(@style);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setWaveNoiseScale_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @waveScale = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LeanAudioOptions instance_of_this_method = (global::LeanAudioOptions)typeof(global::LeanAudioOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setWaveNoiseScale(@waveScale);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setWaveNoiseInfluence_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @influence = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LeanAudioOptions instance_of_this_method = (global::LeanAudioOptions)typeof(global::LeanAudioOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setWaveNoiseInfluence(@influence);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_waveStyle_0(ref object o)
        {
            return ((global::LeanAudioOptions)o).waveStyle;
        }

        static StackObject* CopyToStack_waveStyle_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LeanAudioOptions)o).waveStyle;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_waveStyle_0(ref object o, object v)
        {
            ((global::LeanAudioOptions)o).waveStyle = (global::LeanAudioOptions.LeanAudioWaveStyle)v;
        }

        static StackObject* AssignFromStack_waveStyle_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            global::LeanAudioOptions.LeanAudioWaveStyle @waveStyle = (global::LeanAudioOptions.LeanAudioWaveStyle)typeof(global::LeanAudioOptions.LeanAudioWaveStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((global::LeanAudioOptions)o).waveStyle = @waveStyle;
            return ptr_of_this_method;
        }

        static object get_vibrato_1(ref object o)
        {
            return ((global::LeanAudioOptions)o).vibrato;
        }

        static StackObject* CopyToStack_vibrato_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LeanAudioOptions)o).vibrato;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_vibrato_1(ref object o, object v)
        {
            ((global::LeanAudioOptions)o).vibrato = (UnityEngine.Vector3[])v;
        }

        static StackObject* AssignFromStack_vibrato_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3[] @vibrato = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LeanAudioOptions)o).vibrato = @vibrato;
            return ptr_of_this_method;
        }

        static object get_modulation_2(ref object o)
        {
            return ((global::LeanAudioOptions)o).modulation;
        }

        static StackObject* CopyToStack_modulation_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LeanAudioOptions)o).modulation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_modulation_2(ref object o, object v)
        {
            ((global::LeanAudioOptions)o).modulation = (UnityEngine.Vector3[])v;
        }

        static StackObject* AssignFromStack_modulation_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3[] @modulation = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LeanAudioOptions)o).modulation = @modulation;
            return ptr_of_this_method;
        }

        static object get_frequencyRate_3(ref object o)
        {
            return ((global::LeanAudioOptions)o).frequencyRate;
        }

        static StackObject* CopyToStack_frequencyRate_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LeanAudioOptions)o).frequencyRate;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_frequencyRate_3(ref object o, object v)
        {
            ((global::LeanAudioOptions)o).frequencyRate = (System.Int32)v;
        }

        static StackObject* AssignFromStack_frequencyRate_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @frequencyRate = ptr_of_this_method->Value;
            ((global::LeanAudioOptions)o).frequencyRate = @frequencyRate;
            return ptr_of_this_method;
        }

        static object get_waveNoiseScale_4(ref object o)
        {
            return ((global::LeanAudioOptions)o).waveNoiseScale;
        }

        static StackObject* CopyToStack_waveNoiseScale_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LeanAudioOptions)o).waveNoiseScale;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_waveNoiseScale_4(ref object o, object v)
        {
            ((global::LeanAudioOptions)o).waveNoiseScale = (System.Single)v;
        }

        static StackObject* AssignFromStack_waveNoiseScale_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @waveNoiseScale = *(float*)&ptr_of_this_method->Value;
            ((global::LeanAudioOptions)o).waveNoiseScale = @waveNoiseScale;
            return ptr_of_this_method;
        }

        static object get_waveNoiseInfluence_5(ref object o)
        {
            return ((global::LeanAudioOptions)o).waveNoiseInfluence;
        }

        static StackObject* CopyToStack_waveNoiseInfluence_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LeanAudioOptions)o).waveNoiseInfluence;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_waveNoiseInfluence_5(ref object o, object v)
        {
            ((global::LeanAudioOptions)o).waveNoiseInfluence = (System.Single)v;
        }

        static StackObject* AssignFromStack_waveNoiseInfluence_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @waveNoiseInfluence = *(float*)&ptr_of_this_method->Value;
            ((global::LeanAudioOptions)o).waveNoiseInfluence = @waveNoiseInfluence;
            return ptr_of_this_method;
        }

        static object get_useSetData_6(ref object o)
        {
            return ((global::LeanAudioOptions)o).useSetData;
        }

        static StackObject* CopyToStack_useSetData_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LeanAudioOptions)o).useSetData;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_useSetData_6(ref object o, object v)
        {
            ((global::LeanAudioOptions)o).useSetData = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_useSetData_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @useSetData = ptr_of_this_method->Value == 1;
            ((global::LeanAudioOptions)o).useSetData = @useSetData;
            return ptr_of_this_method;
        }

        static object get_stream_7(ref object o)
        {
            return ((global::LeanAudioOptions)o).stream;
        }

        static StackObject* CopyToStack_stream_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LeanAudioOptions)o).stream;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_stream_7(ref object o, object v)
        {
            ((global::LeanAudioOptions)o).stream = (global::LeanAudioStream)v;
        }

        static StackObject* AssignFromStack_stream_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            global::LeanAudioStream @stream = (global::LeanAudioStream)typeof(global::LeanAudioStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LeanAudioOptions)o).stream = @stream;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new global::LeanAudioOptions();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
