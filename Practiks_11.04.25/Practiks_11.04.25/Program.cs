using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiks_11._04._25
{
    //Создаем интерфейс
    public interface IPerson
    {
        void DisplayInfo();
        string GetRole();
    }
    //Создаем множества типов абонемента и ролей
    public enum MembershipType
    {
        Monthly,
        Yearly,
        Dropln
    }
    public enum RoleType
    {
        Client,
        Trainer
    }

    public struct ContactInfo
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ContactInfo(string email, string phoneNumber) 
        { 
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public void Print()
        {
            Console.WriteLine("Email: " + Email + "\nТелефонный номер: " + PhoneNumber);
        }
    }

    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo Contact { get; set; }
        private RoleType role; 
        public Person(string firstName, string lastName, ContactInfo contact)
        {
            FirstName = firstName;
            LastName = lastName;
            Contact = contact;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Имя, Фамилия: {FirstName} {LastName}");
            Console.WriteLine("Контактная информация:");
            Contact.Print();
        }

        public string GetRole()
        {
            if (this is Client)
            {
                return "Клиент";
            }
           else if (this is Trainer)
            {
                return "Тренер";
            }
            throw new Exception();
        }

    }

    public class Client : Person
    {
        public string ClientID { get; set; }
        public MembershipType Membership { get; set; }
        public static int cleintCount = 0;
        public Client(string firstname, string lastname, ContactInfo contact, MembershipType membership) : base(firstname, lastname, contact) 
        {
            ClientID = $"К-{lastname[0]}{FirstName[0]}-{++cleintCount}";
            Membership = membership;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(GetRole());
            Console.WriteLine($"ID: {ClientID}");
            Console.WriteLine($"Имя, Фамилия:{FirstName} {LastName}");
            Console.Write("Абонемент: ");

            switch (Membership)
            {
                case MembershipType.Dropln: Console.Write("Недельный\n"); break;
                case MembershipType.Monthly: Console.Write("Месячный\n"); break;
                case MembershipType.Yearly: Console.Write("Годовой\n"); break;
                default: break;
            }
            Console.WriteLine("Контактная информация:");
            Contact.Print();
            Console.WriteLine("\n");
        }
    }



    class Trainer : Person
    {
        public string TrainerID { get; set; }
        //public List<string> specializations = new List<string>() { "Yoga", "Workout", "WeightLifting", "Aerobics" };
        public List<string> Specializations { get; set; }
        public static int trainerCount = 0;

        public Trainer(string firstname, string lastname, ContactInfo contact, List<string> specializations) : base(firstname, lastname, contact)
        {
            TrainerID = $"Т-{lastname[0]}{FirstName[0]}-{++trainerCount}";
            
            this.Specializations = specializations;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine(GetRole());
            Console.WriteLine("ID: " + TrainerID);
            Console.WriteLine($"Имя, Фамилия: {FirstName} {LastName}");
            Console.Write("Специализации: ");
            for (int i = 0; i < Specializations.Count; i++)
            {
                Console.WriteLine(Specializations[i]);
            }
            Console.WriteLine("Контактная информация:");
            Contact.Print();
            Console.WriteLine("\n");
        }
    }

    class FitnessCenter
    {
        private List<Client> clients;
        private List<Trainer> trainers;

        public FitnessCenter()
        {
            clients = new List<Client>();
            trainers = new List<Trainer>();
        }

        public void AddClient(Client client) 
        { 
        clients.Add(client);
        }

        public void AddTrainer(Trainer trainer) 
        {
            trainers.Add(trainer);
        }

        public void RemoveClient(Client client)
        {
            clients.Remove(client);
        }
        public void RemoveTrainer(Trainer trainer) 
        
        {
            trainers.Remove(trainer);
        }

        public void GetALLInfo() 
        {
            foreach (Client client in clients)
            {
                client.DisplayInfo();
            }
            foreach (Trainer trainer in trainers)
            {
                trainer.DisplayInfo();
            }
        }
    }

    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            var client1 = new Client
            (
                "Петр",
                "Гончаров",
                new ContactInfo(
                    "PetroGon@mail.ru",
                    "8-800-555-35-35"
                    ),
                MembershipType.Dropln
            );
            var client2 = new Client
            (
                "Алексей",
                "Журавлев",
                new ContactInfo(
                    "AlexJur@mail.ru",
                    "8-777-555-69-30"
                    ),
                MembershipType.Monthly
            );
            var client3 = new Client
            (
                "Владислав",
                "Горбенко",
                new ContactInfo(
                    "VladiSlave@mail.ru",
                    "8-777-555-35-85"
                    ),
                MembershipType.Yearly
            );
            var trainer = new Trainer
            (
                "Кирил",
                "Силонов",
                new ContactInfo(
                    "SilaMaster@mail.ru",
                    "8-333-555-46-66"
                    ),
                new List<string>
                {
                    "Силовая тренировка",
                    "Кардионагрузки",
                    "Воркаут"
                }
            );
            var fitnessCentr = new FitnessCenter();
            fitnessCentr.AddTrainer( trainer );

            fitnessCentr.AddClient(client1);
            fitnessCentr.AddClient(client2);
            fitnessCentr.AddClient(client3);

            fitnessCentr.GetALLInfo();

            Console.WriteLine(client1.GetRole());
            Console.WriteLine(trainer.GetRole());
            
        }
    }
}
