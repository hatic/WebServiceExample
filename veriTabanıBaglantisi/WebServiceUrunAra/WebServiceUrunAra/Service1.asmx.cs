using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace WebServiceUrunAra
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public System.Data.DataSet urunAra(string kelime)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            string cs = "Data Source=USER-PC\\MSSQLSERVERS;User=sa; Password=12345;Initial Catalog=TIGERPLUS;";
            SqlConnection conn = new SqlConnection(cs);
            string query="select CODE,NAME from LG_014_ITEMS where NAME like '%"+kelime+"%'";
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
    }
}