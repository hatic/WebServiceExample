using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace perakendeMagazaWebServis
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
        
        int toplam = 0,carpim=0,IkiSayifarki=0,bolum=0;
        [WebMethod]
        public int topla(int a,int b)
        {   
            toplam = a + b;
            return toplam;
        }
        [WebMethod]
        public int carp(int a, int b)
        {
            carpim = a * b;
            return carpim;
        }
        [WebMethod]
        public int fark(int a, int b)
        {
            IkiSayifarki = a - b;
            return IkiSayifarki;
        }
        [WebMethod]
        public int bol(int a, int b)
        {
            bolum = a / b;
            return bolum;
        }

    }
}