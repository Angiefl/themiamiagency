using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace themiamiagency.Models
{
    public  class MyDbContext: DbContext
    {
        public MyDbContext()  : base(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\angie\documents\visual studio 2013\Projects\themiamiagency\themiamiagency\App_Data\TheMiamiAgency.mdf;Integrated Security=True") {}
        
        public DbSet<AutoQuote> AutoQuotes { get; set; }     
        
    }

    
}
