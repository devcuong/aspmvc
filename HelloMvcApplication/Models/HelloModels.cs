using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMvcApplication.Models
{

    public class HelloModels
    {
        // Properties
        public String Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }

        public HelloModels()
        {
            this.Id = "SIMT";
            Name = "SIMT Informatics Sololution";
            this.Address = "http://simt.edu.vn";
        }

        public void Save()
        {

        }
    }
}