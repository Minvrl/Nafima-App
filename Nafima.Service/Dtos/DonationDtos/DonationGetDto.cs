using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Dtos.DonationDtos
{
    public class DonationGetDto
    {
        public int Id { get; set; }
        public bool OneTime { get; set; }
        public string? FullName { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public float Amount { get; set; }
        public bool IsAnon { get; set; }
    }
}
