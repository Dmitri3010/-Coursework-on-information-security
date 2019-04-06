using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string MessageContent { get; set; }

        public DateTime Date { get; set; }

        public User user { get; set; }

        public int UserId { get; set; }


    }
}
