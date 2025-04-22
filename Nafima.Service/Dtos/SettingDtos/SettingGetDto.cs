using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Dtos.SettingDtos
{
    public class SettingGetDto
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
