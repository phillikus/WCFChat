﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Person
    {
        [DataMember] 
        public string UserName { get; set; }

        [DataMember] 
        public bool IsConnected { get; set; }

        public Person(string userName)
        {
            UserName = userName;
            IsConnected = false;
        }
    }
}