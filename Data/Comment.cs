﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuportAPI.Data
{
    [Table("COMENTARIO")]
    public class Comments : Base
    {
        #region New
        public Comments()
        {
            this.Id = -1;
        }
        #endregion

        #region ID
        [Column("ID")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        #endregion

        #region TicketUserId
        [Column("TICKET_USUARIO_ID")]
        public long TicketUserId { get; set; }

        [ForeignKey("ID")]
        public TicketUser fkTicketUserId { get; set; }
        #endregion

        #region Comment
        [Column("COMENTARIO", TypeName = "varchar"), StringLength(4000)]
        public long Comment { get; set; }
        #endregion

    }
}
