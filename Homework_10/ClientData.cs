using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;


namespace Homework_10
{
    public class ClientData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }

        public ClientData(string firstName, string lastName, string patronymic, string phoneNumber, string passport)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            Passport = passport;
        }
/*
        public virtual void ChangePhoneNumber(string newPhoneNumber)
        {
            PhoneNumber = newPhoneNumber;
        }
        protected virtual string GetPassportInfo()
        {
            return IsConsultantMode ? "******************" : Passport;
        }

        protected static bool IsConsultantMode;
*/
    }

    /*
    public class Consultant : ClientData
    {
        public Consultant(string firstName, string lastName, string patronymic, string phoneNumber, string passport)
            : base(firstName, lastName, patronymic, phoneNumber, passport)
        {
            // В режиме консультанта необходимо скрыть информацию о паспорте
            IsConsultantMode = true;
        }

        public override void ChangePhoneNumber(string newPhoneNumber)
        {
            if (!string.IsNullOrEmpty(newPhoneNumber))
            {
                base.ChangePhoneNumber(newPhoneNumber);
            }
            else
            {
                Console.WriteLine("Номер телефона не может быть пустым.");
            }
        }
    }

    public class Manager : ClientData
    {
        public Manager(string firstName, string lastName, string patronymic, string phoneNumber, string passport)
            : base(firstName, lastName, patronymic, phoneNumber, passport)
        {
            IsConsultantMode = false;
        }
    }
    */
}
