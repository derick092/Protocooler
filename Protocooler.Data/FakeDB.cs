using Protocooler.Domain;

namespace Protocooler.Data
{
    public sealed class FakeDB
    {
        private FakeDB() 
        {
            ProtocolData = new List<Protocol>();
        }

        private static FakeDB _data;

        public static FakeDB Data()
        {
            if( _data == null)
            {
                _data = new FakeDB();
            }

            return _data;
        }

        public int lastProtocolId = 0;
        public List<Protocol> ProtocolData;

    }
}
