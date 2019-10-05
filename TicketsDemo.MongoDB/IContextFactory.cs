using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsDemo.MongoDB
{
    public interface IContextFactory
    {
        IContext CreateContext();
    }
}
