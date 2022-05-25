using TTGServerAPI;

namespace InfoService
{
    public class Service
    {
        public TTG_ver3Context? Context { get; set; }
        public Service(TTG_ver3Context? context)
        {
            if (context == null)
                throw new Exception("Invalid DB context!");
            else
                Context = context;
        }
        public IEnumerable<string> GetAllWayNames()
        {
            return Context.Ways.Select(way => way.Name).OrderBy(name => name).ToList();
        }
        public void UpdateUnitStatus(string number, string newStatus)
        {
            if (newStatus == "Эксплуатируется" || newStatus == "На ремонте")
            {
                Unit unit = Context.Units.First(unit => unit.Number == number);

                unit.Status = newStatus;
                Context.SaveChanges();
            }
        }
    }
}
