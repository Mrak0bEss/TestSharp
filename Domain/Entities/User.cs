﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public User(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public void UpdateName(string newName)
        {
            Name = newName;
        }
    }
}
