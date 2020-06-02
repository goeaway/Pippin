using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Pippin.Core;
using Unosquare.RaspberryIO;
using Unosquare.WiringPi;
using Unosquare.RaspberryIO.Abstractions;

namespace Pippin.Adapters.Unosquare
{
    public class UnosquarePinAdapter : IPinAdapter
    {
        public UnosquarePinAdapter()
        {
            Pi.Init<BootstrapWiringPi>();
        }

        public void SetPin(int pinNumber, bool on)
        {
            var pin = Pi.Gpio[pinNumber];
            pin.PinMode = GpioPinDriveMode.Output;
            pin.Write(on);
        }

        public Task SetPinAsync(int pinNumber, bool on)
        {
            return Task.Run(() => SetPin(pinNumber, on));
        }
    }
}
