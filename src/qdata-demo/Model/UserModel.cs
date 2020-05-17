using System;
using RoyLab.QData.Demo.Enums;

namespace RoyLab.QData.Demo.Model
{
    public class UserModel
    {
        public UserModel(string name)
        {
            Name = name;
        }

        public Guid Id { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Name { get; set; }
    }
}