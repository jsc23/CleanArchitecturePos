﻿using Domain.Primitives;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers
{
    public sealed class Customer : AggregateRoot
    {
        public Customer(CustomerId id, string name, string lastName, string eMail, PhoneNumber phoneNumber, Address address, bool active)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            this.eMail = eMail;
            PhoneNumber = phoneNumber;
            Address = address;
            Active = active;
        }

        private Customer()
        {

        }

        public CustomerId Id { get; private set; }

        public string Name { get; private set; }

        public string LastName { get; private set; } = string.Empty;

        public string Fullname => $"{Name} {LastName}";

        public string eMail { get; private set; } = string.Empty;

        public PhoneNumber PhoneNumber { get; private set; }

        public Address Address { get; private set; }

        public bool Active { get; set; }

    }
}
