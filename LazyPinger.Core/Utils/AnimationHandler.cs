using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyPinger.Core.Utils
{
    public class AnimationHandler
    {
        public int WaitTimeSplashView { get; set; } = 5000;

        public int WaitTimeToHideLogo { get; set; } = 4000;

        public bool IsTopLogoVisible { get; set; } = true;

        public bool IsSplashViewVisible { get; set; } = true;

        public int DevicesRow { get; set; } = 1;

        public int DevicesRowSpan { get; set; } = 1;
    }
}
