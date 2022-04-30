namespace TTGServerAPI.Models.ServiceModels
{
    public class PassengerProfileServiceModel : IProfileServiceModel
    {
        public string? Name { get; set; }
        public bool AuthIsSuccessfull { get; set; }
        public string AnswerDescryption { get; set; }
    }
}
