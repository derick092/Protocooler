using Protocooler.App;

namespace Protocooler.Data
{
    public sealed class FakeDB
    {
        private FakeDB() 
        {
            ProtocolData = new List<Protocol>();
            CurrentDay = DateOnly.FromDateTime(DateTime.Today);
            LastProtocol = 1;
        }

        private static FakeDB _data;

        public static FakeDB GetInstance()
        {
            if( _data == null)
            {
                _data = new FakeDB();
            }

            return _data;
        }

        public int LastProtocol;
        public DateOnly CurrentDay;
        public List<Protocol> ProtocolData;

    }
}
