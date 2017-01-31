using System;

namespace Hobby.Entities
{
    public class Setting : IEntity
    {
        #region IEntity
        public virtual long Id { get; set; }

        public virtual DateTime? CreateDate { get; set; }

        public virtual byte[] RowVersion { get; set; }
        #endregion

        public virtual decimal IdUser { get; set; }

        public virtual string Name { get; set; }

        public virtual bool Value { get; set; }

        public virtual User User { get; set; }
    }
}
