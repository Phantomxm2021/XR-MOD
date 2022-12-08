using System;
using System.Collections;
using System.Collections.Generic;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime
{
    public class CheckControllerStatus : MonoBehaviour
    {
        private Camera arCamera;
        private ActionBasedController controller;
        private XRInteractorLineVisual interactorLine;

        private void Start()
        {
            arCamera = IocContainer.GetIoc.Resolve<ARComponentModel>().ARCamera;
            if (!arCamera.stereoEnabled)
            {
                enabled = false;
            }

            controller = GetComponent<ActionBasedController>();
            Assert.IsNotNull(controller);
            interactorLine = GetComponent<XRInteractorLineVisual>();
        }

        private void Update()
        {
            var tmp_State = controller.currentControllerState;
            if (tmp_State != null && (tmp_State.inputTrackingState & InputTrackingState.Position) != 0)
            {
                interactorLine.enabled = true;
                interactorLine.reticle.SetActive(true);
            }
            else
            {
                interactorLine.enabled = false;
                interactorLine.reticle.SetActive(false);
            }
        }
    }
}