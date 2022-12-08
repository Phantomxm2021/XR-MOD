// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/


using System;
using UnityEngine;
using System.Collections.Generic;

namespace com.Phantoms.ActionNotification.Runtime
{
    public class ActionNotificationCenter : IActionNotificationCenter<Action<BaseNotificationData>>
    {
        private static readonly ActionNotificationCenter DEFAULT_CENTER = new ActionNotificationCenter();

        static ActionNotificationCenter()
        {
            
        }

        private ActionNotificationCenter()
        {
            
        }

        public void Release()
        {
            notifications.Clear();
            notificationsResults.Clear();
        }


        public static ActionNotificationCenter DefaultCenter => DEFAULT_CENTER;

        private readonly Dictionary<string, List<Action<BaseNotificationData>>> notifications = new();

        private readonly Dictionary<string, List<Func<BaseNotificationData, object>>> notificationsResults = new();

        /// <summary>
        /// add the method observer from notification actions
        /// </summary>
        /// <param name="_name">Will add notification name</param>
        /// <param name="_action">Will executed method</param>
        public void AddObserver(Action<BaseNotificationData> _action, string _name)
        {
            if (string.IsNullOrEmpty(_name))
            {
                Debug.LogError("Null name specified for notification in AddObserver.");
                return;
            }

            if (!notifications.ContainsKey(_name))
            {
                notifications.Add(_name, new List<Action<BaseNotificationData>>());
            }


            if (notifications[_name] is { } tmp_NotifyList
                && !tmp_NotifyList.Contains(_action))
            {
                tmp_NotifyList.Add(_action);
            }
        }

        /// <summary>
        /// add the method observer from notification actions
        /// </summary>
        /// <param name="_name">Will add notification name</param>
        /// <param name="_action">Will executed method</param>
        public void AddObserver(Func<BaseNotificationData, object> _action, string _name)
        {
            if (string.IsNullOrEmpty(_name))
            {
                Debug.LogError("Null name specified for notification in AddObserver.");
                return;
            }

            if (!notificationsResults.ContainsKey(_name))
            {
                notificationsResults.Add(_name, new List<Func<BaseNotificationData, object>>());
            }


            if (notificationsResults[_name] is { } tmp_NotifyList
                && !tmp_NotifyList.Contains(_action))
            {
                tmp_NotifyList.Add(_action);
            }
        }

        /// <summary>
        /// Remove the method observer from notification actions
        /// </summary>
        /// <param name="_name">Will remove notification name</param>
        /// <param name="_action">Will executed method</param>
        public void RemoveObserver(string _name, Action<BaseNotificationData> _action)
        {
            if (!notifications.ContainsKey(_name)) return;
            if (!(notifications[_name] is { } tmp_NotifyList)) return;
            if (tmp_NotifyList.Contains(_action)) tmp_NotifyList.Remove(_action);
            if (tmp_NotifyList.Count == 0) notifications.Remove(_name);
        }

        /// <summary>
        /// Remove the method observer from notification actions
        /// </summary>
        /// <param name="_name">Will remove notification name</param>
        /// <param name="_action">Will executed method</param>
        public void RemoveObserver(string _name, Func<BaseNotificationData, object> _action)
        {
            if (!notificationsResults.ContainsKey(_name)) return;
            if (!(notificationsResults[_name] is { } tmp_NotifyList)) return;
            if (tmp_NotifyList.Contains(_action)) tmp_NotifyList.Remove(_action);
            if (tmp_NotifyList.Count == 0) notificationsResults.Remove(_name);
        }

        /// <summary>
        /// Remove the method observer from notification actions
        /// </summary>
        /// <param name="_name">Will remove notification name</param>
        public void RemoveObserver(string _name)
        {
            if (notifications.ContainsKey(_name)) notifications.Remove(_name);
            if (notificationsResults.ContainsKey(_name)) notificationsResults.Remove(_name);
        }


        /// <summary>
        /// Post notification event
        /// </summary>
        /// <param name="_name">Trigger method name</param>
        /// <param name="_object">The parameters to the method</param>
        public void PostNotification(string _name, BaseNotificationData _object)
        {
            if (string.IsNullOrEmpty(_name))
            {
#if DEBUG
                Debug.LogError("Trigger method name is empty!");
#endif
                return;
            }

            if (!notifications.ContainsKey(_name))
            {
#if DEBUG
                Debug.LogWarning($"{_name} key is no in Notification center!");
#endif
                return;
            }

            if (notifications[_name] is not { } tmp_NotificationActions) return;
            
            //Avoid InvalidOperationException: Collection was modified; enumeration operation may not execute.
            // Dont used Foreach
            for (int tmp_Idx = 0; tmp_Idx < tmp_NotificationActions.Count; tmp_Idx++)
            {
                tmp_NotificationActions[tmp_Idx]?.Invoke(_object);
            }
        }


        /// <summary>
        /// Post notification event
        /// </summary>
        /// <param name="_name">Trigger method name</param>
        /// <param name="_object">The parameters to the method</param>
        public List<object> PostNotificationWithResult(string _name, BaseNotificationData _object)
        {
            if (string.IsNullOrEmpty(_name))
            {
#if DEBUG
                Debug.LogError("The method name is empty!.");
#endif
                return null;
            }

            if (!notificationsResults.ContainsKey(_name))
            {
#if DEBUG
                Debug.LogWarning($"{_name} key is no in Notification center!");
#endif
                return null;
            }

            if (!(notificationsResults[_name] is { } tmp_NotifyList)) return null;
            List<object> tmp_Results = new List<object>();
            foreach (Func<BaseNotificationData, object> tmp_Action in tmp_NotifyList)
            {
                tmp_Results.Add(tmp_Action?.Invoke(_object));
            }

            return tmp_Results;
        }
    }
}