using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pippin.Core
{
    public class ActionPinAdapter : IPinAdapter
    {
        private readonly Action<int, bool> _pinUpdateAction;

        public ActionPinAdapter(Action<int, bool> pinUpdateAction)
        {
            _pinUpdateAction = pinUpdateAction;
        }

        public void SetPin(int pinNumber, bool on) => _pinUpdateAction?.Invoke(pinNumber, on);

        public Task SetPinAsync(int pinNumber, bool on) => Task.Run(() => SetPin(pinNumber, on));
    }
}
