using BizsolTechAssessment.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BizsolTechAssessment.Models.DataAccessLayer
{
    public class AllRepository<T> : IAllRepository<T> where T : class
    {
        private readonly DataContext _context;
        private DbSet<T> dbEntity;
        public AllRepository(DataContext context)
        {
            this._context = context;
            this.dbEntity = _context.Set<T>();
        }
        public async Task<List<T>> GetData()
        {
            return await dbEntity.ToListAsync();
        }

        public T AddRecord(T record)
        {
            this.dbEntity.Add(record);
            return record;
        }

        public void UpdateRecord(T record)
        {
            _context.Entry(record).State = EntityState.Modified;
        }

        public void DeleteRecord(int recordID)
        {
            var record = this.dbEntity.Find(recordID);
            this.dbEntity.Remove(record);
        }

        public T GetRecordByID(int recordID)
        {
            return dbEntity.Find(recordID);
        }

        public void Save()
        {
            this._context.SaveChanges();
        }

        public void UpdateRecordEntity(T record)
        {
            _context.Entry(record).State = EntityState.Modified;
        }
    }
}
