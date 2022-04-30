namespace TTGServerAPI.Models.ServiceModels
{
    public class OwnerProfileServiceModel : IProfileServiceModel
    {
        public bool AuthIsSuccessfull { get; set; }
        public string? Name { get; set; }
        public string? License { get; set; }
        public string AnswerDescryption { get; set; }
    }
}
