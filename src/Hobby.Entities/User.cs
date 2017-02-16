using System;
using System.Collections.Generic;

namespace Hobby.Entities
{
    public class User : IEntity
    {
        #region IEntity
        public virtual long Id { get; set; }

        public virtual DateTime? CreateDate { get; set; }

        public virtual byte[] RowVersion { get; set; }
        #endregion

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string Email { get; set; }

        public virtual string Password { get; set; }

        public virtual string City { get; set; }

        public virtual string Avatar { get; set; }

        public virtual ICollection<Activities> Activities { get; set; }

        public virtual ICollection<Setting> Settings { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}
