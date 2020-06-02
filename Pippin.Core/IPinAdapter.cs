using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pippin.Core
{
    public interface IPinAdapter
    {
        Task SetPinAsync(int pinNumber, bool on);
        void SetPin(int pinNumber, bool on);
    }
}
