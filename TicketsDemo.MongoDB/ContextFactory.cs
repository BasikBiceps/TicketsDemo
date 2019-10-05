using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsDemo.MongoDB
{
    public class ContextFactory : IContextFactory
    {
        public ISettingsProvider _sp { get; set;}

        public ContextFactory(ISettingsProvider sp)
        {
            _sp = sp;
        }

        public IContext CreateContext()
        {
            return new TicketsContext(_sp);
        }
    }
}
