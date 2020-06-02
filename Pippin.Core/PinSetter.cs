using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pippin.Core
{
    public class PinSetter : IPinSetter
    {
        private readonly List<IPinAdapter> _adapters;

        public PinSetter(IEnumerable<IPinAdapter> adapters)
        {
            _adapters = adapters.ToList();
        }

        public void SetPin(int pinNumber, bool on)
        {
            foreach(var adapter in _adapters)
            {
                adapter.SetPin(pinNumber, on);
            }
        }

        public async Task SetPinAsync(int pinNumber, bool on)
        {
            foreach (var adapter in _adapters)
            {
                await adapter.SetPinAsync(pinNumber, on);
            }
        }
    }
}
