using Protocooler.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protocooler.Data
{
    public class ProtocolRepository
    {
        private FakeDB _db;

        public ProtocolRepository()
        {
            _db = FakeDB.Data();
        }

        public void AddProtocol(Protocol obj) 
        {
            obj.Id = _db.lastProtocolId + 1;
            _db.ProtocolData.Add(obj);
            _db.lastProtocolId = +1;
        }
    }
}
