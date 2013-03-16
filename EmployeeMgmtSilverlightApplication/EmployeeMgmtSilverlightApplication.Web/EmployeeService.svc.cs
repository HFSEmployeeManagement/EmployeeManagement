using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EmployeeEntity;
using EmployeeBusinesslayer;
using System.Collections.Generic;

namespace EmployeeMgmtSilverlightApplication.Web
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class EmployeeService
    {
        Entity ent = new Entity();
        [OperationContract]
        public void DoWork(Entity ent)
        {
            // Add your operation implementation here
            return;
        }
        [OperationContract]
        public int Employee(Entity ent)
        {

          
            Business b = new Business();
            return b.CreateEmp(ent);

        }

        [OperationContract]
        public List<Entity> SelectAll()
        {
           
            Business bb = new Business();
            return bb.SelectEmployee();


            //return getemp.ToList();
        }
        // Add more operations here and mark them with [OperationContract]
    }
}
