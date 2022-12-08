using com.Phantoms.ActionNotification.Runtime;
using UnityEngine.UIElements;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class PropertiesView : VisualElement
    {
        public new class UxmlFactory : UxmlFactory<PropertiesView, VisualElement.UxmlTraits>
        {
        }

        public PropertiesView()
        {
            var tmp_PropertiesRenderer = new PropertiesRenderer();
            Add(tmp_PropertiesRenderer);

            AddToClassList("full-vertical-view");
            tmp_PropertiesRenderer.AddToClassList("full-vertical-view");
            ActionNotificationCenter.DefaultCenter.AddObserver(_data => { tmp_PropertiesRenderer.Initialization(); },
                nameof(EditingProjectCommand));
        }
    }
}