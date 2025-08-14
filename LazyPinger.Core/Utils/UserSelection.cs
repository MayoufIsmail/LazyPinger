using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyPinger.Core.Utils
{
    public class UserSelection
    {
        public int ID {  get; set; }

        public string Name { get; set; }

        public bool IsAutoRunEnabled { get; set; }

        public bool IsFastPingEnabled { get; set; }
    }
}
