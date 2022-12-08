using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.CLRBinding.Adapter
{
    public class BaseNotificationDataAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType => typeof(com.Phantoms.ActionNotification.Runtime.BaseNotificationData);

        public override Type AdaptorType => typeof(Adapter);

        public override object CreateCLRInstance(Runtime.Enviorment.AppDomain _appdomain, ILTypeInstance _instance)
        {
            return new Adapter(_appdomain, _instance);
        }

        public class Adapter : com.Phantoms.ActionNotification.Runtime.BaseNotificationData, CrossBindingAdaptorType
        {
            readonly ILTypeInstance instance;
            readonly Runtime.Enviorment.AppDomain appdomain;
            public Adapter(Runtime.Enviorment.AppDomain _appdomain, ILTypeInstance _instance)
            {
                appdomain = _appdomain;
                instance = _instance;
            }

            public ILTypeInstance ILInstance => instance;

            public override string ToString()
            {
                IMethod tmp_Method = appdomain.ObjectType.GetMethod("ToString", 0);
                tmp_Method = instance.Type.GetVirtualMethod(tmp_Method);
                if (tmp_Method == null || tmp_Method is ILMethod)
                {
                    return instance.ToString();
                }
                else
                    return instance.Type.FullName;
            }
        }
    }
}