using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BizsolTechAssessment.Models.DataAccessLayer
{
    public interface IAllRepository<T> where T : class
    {
        public Task<List<T>> GetData();

        public T AddRecord(T record);

        public void UpdateRecord(T record);

        public void UpdateRecordEntity(T record);

        public void DeleteRecord(int recordID);

        public T GetRecordByID(int recordID);

        public void Save();
    }
}
