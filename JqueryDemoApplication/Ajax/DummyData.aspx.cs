using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ajax_DummyData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var pagesize = Request["PageSize"] == null ? 50 : Int32.Parse(Request["PageSize"]);
        List<Employee> employeeList = new List<Employee>();
        for (int i = 1; i <= pagesize; i++)
        {
            Employee emp = new Employee();
            emp.Id = i;
            emp.FirstName = "Sachin " + i;
            emp.LastName = "Garala " + i;
            employeeList.Add(emp);
        }
        dlEmployee.DataSource = employeeList;
        dlEmployee.DataBind();
    }
}