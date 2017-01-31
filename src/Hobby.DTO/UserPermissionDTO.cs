using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.DTO
{
    public class UserPermissionDTO : IModel
    {
        #region IModel
        public long Id { get; set; }

        public virtual DateTime? CreateDate { get; set; }

        public virtual byte[] RowVersion { get; set; }
        #endregion

        public virtual long IdUser { get; set; }

        public virtual long IdPermission { get; set; }

        public virtual DateTime? LastModifyDate { get; set; }
    }
}
