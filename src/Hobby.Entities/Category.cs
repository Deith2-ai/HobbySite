using System;

namespace Hobby.Entities
{
    public class Category : IEntity
    {
        #region IEntity
        public virtual long Id { get; set; }

        public virtual DateTime? CreateDate { get; set; }

        public virtual byte[] RowVersion { get; set; }
        #endregion

        public virtual string Name { get; set; }
    }
}
