﻿namespace TTGServerAPI.Services
{
    public class InfoService : IService
    {
        public TTG_ver3Context? Context { get; set; }
        public InfoService(TTG_ver3Context? context)
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
    }
}
