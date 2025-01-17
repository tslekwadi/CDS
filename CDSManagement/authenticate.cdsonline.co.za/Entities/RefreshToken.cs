﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace authenticate.cdsonline.co.za.Entities
{
    public class RefreshToken
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Subject { get; set; }
        [Required]
        [MaxLength(50)]
        public string ClientId { get; set; }
        public DateTime IssuedUtc { get; set; }
        public DateTime ExpiresUtc { get; set; }
        [Required]
        public string ProtectedTicket { get; set; }
    }
}