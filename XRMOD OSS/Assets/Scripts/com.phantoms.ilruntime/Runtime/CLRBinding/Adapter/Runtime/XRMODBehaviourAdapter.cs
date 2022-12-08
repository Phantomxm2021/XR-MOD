using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using XRMODEngineCore.Runtime;

namespace ILRuntime.CLRBinding.Adapter
{
    public class XRMODBehaviourAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType => typeof(XRMODBehaviour);

        public override Type AdaptorType => typeof(MonoAdaptor);


        public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain _appdomain,
            ILTypeInstance _instance)
        {
            return new MonoAdaptor(_appdomain, _instance);
        }

        private class MonoAdaptor : XRMODBehaviour, CrossBindingAdaptorType, IDragHandler, IBeginDragHandler,
            IEndDragHandler, IPointerDownHandler, IPointerUpHandler
        {
            protected ILTypeInstance instance;
            protected ILRuntime.Runtime.Enviorment.AppDomain appdomain;

            public MonoAdaptor()
            {
            }

            public MonoAdaptor(ILRuntime.Runtime.Enviorment.AppDomain _appdomain, ILTypeInstance _instance)
            {
                this.appdomain = _appdomain;
                this.instance = _instance;
            }

            public ILTypeInstance ILInstance
            {
                get => instance;
                set => instance = value;
            }

            public ILRuntime.Runtime.Enviorment.AppDomain AppDomain
            {
                get => appdomain;
                set => appdomain = value;
            }


            #region MonoCallback

            object[] param0 = new object[0];
            private bool destroyed = false;
            IMethod awakeMethod;
            bool awakeMethodGot;
            private bool isAwaking = false;

            public  void Awake()
            {
                try
                {
                    if (instance == null) return;
                    if (!awakeMethodGot)
                    {
                        awakeMethod = instance.Type.GetMethod("Awake", 0);
                        awakeMethodGot = true;
                    }

                    if (awakeMethod == null || isAwaking || !gameObject.activeInHierarchy) return;
                    isAwaking = true;
                    // try
                    // {
                    //     while (Application.isPlaying && !destroyed && !gameObject.activeInHierarchy)
                    //     {
                    //         await Task.Delay(20);
                    //     }
                    // }
                    // catch (MissingReferenceException tmp_E)
                    // {
                    //     Debug.LogError(tmp_E);
                    //     return;
                    // }

                    // if (destroyed || !Application.isPlaying)
                    // {
                    //     return;
                    // }

                    // isAwaking = false;
                    appdomain.Invoke(awakeMethod, instance, param0);
                    // OnEnable();
                }
                catch (Exception tmp_Exception)
                {
                    Debug.LogError(tmp_Exception);
                    throw;
                }
            }


            IMethod startMethod;
            bool startMethodGot;

            void Start()
            {
                try
                {
                    if (instance == null || destroyed) return;
                    if (!startMethodGot)
                    {
                        startMethod = instance.Type.GetMethod("Start", 0);
                        startMethodGot = true;
                    }

                    if (startMethod != null)
                    {
                        appdomain.Invoke(startMethod, instance, null);
                    }
                }
                catch (Exception tmp_Exception)
                {
                    Debug.LogError(tmp_Exception);
                    throw;
                }
            }

            IMethod updateMethod;
            bool updateMethodGot;

            void Update()
            {
                if (instance == null || destroyed) return;
                if (!updateMethodGot)
                {
                    updateMethod = instance.Type.GetMethod("Update", 0);
                    updateMethodGot = true;
                }

                if (updateMethod != null)
                {
                    appdomain.Invoke(updateMethod, instance, null);
                }
            }


            IMethod fixedUpdateMethod;
            bool fixedUpdateMethodGot;

            void FixedUpdate()
            {
                if (instance == null || destroyed) return;
                if (!fixedUpdateMethodGot)
                {
                    fixedUpdateMethod = instance.Type.GetMethod("FixedUpdate", 0);
                    fixedUpdateMethodGot = true;
                }

                if (fixedUpdateMethod != null)
                {
                    appdomain.Invoke(fixedUpdateMethod, instance, null);
                }
            }


            IMethod lateUpdateMethod;
            bool lateUpdateMethodGot;

            void LateUpdate()
            {
                if (instance == null || destroyed) return;
                if (!lateUpdateMethodGot)
                {
                    lateUpdateMethod = instance.Type.GetMethod("LateUpdate", 0);
                    lateUpdateMethodGot = true;
                }

                if (lateUpdateMethod != null)
                {
                    appdomain.Invoke(lateUpdateMethod, instance, null);
                }
            }


            IMethod onDestroyMethod;
            bool onDestroyMethodGot;

            private void OnDestroy()
            {
                if (instance == null || destroyed) return;
                if (!onDestroyMethodGot)
                {
                    onDestroyMethod = instance.Type.GetMethod("OnDestroy", 0);
                    onDestroyMethodGot = true;
                }

                if (onDestroyMethod != null)
                {
                    appdomain.Invoke(onDestroyMethod, instance, null);
                }

                //To avoid null exception after destroy
                destroyed = true;
            }


            IMethod onEnableMethod;
            bool onEnableMethodGot;

            private void OnEnable()
            {
                if (instance == null || destroyed) return;
                if (!onEnableMethodGot)
                {
                    onEnableMethod = instance.Type.GetMethod("OnEnable", 0);
                    onEnableMethodGot = true;
                }

                if (onEnableMethod != null)
                {
                    appdomain.Invoke(onEnableMethod, instance, null);
                }
            }


            IMethod onDisableMethod;
            bool onDisableMethodGot;

            private void OnDisable()
            {
                if (instance == null || destroyed) return;
                if (!onDisableMethodGot)
                {
                    onDisableMethod = instance.Type.GetMethod("OnDisable", 0);
                    onDisableMethodGot = true;
                }

                if (onDisableMethod != null)
                {
                    appdomain.Invoke(onDisableMethod, instance, null);
                }
            }


            IMethod onApplicationFocusMethod;
            bool onApplicationFocusMethodGot;

            private void OnApplicationFocus(bool _hasFocus)
            {
                if (instance == null || destroyed) return;
                if (!onApplicationFocusMethodGot)
                {
                    onApplicationFocusMethod = instance.Type.GetMethod("OnApplicationFocus", 1);
                    onApplicationFocusMethodGot = true;
                }

                if (onApplicationFocusMethod != null)
                {
                    appdomain.Invoke(onApplicationFocusMethod, instance, _hasFocus);
                }
            }


            IMethod onApplicationPauseMethod;
            bool onApplicationPauseMethodGot;

            private void OnApplicationPause(bool _hasFocus)
            {
                if (instance == null || destroyed) return;
                if (!onApplicationPauseMethodGot)
                {
                    onApplicationPauseMethod = instance.Type.GetMethod("OnApplicationPause", 1);
                    onApplicationPauseMethodGot = true;
                }

                if (onApplicationPauseMethod != null)
                {
                    appdomain.Invoke(onApplicationPauseMethod, instance, _hasFocus);
                }
            }


            private IMethod onMouseDownMethod;
            bool onMouseDownMethodGot;

            private void OnMouseDown()
            {
                if (instance == null || destroyed) return;
                if (!onMouseDownMethodGot)
                {
                    onMouseDownMethod = instance.Type.GetMethod("OnMouseDown", 0);
                    onMouseDownMethodGot = true;
                }

                if (onMouseDownMethod != null)
                {
                    appdomain.Invoke(onMouseDownMethod, instance);
                }
            }

            #endregion

            #region Collider

            IMethod onTriggerEnterMethod;
            bool onTriggerEnterMethodGot;

            private void OnTriggerEnter(Collider _collider)
            {
                if (instance == null || destroyed) return;
                if (!onTriggerEnterMethodGot)
                {
                    onTriggerEnterMethod = instance.Type.GetMethod("OnTriggerEnter", 1);
                    onTriggerEnterMethodGot = true;
                }

                if (onTriggerEnterMethod != null)
                {
                    appdomain.Invoke(onTriggerEnterMethod, instance, _collider);
                }
            }


            IMethod onTriggerStayMethod;
            bool onTriggerStayMethodGot;

            private void OnTriggerStay(Collider _collider)
            {
                if (instance == null || destroyed) return;
                if (!onTriggerStayMethodGot)
                {
                    onTriggerStayMethod = instance.Type.GetMethod("OnTriggerStay", 1);
                    onTriggerStayMethodGot = true;
                }

                if (onTriggerStayMethod != null)
                {
                    appdomain.Invoke(onTriggerStayMethod, instance, _collider);
                }
            }


            IMethod onTriggerExitMethod;
            bool onTriggerExitMethodGot;

            private void OnTriggerExit(Collider _collider)
            {
                if (instance == null || destroyed) return;
                if (!onTriggerExitMethodGot)
                {
                    onTriggerExitMethod = instance.Type.GetMethod("OnTriggerExit", 1);
                    onTriggerExitMethodGot = true;
                }

                if (onTriggerExitMethod != null)
                {
                    appdomain.Invoke(onTriggerExitMethod, instance, _collider);
                }
            }


            IMethod onCollisionEnterMethod;
            bool onCollisionEnterMethodGot;

            private void OnCollisionEnter(Collision _collision)
            {
                if (instance == null || destroyed) return;
                if (!onCollisionEnterMethodGot)
                {
                    onCollisionEnterMethod = instance.Type.GetMethod("OnCollisionEnter", 1);
                    onCollisionEnterMethodGot = true;
                }

                if (onCollisionEnterMethod != null)
                {
                    appdomain.Invoke(onCollisionEnterMethod, instance, _collision);
                }
            }


            IMethod onCollisionStayMethod;
            bool onCollisionStayMethodGot;

            private void OnCollisionStay(Collision _collision)
            {
                if (instance == null || destroyed) return;
                if (!onCollisionStayMethodGot)
                {
                    onCollisionStayMethod = instance.Type.GetMethod("OnCollisionStay", 1);
                    onCollisionStayMethodGot = true;
                }

                if (onCollisionStayMethod != null)
                {
                    appdomain.Invoke(onCollisionStayMethod, instance, _collision);
                }
            }


            IMethod onCollisionExitMethod;
            bool onCollisionExitMethodGot;

            private void OnCollisionExit(Collision _collision)
            {
                if (instance == null || destroyed) return;
                if (!onCollisionExitMethodGot)
                {
                    onCollisionExitMethod = instance.Type.GetMethod("OnCollisionExit", 1);
                    onCollisionExitMethodGot = true;
                }

                if (onCollisionExitMethod != null)
                {
                    appdomain.Invoke(onCollisionExitMethod, instance, _collision);
                }
            }

            #endregion

            #region Animator

            IMethod onAnimatorIkMethod;
            bool onAnimatorIkMethodGot;


            public void OnAnimatorIK(int _layerIndex)
            {
                if (instance == null || destroyed) return;
                if (!onAnimatorIkMethodGot)
                {
                    onAnimatorIkMethod = instance.Type.GetMethod("OnAnimatorIK", 1);
                    onAnimatorIkMethodGot = true;
                }

                if (onAnimatorIkMethod != null)
                {
                    appdomain.Invoke(onAnimatorIkMethod, instance, _layerIndex);
                }
            }
// 会影响正常动画播放
//
//
//        IMethod OnAnimatorMoveMethod;
//        bool OnAnimatorMoveMethodGot;
//
//
//        public void OnAnimatorMove()
//        {
//           if (instance == null || destroyed) return;
//            if (!OnAnimatorMoveMethodGot)
//            {
//                OnAnimatorMoveMethod = Instance.Type.GetMethod("OnAnimatorMove", 1);
//                OnAnimatorMoveMethodGot = true;
//            }
//
//            if (StartMethod != null)
//            {
//                Appdomain.Invoke(OnAnimatorMoveMethod, Instance, 0);
//            }
//        }

            #endregion

            #region Partical

            private IMethod onParticleTriggerMethod;
            bool onParticleMethodGot;


            public void OnParticleTrigger()
            {
                if (instance == null || destroyed) return;
                if (!onParticleMethodGot)
                {
                    onParticleTriggerMethod = instance.Type.GetMethod("OnAnimatorIK", 0);
                    onParticleMethodGot = true;
                }

                if (startMethod != null)
                {
                    appdomain.Invoke(onParticleTriggerMethod, instance, null);
                }
            }


            private IMethod onParticleCollisionMethod;
            bool onParticleCollisionMethodGot;

            public void OnParticleCollision([NotNull] GameObject _other)
            {
                if (instance == null || destroyed) return;
                if (_other == null) throw new ArgumentNullException(nameof(_other));
                if (!onParticleCollisionMethodGot)
                {
                    onParticleCollisionMethod = instance.Type.GetMethod("OnParticleCollision", 1);
                    onParticleCollisionMethodGot = true;
                }

                if (onParticleCollisionMethod != null)
                {
                    appdomain.Invoke(onParticleCollisionMethod, instance, _other);
                }
            }

            #endregion

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

            private IMethod onPointerUpMethod;
            bool onPointerUpMethodGot;

            public void OnPointerUp(PointerEventData _eventData)
            {
                if (instance == null || destroyed) return;
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
                if (instance == null || destroyed) return;
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
                if (instance == null || destroyed) return;
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
                if (instance == null || destroyed) return;
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
                if (instance == null || destroyed) return;
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

            IMethod onGUIMethod;
            bool onGUIMethodGot;


            public void OnGUI()
            {
                if (instance == null || destroyed) return;
                if (!onGUIMethodGot)
                {
                    onGUIMethod = instance.Type.GetMethod("OnGUI", 0);
                    onGUIMethodGot = true;
                }

                if (onGUIMethod != null)
                {
                    appdomain.Invoke(onGUIMethod, instance, null);
                }
            }


            IMethod onGizmosDrawMethod;
            bool onGizmosDrawMethodGot;


            public void OnDrawGizmos()
            {
                if (instance == null || destroyed) return;
                if (!onGizmosDrawMethodGot)
                {
                    onGizmosDrawMethod = instance.Type.GetMethod("OnDrawGizmos", 0);
                    onGizmosDrawMethodGot = true;
                }

                if (onGizmosDrawMethod != null)
                {
                    appdomain.Invoke(onGizmosDrawMethod, instance, null);
                }
            }

            public void Reset()
            {
                awakeMethodGot = false;
                startMethodGot = false;
                updateMethodGot = false;
                fixedUpdateMethodGot = false;
                lateUpdateMethodGot = false;
                onEnableMethodGot = false;
                onDisableMethodGot = false;
                onDisableMethodGot = false;
                onTriggerEnterMethodGot = false;
                onTriggerStayMethodGot = false;
                onTriggerExitMethodGot = false;
                onCollisionEnterMethodGot = false;
                onCollisionStayMethodGot = false;
                onCollisionExitMethodGot = false;
                instance = null;
                appdomain = null;
                onDestroyMethodGot = false;
            }
        }
    }
}