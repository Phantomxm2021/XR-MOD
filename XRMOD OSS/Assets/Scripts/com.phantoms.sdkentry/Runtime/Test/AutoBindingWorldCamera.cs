using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SDKEntry.Runtime
{
    public class AutoBindingWorldCamera : MonoBehaviour
    {
        public GameObject[] GameObjects;
        // Start is called before the first frame update
        void Start()
        {
            foreach (GameObject tmp_GameObject in GameObjects)
            {
                tmp_GameObject.SetActive(true);
            }
            FindObjectOfType<Canvas>().worldCamera = Camera.main;

        }
    }
}
