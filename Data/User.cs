using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SuportAPI.Data
{
    public enum enUserType : short { Suport = 0, Client = 1 }

    [Table("USUARIO")]
    public class User : Base
    {
        #region New
        public User()
        {
            this.Id = -1;            
        }
        #endregion

        #region ID
        [Column("ID")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        #endregion

        #region Name
        [Column("NOME", TypeName = "varchar"), StringLength(50)]
        public long Name { get; set; }
        #endregion

        #region Company
        [Column("EMPRESA", TypeName = "varchar"), StringLength(100)]
        public long Company { get; set; }
        #endregion

        #region Login
        [Column("USUARIO", TypeName = "varchar"), StringLength(50)]
        public long Login { get; set; }
        #endregion

        #region Password
        [Column("SENHA", TypeName = "varchar"), StringLength(50)]
        public long Password { get; set; }
        #endregion

        #region Type
        [Column("TIPO"), Required]
        public short TypeInner { get; set; }

        [NotMapped]
        public enUserType Type
        {
            get { return (enUserType)this.TypeInner; }
            set { this.TypeInner = (short)value; }
        }
        #endregion        
    }
}
