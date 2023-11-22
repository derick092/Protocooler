namespace Protocooler.App
{
    public class Protocol
    {
        public string? Company { get; set; }
        public string? Date { get; set; }
        public string? Id { get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", Company, Date, Id);
        }
    }
}
