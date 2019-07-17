using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuportAPI.Data
{
    public enum enStatus : short { New = 0, Open = 1, Pendent = 2, Closed = 3 }
    public enum enType : short { Question = 0, Incident = 1, Problem = 2, Task = 3 }
    public enum enPriority : short { Low = 0, Normal = 1, High = 2, Urgent = 3 }

    [Table("TICKET")]
    public class Ticket : Base
    {
        #region New
        public Ticket()
        {
            this.Id = -1;
            this.Status = enStatus.New;
        }
        #endregion

        #region ID
        [Column("ID")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        #endregion
        
        #region Code
        [Column("CODIGO", TypeName = "varchar"), StringLength(50)]
        public long Code { get; set; }
        #endregion

        #region Description
        [Column("DESCRICAO", TypeName = "varchar"), StringLength(100)]
        public long Description { get; set; }
        #endregion

        #region Type
        [Column("TIPO"), Required]
        public short TypeInner { get; set; }

        [NotMapped]
        public enType Type
        {
            get { return (enType)this.TypeInner; }
            set { this.TypeInner = (short)value; }
        }
        #endregion

        #region Priority
        [Column("PRIORIDADE"), Required]
        public short PriorityInner { get; set; }

        [NotMapped]
        public enPriority Priority
        {
            get { return (enPriority)this.PriorityInner; }
            set { this.PriorityInner = (short)value; }
        }
        #endregion

        #region OpeningDate

        [Column("DATA_ABERTURA"), Required]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        public DateTime OpeningDate { get; set; }

        #endregion

        #region ClosingDate

        [Column("DATA_FECHAMENTO"), Required]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        public DateTime ClosingDate { get; set; }

        #endregion

        #region Status
        [Column("STATUS"), Required]
        public short StatusInner { get; set; }

        [NotMapped]
        public enStatus Status
        {
            get { return (enStatus)this.StatusInner; }
            set { this.StatusInner = (short)value; }
        }
        #endregion
    }
}
