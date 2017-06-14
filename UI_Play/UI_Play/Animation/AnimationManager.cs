using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualEffects;
using VisualEffects.Animations.Effects;
using VisualEffects.Easing;

namespace UI_Play.Animation
{
    class AnimationManager
    {
        static public void SinkLabel(Label label1, Label label2, int y1, int y2 )
        {
            Animator.Animate(label1, new YLocationEffect(), EasingFunctions.Linear, y1, 500, 0);
            Animator.Animate(label2, new YLocationEffect(), EasingFunctions.Linear, y2, 500, 0);
        }

        static public void RiseLabel(Label label1, Label label2, int y1, int y2)
        {
            Animator.Animate(label1, new YLocationEffect(), EasingFunctions.Linear, y1, 500, 0);
            Animator.Animate(label2, new YLocationEffect(), EasingFunctions.Linear, y2, 500, 0);
        }
    }
}
