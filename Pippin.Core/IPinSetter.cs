using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pippin.Core
{
    public interface IPinSetter
    {
        Task SetPinAsync(int pinNumber, bool on);
        void SetPin(int pinNumber, bool on);
    }
}
