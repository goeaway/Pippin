using Pippin.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pippin
{ 
    public class PippinOptions
    {
        internal IList<Func<IPinAdapter>> AdapterFactories { get; }
            = new List<Func<IPinAdapter>>();

        public void AddSingletonAdapter(IPinAdapter adapter)
        {
            if(adapter == null)
            {
                throw new ArgumentNullException(nameof(adapter));
            }

            AdapterFactories.Add(() => adapter);
        }

        public void AddAdapter(Func<IPinAdapter> adapterFactory)
        {
            if(adapterFactory == null)
            {
                throw new ArgumentNullException(nameof(adapterFactory));
            }

            AdapterFactories.Add(adapterFactory);
        }
    }
}
