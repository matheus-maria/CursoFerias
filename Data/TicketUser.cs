using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuportAPI.Data
{
    [Table("TICKET_USUARIO")]
    public class TicketUser : Base
    {
        #region New
        public TicketUser()
        {
            this.Id = -1;
        }
        #endregion

        #region ID
        [Column("ID")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        #endregion

        #region TicketId
        [Column("TICKET_ID")]
        public long TicketId { get; set; }

        [ForeignKey("ID")]
        public Ticket fkTicketId { get; set; }
        #endregion

        #region UserId
        [Column("USUARIO_ID")]
        public long UserId { get; set; }

        [ForeignKey("ID")]
        public User fkUserId { get; set; }
        #endregion
    }
}
