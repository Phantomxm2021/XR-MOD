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
    unsafe class LeanAudio_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LeanAudio);
            args = new Type[]{};
            method = type.GetMethod("options", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, options_0);
            args = new Type[]{typeof(UnityEngine.AnimationCurve), typeof(UnityEngine.AnimationCurve), typeof(global::LeanAudioOptions)};
            method = type.GetMethod("createAudioStream", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, createAudioStream_1);
            args = new Type[]{typeof(UnityEngine.AnimationCurve), typeof(UnityEngine.AnimationCurve), typeof(global::LeanAudioOptions)};
            method = type.GetMethod("createAudio", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, createAudio_2);
            args = new Type[]{typeof(UnityEngine.AnimationCurve), typeof(System.Int32)};
            method = type.GetMethod("generateAudioFromCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, generateAudioFromCurve_3);
            args = new Type[]{typeof(UnityEngine.AudioClip), typeof(System.Single)};
            method = type.GetMethod("play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, play_4);
            args = new Type[]{typeof(UnityEngine.AudioClip)};
            method = type.GetMethod("play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, play_5);
            args = new Type[]{typeof(UnityEngine.AudioClip), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, play_6);
            args = new Type[]{typeof(UnityEngine.AudioClip), typeof(UnityEngine.Vector3), typeof(System.Single)};
            method = type.GetMethod("play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, play_7);
            args = new Type[]{typeof(UnityEngine.AudioClip), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("playClipAt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, playClipAt_8);
            args = new Type[]{typeof(UnityEngine.AudioClip), typeof(UnityEngine.AnimationCurve).MakeByRefType(), typeof(System.Single)};
            method = type.GetMethod("printOutAudioClip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, printOutAudioClip_9);

            field = type.GetField("MIN_FREQEUNCY_PERIOD", flag);
            app.RegisterCLRFieldGetter(field, get_MIN_FREQEUNCY_PERIOD_0);
            app.RegisterCLRFieldSetter(field, set_MIN_FREQEUNCY_PERIOD_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_MIN_FREQEUNCY_PERIOD_0, AssignFromStack_MIN_FREQEUNCY_PERIOD_0);
            field = type.GetField("PROCESSING_ITERATIONS_MAX", flag);
            app.RegisterCLRFieldGetter(field, get_PROCESSING_ITERATIONS_MAX_1);
            app.RegisterCLRFieldSetter(field, set_PROCESSING_ITERATIONS_MAX_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_PROCESSING_ITERATIONS_MAX_1, AssignFromStack_PROCESSING_ITERATIONS_MAX_1);
            field = type.GetField("generatedWaveDistances", flag);
            app.RegisterCLRFieldGetter(field, get_generatedWaveDistances_2);
            app.RegisterCLRFieldSetter(field, set_generatedWaveDistances_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_generatedWaveDistances_2, AssignFromStack_generatedWaveDistances_2);
            field = type.GetField("generatedWaveDistancesCount", flag);
            app.RegisterCLRFieldGetter(field, get_generatedWaveDistancesCount_3);
            app.RegisterCLRFieldSetter(field, set_generatedWaveDistancesCount_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_generatedWaveDistancesCount_3, AssignFromStack_generatedWaveDistancesCount_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new global::LeanAudio());
            app.RegisterCLRCreateArrayInstance(type, s => new global::LeanAudio[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* options_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = global::LeanAudio.options();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* createAudioStream_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LeanAudioOptions @options = (global::LeanAudioOptions)typeof(global::LeanAudioOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimationCurve @frequency = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AnimationCurve @volume = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LeanAudio.createAudioStream(@volume, @frequency, @options);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* createAudio_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LeanAudioOptions @options = (global::LeanAudioOptions)typeof(global::LeanAudioOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimationCurve @frequency = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AnimationCurve @volume = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LeanAudio.createAudio(@volume, @frequency, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* generateAudioFromCurve_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @frequencyRate = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimationCurve @curve = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LeanAudio.generateAudioFromCurve(@curve, @frequencyRate);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* play_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @volume = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioClip @audio = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LeanAudio.play(@audio, @volume);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* play_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioClip @audio = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LeanAudio.play(@audio);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* play_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @pos = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioClip @audio = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LeanAudio.play(@audio, @pos);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* play_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @volume = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @pos = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AudioClip @audio = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LeanAudio.play(@audio, @pos, @volume);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* playClipAt_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @pos = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioClip @clip = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LeanAudio.playClipAt(@clip, @pos);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* printOutAudioClip_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @scaleX = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimationCurve @curve = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AudioClip @audioClip = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);


            global::LeanAudio.printOutAudioClip(@audioClip, ref @curve, @scaleX);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @curve;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @curve;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @curve);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @curve;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @curve);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AnimationCurve[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @curve;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            return __ret;
        }


        static object get_MIN_FREQEUNCY_PERIOD_0(ref object o)
        {
            return global::LeanAudio.MIN_FREQEUNCY_PERIOD;
        }

        static StackObject* CopyToStack_MIN_FREQEUNCY_PERIOD_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanAudio.MIN_FREQEUNCY_PERIOD;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MIN_FREQEUNCY_PERIOD_0(ref object o, object v)
        {
            global::LeanAudio.MIN_FREQEUNCY_PERIOD = (System.Single)v;
        }

        static StackObject* AssignFromStack_MIN_FREQEUNCY_PERIOD_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @MIN_FREQEUNCY_PERIOD = *(float*)&ptr_of_this_method->Value;
            global::LeanAudio.MIN_FREQEUNCY_PERIOD = @MIN_FREQEUNCY_PERIOD;
            return ptr_of_this_method;
        }

        static object get_PROCESSING_ITERATIONS_MAX_1(ref object o)
        {
            return global::LeanAudio.PROCESSING_ITERATIONS_MAX;
        }

        static StackObject* CopyToStack_PROCESSING_ITERATIONS_MAX_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanAudio.PROCESSING_ITERATIONS_MAX;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_PROCESSING_ITERATIONS_MAX_1(ref object o, object v)
        {
            global::LeanAudio.PROCESSING_ITERATIONS_MAX = (System.Int32)v;
        }

        static StackObject* AssignFromStack_PROCESSING_ITERATIONS_MAX_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @PROCESSING_ITERATIONS_MAX = ptr_of_this_method->Value;
            global::LeanAudio.PROCESSING_ITERATIONS_MAX = @PROCESSING_ITERATIONS_MAX;
            return ptr_of_this_method;
        }

        static object get_generatedWaveDistances_2(ref object o)
        {
            return global::LeanAudio.generatedWaveDistances;
        }

        static StackObject* CopyToStack_generatedWaveDistances_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanAudio.generatedWaveDistances;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_generatedWaveDistances_2(ref object o, object v)
        {
            global::LeanAudio.generatedWaveDistances = (System.Single[])v;
        }

        static StackObject* AssignFromStack_generatedWaveDistances_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single[] @generatedWaveDistances = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            global::LeanAudio.generatedWaveDistances = @generatedWaveDistances;
            return ptr_of_this_method;
        }

        static object get_generatedWaveDistancesCount_3(ref object o)
        {
            return global::LeanAudio.generatedWaveDistancesCount;
        }

        static StackObject* CopyToStack_generatedWaveDistancesCount_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanAudio.generatedWaveDistancesCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_generatedWaveDistancesCount_3(ref object o, object v)
        {
            global::LeanAudio.generatedWaveDistancesCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_generatedWaveDistancesCount_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @generatedWaveDistancesCount = ptr_of_this_method->Value;
            global::LeanAudio.generatedWaveDistancesCount = @generatedWaveDistancesCount;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new global::LeanAudio();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
