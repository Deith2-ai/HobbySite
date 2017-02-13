using System;

namespace Hobby.DTO
{
    public class SettingDTO : IModel
    {
        #region IModel
        public virtual long Id { get; set; }

        public virtual DateTime? CreateDate { get; set; }

        public virtual byte[] RowVersion { get; set; }
        #endregion

        public virtual decimal IdUser { get; set; }

        public virtual string Name { get; set; }

        public virtual bool Value { get; set; }
    }
}
