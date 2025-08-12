using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyPinger.Core.Utils
{
    public class AnimationHandler
    {
        public int WaitTimeToHideLogo { get; set; } = 4000;

        public bool IsTopLogoVisible { get; set; } = true;

        public int DevicesRow { get; set; } = 1;

        public int DevicesRowSpan { get; set; } = 1;
    }
}
