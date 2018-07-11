using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class OutgoingMessage
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserToId { get; set; }
        [Required(ErrorMessage = "Введите текст сообщения")]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
