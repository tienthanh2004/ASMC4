
using App_Data_ClassLib.Models;
using DuAnC4.IAllRepos;
using Microsoft.EntityFrameworkCore;


namespace DuAnC4.AllRepos
{
	public class AllRepos<G> : IAllRepos<G> where G : class
    {
        ASMC4Context _context;
        DbSet<G> dbset;
        public AllRepos()
        {
            _context = new ASMC4Context();
        }
        public AllRepos(DbSet<G> dbset, ASMC4Context context)
        {
            this.dbset = dbset;
            this._context = context;
        }
        public bool CreateObj(G obj)
        {
            try
            {
                dbset.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateObj(G obj)
        {
            try
            {
                dbset.Update(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteObj(dynamic id)
        {
            try
            {
                var idDel = dbset.Find(id);
                dbset.Remove(idDel);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public ICollection<G> GetAll()
        {
            return dbset.ToList();
        }
        public G GetByID(dynamic id)
        {
            return dbset.Find(id);
        }

    }
}
