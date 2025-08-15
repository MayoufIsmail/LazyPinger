using LazyPinger.Base.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyPinger.Core.Services
{
    public class TextParserService : ITextParserService
    {
        public string AddressToInt(string address)
        {
            throw new NotImplementedException();
        }

        public string GetSubnetFromAddress(string ip)
        {
            var list = ip.Split('.').ToList();
            var subnet = "";
            list.Take(list.Count - 1).ToList().ForEach(o => subnet += $"{o}.");
            return subnet;
        }
    }
}
