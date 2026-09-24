namespace UnityEngine.UI.Extensions
{
    public class Stepper : global::UnityEngine.EventSystems.UIBehaviour
    {
        [global::System.Serializable]
        public class StepperValueChangedEvent : global::UnityEngine.Events.UnityEvent<int>
        {
        }

        private global::UnityEngine.UI.Selectable[] _sides;
        [global::UnityEngine.SerializeField]
        private int _value;
        [global::UnityEngine.SerializeField]
        private int _minimum;
        [global::UnityEngine.SerializeField]
        private int _maximum;
        [global::UnityEngine.SerializeField]
        private int _step;
        [global::UnityEngine.SerializeField]
        private bool _wrap;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Graphic _separator;
        private float _separatorWidth;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.Stepper.StepperValueChangedEvent _onValueChanged;
        private float separatorWidth => 0f;
        public global::UnityEngine.UI.Selectable[] sides => null;

        public int value
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int minimum
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int maximum
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int step
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public bool wrap
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Graphic separator
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Extensions.Stepper.StepperValueChangedEvent onValueChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected Stepper()
        {
        }

        private global::UnityEngine.UI.Selectable[] GetSides()
        {
            return null;
        }

        public void StepUp()
        {
        }

        public void StepDown()
        {
        }

        private void Step(int amount)
        {
        }

        private void DisableAtExtremes(global::UnityEngine.UI.Selectable[] sides)
        {
        }

        private void RecreateSprites(global::UnityEngine.UI.Selectable[] sides)
        {
        }

        public void LayoutSides(global::UnityEngine.UI.Selectable[] sides = null)
        {
        }
    }
}