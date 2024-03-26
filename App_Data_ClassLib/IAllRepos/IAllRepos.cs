﻿namespace DuAnC4.IAllRepos
{
    public interface IAllRepos<T> where T : class
    {
        public ICollection<T> GetAll();
        public T GetByID(dynamic id);
        public bool CreateObj(T obj);
        public bool UpdateObj(T obj);
        public bool DeleteObj(dynamic id);

    }
   
}
