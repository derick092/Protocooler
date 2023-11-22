
using Protocooler.App;
using Protocooler.Data;

var _fakeDB = FakeDB.GetInstance();

var stillRunning = true;

void GenerateNewProtocol (string company) 
{
    var _protocol = new Protocol()
    {
        Company = company.Length > 6 ? company.Substring(0, 6) : company.PadLeft(6, '0'),
        Date = _fakeDB.CurrentDay.ToString("yyyyMMdd"),
        Id = GetId()
    };

    _fakeDB.ProtocolData.Add(_protocol);
}

 string GetId() 
{
    int id = 1;

    if(_fakeDB.CurrentDay == DateOnly.FromDateTime(DateTime.Now)) 
    {
        id = _fakeDB.LastProtocol;
        _fakeDB.LastProtocol += 1;
    }else 
    {
        _fakeDB.LastProtocol = 1;
    }

    return id.ToString().PadLeft(6, '0');
}

while (stillRunning) 
{
    Console.WriteLine("[1] Novo Protocolo");
    Console.WriteLine("[2] Sair");

    var menu = Console.ReadLine();

    if (menu != null)
    {
        switch (menu)
        {
            case "1":
                Console.WriteLine("");
                Console.WriteLine("Digite o identificador da empresa para gerar um novo protocolo");
                var company = Console.ReadLine();

                GenerateNewProtocol(company);

                Console.WriteLine("Protocolo de número: {0} gerado com sucesso!", _fakeDB.ProtocolData.Last());
                Console.WriteLine("");
                break;
            case "2":
                stillRunning = false;
                break;
        }
    }
}
