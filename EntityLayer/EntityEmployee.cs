﻿namespace EntityLayer
{
    public class EntityEmployee
    {
        private int id;
        private string name;
        private string surname;
        private string city;
        private string duty;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string City { get => city; set => city = value; }
        public string Duty { get => duty; set => duty = value; }
    }
}
