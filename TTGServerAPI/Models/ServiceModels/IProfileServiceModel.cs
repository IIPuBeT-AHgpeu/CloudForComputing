namespace TTGServerAPI.Models.ServiceModels
{
    public interface IProfileServiceModel
    {
        public bool AuthIsSuccessfull { get; set; }
        public string? Name { get; set; }
        public string AnswerDescryption { get; set; }
    }
}
