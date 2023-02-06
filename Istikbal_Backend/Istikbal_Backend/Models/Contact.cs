using System;

namespace Istikbal_Backend.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Filial { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
