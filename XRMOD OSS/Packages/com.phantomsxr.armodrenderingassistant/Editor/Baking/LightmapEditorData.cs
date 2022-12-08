using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;
#if UNITY_EDITOR
using System;

namespace com.Phantoms.RenderingAssistant.Editor
{
    internal static class LightmapEditorData
    {
        static IEnumerable<PropertyInfo> _props = null;

        static IEnumerable<PropertyInfo> GetProperties()
        {
            if (_props == null)
                _props = typeof(LightmapEditorSettings)
                    .GetProperties(BindingFlags.Static | BindingFlags.Public)
                    .Where(p => !p.GetCustomAttributes(typeof(ObsoleteAttribute), inherit: true).Any());

            return _props;
        }

        static Dictionary<string, object> backup = new Dictionary<string, object>();

        public static bool HasBackup => backup.Count > 0;

        public static void Backup()
        {
            foreach (var p in GetProperties())
            {
                if (backup.ContainsKey(p.Name)) backup[p.Name] = p.GetValue(null);
                else backup.Add(p.Name, p.GetValue(null));
            }
        }

        public static void Restore()
        {
            if (!HasBackup) return;

            foreach (var p in GetProperties())
            {
                var name = p.Name;
                if (!backup.ContainsKey(name)) continue;

                p.SetValue(null, backup[name]);

                backup.Remove(name);
            }
        }

        public static new string ToString()
        {
            return string.Join(",",
                GetProperties().Select(p => p.Name + ":" + p.GetType().ToString() + "=" + p.GetValue(null)));
        }

        public static void SetProfileQuickBake()
        {
            Lightmapping.lightingSettings.maxBounces = 1;
            Lightmapping.lightingSettings.directSampleCount = 2;
            Lightmapping.lightingSettings.indirectSampleCount = 8;
            Lightmapping.lightingSettings.lightmapResolution = 20f;
            Lightmapping.lightingSettings.ao = false;
            Lightmapping.lightingSettings.compressLightmaps = true;
            Lightmapping.lightingSettings.indirectResolution = 2;
            Lightmapping.lightingSettings.lightmapper = LightingSettings.Lightmapper.ProgressiveGPU;
        }
    }
}

#endif