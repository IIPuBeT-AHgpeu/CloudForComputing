namespace TTGServerAPI.Models.ServiceModels
{
    public class UnitProfileServiceModel : IProfileServiceModel
    {
        public bool AuthIsSuccessfull { get; set; }
        public string? Name { get; set; }
        public string? Model { get; set; }
        public string? Number { get; set; }
        public string? Status { get; set; }
        public string? Passport { get; set; }
        public string AnswerDescryption { get; set; }
    }
}
