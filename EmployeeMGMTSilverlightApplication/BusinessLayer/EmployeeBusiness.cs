using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDatalayer;
using EmployeeEntity;


namespace BusinessLayer
{
    public class EmployeeBusiness
    {
        EmployeeData edata = new EmployeeData();
        public int CreateEmp(Entity ent)
        {

            return edata.CreateEmp(ent);
        }

        public List<Entity> SelectEmployee()
        {
            EmployeeData data = new EmployeeData();
            return data.SelectEmp();
        }
        public int GetId(Entity ent)
        {
            List<int> idlist = new List<int>();

            idlist = edata.GetEmployeeID();
            int newid = Convert.ToInt32(ent.Employeeid);
            foreach (int dataid in idlist)
            {
                if (newid == dataid)
                {
                    return 0;
                }


            }
            return 1;

        }
    }
}
