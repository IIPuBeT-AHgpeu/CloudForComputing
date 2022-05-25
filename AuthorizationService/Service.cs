using AuthorizationService.Models.DBModels;
using AuthorizationService.Models.ServiceModels;

namespace AuthorizationService
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

        public object LogIn(char category, string login, string password)
        {
            category = category.ToString().ToUpper()[0];

            switch (category)
            {
                case 'P':
                    {
                        Passenger passenger;
                        try
                        {
                            passenger = Context.Passengers.First(pas => pas.Login == login);
                        }
                        catch (Exception)
                        {
                            return new PassengerProfile()
                            {
                                AuthIsSuccessfull = false,
                                Name = null,
                                AnswerDescryption = "Passenger login " + login + " did not founded."
                            };
                        }
                        if (passenger.Password == password)
                        {
                            return new PassengerProfile()
                            {
                                AuthIsSuccessfull = true,
                                Name = passenger.Name,
                                AnswerDescryption = "Successfull."
                            };
                        }
                        else
                        {
                            return new PassengerProfile()
                            {
                                AuthIsSuccessfull = false,
                                Name = null,
                                AnswerDescryption = "Incorrect password."
                            };
                        }
                    }
                case 'O':
                    {
                        Owner owner;
                        try
                        {
                            owner = Context.Owners.First(own => own.Login == login);
                        }
                        catch (Exception)
                        {
                            return new OwnerProfile()
                            {
                                AuthIsSuccessfull = false,
                                Name = null,
                                License = null,
                                AnswerDescryption = "Owner login " + login + " did not founded."
                            };
                        }
                        if (owner.Password == password)
                        {
                            return new OwnerProfile()
                            {
                                AuthIsSuccessfull = true,
                                Name = owner.Name,
                                License = owner.License,
                                AnswerDescryption = "Successfull."
                            };
                        }
                        else
                        {
                            return new OwnerProfile()
                            {
                                AuthIsSuccessfull = false,
                                Name = null,
                                License = null,
                                AnswerDescryption = "Incorrect password."
                            };
                        }
                    }
                case 'U':
                    {
                        Unit unit;
                        try
                        {
                            unit = Context.Units.First(pas => pas.Login == login);
                        }
                        catch (Exception)
                        {
                            return new DriverProfile()
                            {
                                AuthIsSuccessfull = false,
                                AnswerDescryption = "Unit login " + login + " did not founded."
                            };
                        }
                        if (unit.Password == password)
                        {
                            return new DriverProfile()
                            {
                                AuthIsSuccessfull = true,
                                Name = unit.Name,
                                Model = unit.Model,
                                Number = unit.Number,
                                Status = unit.Status,
                                Passport = unit.Passport,
                                AnswerDescryption = "Successfull."
                            };
                        }
                        else
                        {
                            return new DriverProfile()
                            {
                                AuthIsSuccessfull = false,
                                AnswerDescryption = "Incorrect password."
                            };
                        }
                    }
                default:
                    {
                        return new PassengerProfile()
                        {
                            AuthIsSuccessfull = false,
                            Name = null,
                            AnswerDescryption = "Invalid category: " + category
                        };
                    }
            }
        }
    }
}
