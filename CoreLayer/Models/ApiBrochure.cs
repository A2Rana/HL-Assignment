using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelsDTOLayer
{
    public class ApiBrochure
    {
        public int Id { get; set; }
        public string Ftp { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }

    }

}
