using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using themiamiagency.Models;

namespace themiamiagency.API
{
    public partial class APIClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:54652/");
            var autoquote = new AutoQuote() { FirstName = "Aura", LastName = "Rodriguez", PhoneNumber = "954-662-2188", Email = "jcs571@yahoo.com", ZipCode = "33029" };
            client.PostAsJsonAsync("api/AutoQuote", autoquote);
        }
    }
}