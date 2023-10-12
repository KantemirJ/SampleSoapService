using SampleSoapService.Data;
using SampleSoapService.Models;

namespace SampleSoapService.Services
{
    public class DatabaseManager : IDatabaseManager
    {
        private readonly SampleSoapServiceContext _context;

        public DatabaseManager(SampleSoapServiceContext context)
        {
            _context = context;
        }
        public string InsertData(Employee data)
        {
            try
            {
                _context.Employees.Add(data);
                _context.SaveChangesAsync();
                return "Data has been inserted successfully!";
            }
            catch
            {
                return "Something has gone wrong!";
            }
            
        }
        public List<Employee> GetDataByName(string name)
        {
            try
            {
                return _context.Employees.Where(e => e.Name == name).ToList();
                
            }
            catch
            {
                return null;
            }

        }
        public List<Employee> GetDataByDepartment(string department)
        {
            try
            {
                return _context.Employees.Where(e => e.Department == department).ToList();

            }
            catch
            {
                return null;
            }

        }
    }
}
