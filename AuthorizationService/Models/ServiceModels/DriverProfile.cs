namespace AuthorizationService.Models.ServiceModels
{
    public class DriverProfile : ProfileBase
    {
        public string? Model { get; set; }
        public string? Number { get; set; }
        public string? Status { get; set; }
        public string? Passport { get; set; }
    }
}
