﻿

using Drones.Managers;
using Drones.UI.Utils;
using Utils;

namespace Drones.UI.SaveLoad
{
    public class PriorityFocus : UIFocus
    {
        public static uint Count { get; private set; }
        public static new void Reset()
        {
            Count = 0;
            Hover = 0;
        }

        private int _index;
        private void OnEnable()
        {
            if (SimManager.Status != SimulationStatus.Paused && SimManager.Status != SimulationStatus.EditMode)
            {
                SimManager.SetStatus(SimulationStatus.Paused);
            }
            _index = (int)Count++;
        }

        private void LateUpdate()
        {
            Controlling = true;
            Window.transform.SetAsLastSibling();
            Window.transform.SetSiblingIndex(Window.transform.GetSiblingIndex() - (int)Count + _index + 1);
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            Count--;
        }

    }

}
