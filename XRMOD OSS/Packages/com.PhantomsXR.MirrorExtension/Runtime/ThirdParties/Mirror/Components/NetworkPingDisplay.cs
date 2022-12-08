using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Mirror
{
    /// <summary>
    /// Component that will display the clients ping in milliseconds
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Network/NetworkPingDisplay")]
    [HelpURL("https://mirror-networking.gitbook.io/docs/components/network-ping-display")]
    public class NetworkPingDisplay : MonoBehaviour
    {
        public Color color = Color.white;
        public int padding = 2;
        int width = 150;
        int height = 25;

        private Label pingLabel;

        private void Start()
        {
            var tmp_Root = GetComponentInChildren<UIDocument>().rootVisualElement;
            pingLabel = tmp_Root.Q<Label>("pinglabel");
            var tmp_SafeArea = tmp_Root.Q<VisualElement>("safearea");
            var tmp_SafeAreaRect = Screen.safeArea;
            tmp_SafeArea.style.paddingTop = new StyleLength(tmp_SafeAreaRect.yMin);
            //tmp_SafeArea.style.paddingBottom = new StyleLength(Screen.height - tmp_SafeAreaRect.yMax);
            tmp_SafeArea.style.paddingRight = new StyleLength(Screen.width - tmp_SafeAreaRect.xMax);
        }

        private void Update()
        {
            // only while client is active
            if (!NetworkClient.active) return;
            pingLabel.text = $"RTT: {Math.Round(NetworkTime.rtt * 1000)}ms";
        }


        // void OnGUI()
        // {
        //     
        //
        //     // show rtt in bottom right corner, right aligned
        //     GUI.color = color;
        //     var tmp_RectView = Screen.safeArea;
        //     Rect rect = new Rect(tmp_RectView.width - width - padding, tmp_RectView.height - height - padding, width, height);
        //     GUIStyle style = GUI.skin.GetStyle("Label");
        //     style.alignment = TextAnchor.MiddleRight;
        //     GUI.Label(rect, $"RTT: {Math.Round(NetworkTime.rtt * 1000)}ms", style);
        //     GUI.color = Color.white;
        // }
    }
}