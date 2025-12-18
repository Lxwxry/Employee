using System.Collections.Generic;
using System.Linq;

public static class DatabaseControl
{
    public static List<Employee> GetEmployeeList()
    {
        using (DbAppContext ctx = new DbAppContext())
        {
            return ctx.Employee.ToList();
        }
    }
}
