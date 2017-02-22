using System;

namespace Hobby.Entities
{
    public class UserPermission : IEntity
    {
        #region IEntity
        public long Id { get; set; }

        public virtual DateTime? CreateDate { get; set; }

        public virtual byte[] RowVersion { get; set; }
        #endregion

        public virtual long IdUser { get; set; }

        public virtual long IdPermission { get; set; }

        public virtual DateTime? LastModifyDate { get; set; }

        public virtual Permission Permission { get; set; }

        public virtual User User { get; set; }
    }
}
