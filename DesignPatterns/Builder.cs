using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class User
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }

    public interface IUserBuilder
    {
        UserBuilder WithName(string name);
        UserBuilder WithFamily(string family);
        UserBuilder WithPhone(string phone);
        UserBuilder WithEmail(string email);
        UserBuilder WithAddress(string address);
        User BuildUser();
    }

    public class UserBuilder : IUserBuilder
    {
        private string _name;
        private string _family;
        private string _phone;
        private string _email;
        private string _address;

        public UserBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
        public UserBuilder WithFamily(string family)
        {
            _family = family;
            return this;
        }
        public UserBuilder WithPhone(string phone)
        {
            _phone = phone;
            return this;
        }
        public UserBuilder WithEmail(string email)
        {
            _email = email;
            return this;
        }
        public UserBuilder WithAddress(string address)
        {
            _address = address;
            return this;
        }
        public User BuildUser()
        {
            return new User()
            {
                Name = _name,
                Family = _family,
                Email = _email,
                Phone = _phone,
                Address = _address
            };
        }

        public static implicit operator User(UserBuilder builder)
        {
            return builder.BuildUser();
        }
    }
}
