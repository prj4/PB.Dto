using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB.Dto
{
    public class InsertPictureModel
    {

        [Required]
        public string PictureString { get; set; }

        [Required] public string EventPin { get; set; }

    }


    public class PicturesAnswerModel
    {
        [Required]
        public List<int> PictureList { get; set; }
    }
}
