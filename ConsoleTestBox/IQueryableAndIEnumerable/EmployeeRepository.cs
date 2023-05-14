using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTestBox.IQueryableAndIEnumerable
{
    public class EmployeeRepository : IDisposable
    {
        private readonly EmployeeContext _context;

        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }
        public IQueryable<EMPLOYEE> Older(int minAge)
        {
            try
            {

                //using (EmployeeContext context = _context)
                //{
                //    //實際要做的只有查詢，並傳址，因此using包住後，會導致return的東西要查詢的時候已經關閉context了
                //    return _context.EMPLOYEE.AsQueryable().Where(emp => emp.AGE > minAge);
                //}
                return _context.EMPLOYEE.AsQueryable().Where(emp => emp.AGE > minAge);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(string id,string name,decimal year,decimal height,decimal weight)
        {
            try
            {
                using (EmployeeContext context = _context)
                {
                    context.EMPLOYEE.Add(new EMPLOYEE(id, name, year, height, weight));
                    context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public void Dispose()
        {
            if (_context != null)
            { 
                _context.Dispose();
            }
        }
    }
}
