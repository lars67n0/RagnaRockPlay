using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace razor_pages_eksamen_fis.Models
{
    public class SoundList
    {

        public int ID { get; set; }
        public string SoundName { get; set; }

        [DataType(DataType.Date)]
        public DateTime RealeaseDate { get; set; }
        public string SubTitle { get; set; }
        public string SoundInfo { get; set; }





    }
}
