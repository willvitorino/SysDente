
using SysDente.Entities;
using SysDente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public class AgendaController : ControllerBase<Agenda>, IAgendaController
    {
        public AgendaController(IServiceBase<Agenda> service) : base(service)
        {
        }
    }
}
            