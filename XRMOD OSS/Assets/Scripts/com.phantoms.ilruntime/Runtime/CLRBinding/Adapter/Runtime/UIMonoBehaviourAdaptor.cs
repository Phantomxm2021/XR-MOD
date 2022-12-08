// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ILRuntime.Adapter.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using UnityEngine.EventSystems;
using XRMODEngineCore.Runtime;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace ILRuntime.CLRBinding.Adapter
{
    public class UIMonoBehaviourAdaptor : CrossBindingAdaptor
    {
        public override Type BaseCLRType => typeof(UIMonoBehaviour);

        public override Type AdaptorType => typeof(Adapter);

        public override object CreateCLRInstance(AppDomain appdomain, ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        public class Adapter : MonoBehaviourAdapter.Adapter, IDragHandler, IBeginDragHandler,
            IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerClickHandler,
            IPointerExitHandler, IPointerMoveHandler
        {
            private IMethod onPointerMoveMethod;
            bool onPointerMoveMethodGot;

            public void OnPointerMove(PointerEventData _eventData)
            {
                if (instance == null) return;
                if (!onPointerMoveMethodGot)
                {
                    onPointerMoveMethod = instance.Type.GetMethod("OnPointerMove", 1);
                    onPointerMoveMethodGot = true;
                }

                if (onPointerMoveMethod != null)
                {
                    appdomain.Invoke(onPointerMoveMethod, instance, _eventData);
                }
            }

            private IMethod onPointerExitMethod;
            bool onPointerExitMethodGot;

            public void OnPointerExit(PointerEventData _eventData)
            {
                if (instance == null) return;
                if (!onPointerExitMethodGot)
                {
                    onPointerExitMethod = instance.Type.GetMethod("OnPointerExit", 1);
                    onPointerExitMethodGot = true;
                }

                if (onPointerExitMethod != null)
                {
                    appdomain.Invoke(onPointerExitMethod, instance, _eventData);
                }
            }

            private IMethod onPointerClickMethod;
            bool onPointerClickMethodGot;

            public void OnPointerClick(PointerEventData _eventData)
            {
                if (instance == null) return;
                if (!onPointerClickMethodGot)
                {
                    onPointerClickMethod = instance.Type.GetMethod("OnPointerClick", 1);
                    onPointerClickMethodGot = true;
                }

                if (onPointerClickMethod != null)
                {
                    appdomain.Invoke(onPointerClickMethod, instance, _eventData);
                }
            }

            private IMethod onPointerEnterMethod;
            bool onPointerEnterMethodGot;

            public void OnPointerEnter(PointerEventData _eventData)
            {
                if (instance == null) return;
                if (!onPointerEnterMethodGot)
                {
                    onPointerEnterMethod = instance.Type.GetMethod("OnPointerEnter", 1);
                    onPointerEnterMethodGot = true;
                }

                if (onPointerEnterMethod != null)
                {
                    appdomain.Invoke(onPointerEnterMethod, instance, _eventData);
                }
            }

            private IMethod onPointerUpMethod;
            bool onPointerUpMethodGot;

            public void OnPointerUp(PointerEventData _eventData)
            {
                if (instance == null) return;
                if (!onPointerUpMethodGot)
                {
                    onPointerUpMethod = instance.Type.GetMethod("OnPointerUp", 1);
                    onPointerUpMethodGot = true;
                }

                if (onPointerUpMethod != null)
                {
                    appdomain.Invoke(onPointerUpMethod, instance, _eventData);
                }
            }

            private IMethod onPointerDownMethod;
            bool onPointerDownMethodGot;

            public void OnPointerDown(PointerEventData _eventData)
            {
                if (instance == null) return;
                if (!onPointerDownMethodGot)
                {
                    onPointerDownMethod = instance.Type.GetMethod("OnPointerDown", 1);
                    onPointerDownMethodGot = true;
                }

                if (onPointerDownMethod != null)
                {
                    appdomain.Invoke(onPointerDownMethod, instance, _eventData);
                }
            }

            private IMethod onEndDragMethod;
            bool onEndDragMethodGot;

            public void OnEndDrag(PointerEventData _eventData)
            {
                if (instance == null) return;
                if (!onEndDragMethodGot)
                {
                    onEndDragMethod = instance.Type.GetMethod("OnEndDrag", 1);
                    onEndDragMethodGot = true;
                }

                if (onEndDragMethod != null)
                {
                    appdomain.Invoke(onEndDragMethod, instance, _eventData);
                }
            }

            private IMethod onBeginDragMethod;
            bool onBeginDragMethodGot;

            public void OnBeginDrag(PointerEventData _eventData)
            {
                if (instance == null) return;
                if (!onBeginDragMethodGot)
                {
                    onBeginDragMethod = instance.Type.GetMethod("OnBeginDrag", 1);
                    onBeginDragMethodGot = true;
                }

                if (onBeginDragMethod != null)
                {
                    appdomain.Invoke(onBeginDragMethod, instance, _eventData);
                }
            }

            private IMethod onDragMethod;
            bool onDragMethodGot;

            public void OnDrag(PointerEventData _eventData)
            {
                if (instance == null) return;
                if (!onDragMethodGot)
                {
                    onDragMethod = instance.Type.GetMethod("OnDrag", 1);
                    onDragMethodGot = true;
                }

                if (onDragMethod != null)
                {
                    appdomain.Invoke(onDragMethod, instance, _eventData);
                }
            }

            public override void Reset()
            {
                base.Reset();
                onDragMethod = null;
                onBeginDragMethod = null;
                onEndDragMethod = null;
                onPointerDownMethod = null;
                onPointerUpMethod = null;
                onPointerEnterMethod = null;
                onPointerClickMethod = null;
                onPointerExitMethod = null;
                onPointerMoveMethod = null;
            }
            
            public Adapter():base(){}

            public Adapter(AppDomain _appdomain, ILTypeInstance _instance) : base(_appdomain, _instance)
            {
                this.appdomain = _appdomain;
                this.instance = _instance;
            }
        }
    }
}