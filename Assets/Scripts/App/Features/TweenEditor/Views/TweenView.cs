using CompositeTween.Core;
using UnityEngine;

namespace App.Features.TweenEditor
{
    [ExecuteInEditMode]
    public class TweenView : AbstractTweenView
    {
        [SerializeField] private bool run;

        private void Update()
        {
            if (!run)
                return;
            run = false;
            RunSequence();
        }
    }
}
