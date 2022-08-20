using htmlproject.core.domain.Entities;
using System;
using System.Collections.Generic;

namespace KendoUI.Models
{
    public class StudentResponseModel
    {
        public int StatusCode { get; set; }
        public List<Product> Data { get; set; }
        public DateTime Time { get; private set; }
        public List<string> ErrorList { get; private set; }

        public bool IsSuccess { get; set; }
    }
}
