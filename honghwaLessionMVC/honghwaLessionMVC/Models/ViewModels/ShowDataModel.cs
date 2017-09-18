using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace honghwaLessionMVC.Models.ViewModels
{
    public class ShowDataModel
    {
        public int ItemNo { get; set; }

        public string Category { get; set; }

        public int Money { get; set; }

        [DisplayFormat(DataFormatString ="{0:d}")]
        public DateTime Date { get; set; }

        public string Remark { get; set; }

    }
}