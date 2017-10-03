using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectOnTracker.Models
{
    public class SalesContext:DbContext
    {
        public SalesContext():base("name=DbConnectionString")
        {
            
        }

     

        public DbSet<BuyerDesignation> designation { get; set; }
        public DbSet<BuyerInfo> buyerinformation { get; set; }
        public DbSet<BuyerPriority> buyerpriority { get; set; }
        public DbSet<BuyerSource> buyersource { get; set; }
        public DbSet<BuyerStatus> buyerstatus { get; set; }
        public DbSet<CommunicationInfo> communicationinfo { get; set; }
        public DbSet<CommunicationMedium> communicationmedium { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<TransferredTo> transferredto { get; set; }
        public DbSet<Website> website { get; set; }
    }
}