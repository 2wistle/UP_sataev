using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Drawing;

namespace UP
{
    [Table(Name = "Service")]
    public class Service
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public string Title { get; set; }
        [Column]
        public decimal Cost { get; set; }
        [Column]
        public int DurationInSeconds { get; set; }
        [Column]
        public string Description { get; set; }
        [Column]
        public double Discount { get; set; }
        [Column]
        public string MainImagePath { get; set; }
        
        public Image Image { get; set; }
    }
    [Table(Name = "ClientService")]
    class ClientServ
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int Id { get; set; }
        [Column(Name = "ClientID")]
        public int ClientID { get; set; }
        [Column(Name = "ServiceID")]
        public int ServiceID { get; set; }
        [Column(Name = "StartTime")]
        public DateTime StartTime { get; set; }
        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }
}
