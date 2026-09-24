namespace Gadsme
{
    internal class Tdabed9b_48<T>
    {
        private float angle;
        private float visibility;
        private float size;
        private float progress;
        private bool F386;
        internal const float F387 = 0.015f;
        internal const float F388 = 0.25f;
        internal const float F389 = 0.2f;
        private bool F390;
        public readonly T F391;
        public readonly global::Gadsme.GadsmePlacement F392;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<T> F393;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<T> F394;
        public float P32
        {
            get
            {
                return get_angle();
            }

            private set
            {
                set_angle(value);
            }
        }

        public float P33
        {
            get
            {
                return get_visibility();
            }

            private set
            {
                set_visibility(value);
            }
        }

        public float P34
        {
            get
            {
                return get_size();
            }

            private set
            {
                set_size(value);
            }
        }

        public float P35
        {
            get
            {
                return get_progress();
            }

            private set
            {
                set_progress(value);
            }
        }

        public event global::System.Action<T> ProgressStartEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<T> ProgressEndEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public Tdabed9b_48(T subject)
        {
        }

        public float get_angle()
        {
            return this.angle;
        }

        private void set_angle(float value)
        {
            this.angle = value;
        }

        public float get_visibility()
        {
            return this.visibility;
        }

        private void set_visibility(float value)
        {
            this.visibility = value;
        }

        public float get_size()
        {
            return this.size;
        }

        private void set_size(float value)
        {
            this.size = value;
        }

        public float get_progress()
        {
            return this.progress;
        }

        private void set_progress(float value)
        {
            this.progress = value;
        }

        public void M394()
        {
        }

        public void M395()
        {
        }

        public void M396()
        {
        }

        public void M397(float A381, float A382, float A383)
        {
        }

        public bool M398()
        {
            return false;
        }

        public bool M399()
        {
            return false;
        }

        public bool M400()
        {
            return false;
        }

        public bool M401()
        {
            return false;
        }

        public void M402(float A384, float A385)
        {
        }
    }
}