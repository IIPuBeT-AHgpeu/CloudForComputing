namespace TTGServerAPI.Services
{
    public class MapInfoService : IService
    {
        public TTG_ver3Context? Context { get; set; }

        public MapInfoService(TTG_ver3Context? context)
        {
            if (context == null)
                throw new Exception("Invalid DB context!");
            else
                Context = context;
        }
    }
}
