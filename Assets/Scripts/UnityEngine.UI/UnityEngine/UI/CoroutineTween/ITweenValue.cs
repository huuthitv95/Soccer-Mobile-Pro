// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
using System.Collections;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
    // Base interface for tweeners,
    // using an interface instead of
    // an abstract class as we want the
    // tweens to be structs.
    internal interface ITweenValue
    {
        void TweenValue(float floatPercentage);
        bool ignoreTimeScale { get; }
        float duration { get; }
        bool ValidTarget();
    }
}
