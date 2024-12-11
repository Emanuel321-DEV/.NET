﻿using CleanArchMVC.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Domain.Entities
{
    public sealed class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            ValidateDomain(name);
            Id = id;
        }


        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid Name, Name is required");

            DomainExceptionValidation.When(name.Length < 3, "Invalid Name, too short, minimum 3 charecters");

            Name = name;
        }

    }
}