using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVC.Models.SampleDO
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? ParentId { get; set; }
        public bool IsActive { get; set; }
    }

}