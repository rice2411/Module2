﻿using System;

namespace AbstratPractice
{
    abstract class  Phone
    {
        public abstract void InsertPhone(string name, string phoneNUmber);
        public abstract void RemovePhone(string nane);
        public abstract void UpdatePhone(string name, string newPhone);
        public abstract void SearchPhone(string name);
        public abstract void Sort();
    }
}
