using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsCRUDWithImageMVC.Models
{
    public class ListsModel
    {
        public int RollNo { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int Fees { get; set; }
        public DateTime JoiningDate { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
        public byte[] Image { get; set; }  

    }
}