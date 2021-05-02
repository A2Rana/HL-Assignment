using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsDTOLayer.Models
{
    public class GenericAPIModel<T>
    {
        public string Time { get; set; }
        public string ErrorMessage { get; set; }
        public string Server { get; set; }
        public string Status { get; set; }
        public T Result { get; set; }
    }
}
