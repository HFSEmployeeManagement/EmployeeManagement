using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeBusinesslayer;
using EmployeeEntity;


namespace Employee3Tier
{
    public partial class CreateEmployee : System.Web.UI.Page
    {
        Entity ent = new Entity();
        Business bl = new Business();
        protected void Page_Load(object sender, EventArgs e)
        {

            IList<Entity> list = bl.SelectEmployee();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            
            ent.Employeeid = Convert.ToInt32(txtid.Text);
            ent.Firstname = (txtfirstname.Text).ToString();
            ent.Lastname = (txtlname.Text).ToString();
            ent.Birthdate = (txtbirthdate.Text).ToString();
            ent.Sex = (txtsex.Text).ToString();
            string result;
            int i = bl.CreateEmp(ent);
            if (i > 0)
            {
                 result = "Record Inserted Sucessfully";
                 lblresult.Text = (result).ToString();
            }
            
            RefreshGrid();
            ClearTexbox();
        }
        public void RefreshGrid()
        {
            IList<Entity> list = bl.SelectEmployee();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
        public void ClearTexbox()
        {
            txtid.Text = "";
            txtfirstname.Text = "";
            txtlname.Text = "";
            txtbirthdate.Text = "";
            txtsex.Text = "";
        }



    }
}