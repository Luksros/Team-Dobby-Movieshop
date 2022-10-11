﻿using Team_Dobby_Movieshop.Models;

namespace Team_Dobby_Movieshop.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public T Add(T item);
        public T Update(T item, int id);
        public T Delete(int id);

    }
}
