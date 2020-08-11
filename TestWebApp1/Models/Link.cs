using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HomePageApp.Models
{
    //Sets the properties for the Links panel get and post requests.
    public class Link
    {
        [Key]
        public int Id { get; set; }
        public string WebsiteName { get; set; }
        public string WebsiteAddress { get; set; }
        public string IcoAddress { get; set; }
    }
}
