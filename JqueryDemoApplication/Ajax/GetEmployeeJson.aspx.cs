using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ajax_GetEmployeeJson : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ContentType = "application/json";
        int id = Int32.Parse(Request["Id"]);
        Employee emp = new Employee()
        {
            FirstName = "Sachin",
            Id = id,
            LastName = "Garala"
        };
        var ser = new DataContractJsonSerializer(typeof (Employee));
        ser.WriteObject(Response.OutputStream,emp);
    }
}