using System;

namespace Hobby.DTO
{
    public class PermissionDTO : IModel
    {
        #region IModel
        public virtual long Id { get; set; }

        public virtual DateTime? CreateDate { get; set; }

        public virtual byte[] RowVersion { get; set; }
        #endregion

        public virtual string Name { get; set; }

        public int Value { get; set; }

        public virtual bool Deleted { get; set; }

        public virtual string Description { get; set; }        
    }
}
