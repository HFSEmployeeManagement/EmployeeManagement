using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using EmployeeBusinesslayer;
using EmployeeEntity;

namespace Employee3Tier
{
    public partial class Employee : System.Web.UI.Page
    {
        Entity ent = new Entity();
        ServiceReference2.Service1Client sc = new ServiceReference2.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            IList<Entity> list = new List<Entity>();
            list = sc.getEmployee();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {

            ent.Employeeid = Convert.ToInt32(txtid.Text);
            ent.Firstname = Convert.ToString(txtfirstname.Text);
            ent.Lastname = Convert.ToString(txtlastname.Text);
            ent.Birthdate = Convert.ToString(txtbirthdate.Text);
            ent.Sex = Convert.ToString(txtsex.Text);
            int result = sc.CreateEmp(ent);
            lblresult.Text = result.ToString();
        }
    }
}