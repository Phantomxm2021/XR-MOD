using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SDKEntry.Runtime
{
    public class FPS : MonoBehaviour
    {
        private float m_time = 0.0f;
        public Text FPSDisplay;

        void Update()
        {
            m_time += (Time.unscaledDeltaTime - m_time) * 0.1f;

            float ms = m_time * 1000.0f;
            float fps = 1.0f / m_time;

            FPSDisplay.text = $"{fps} FPS ({ms}ms)";
        }
    }
}