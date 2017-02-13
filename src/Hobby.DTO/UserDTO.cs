using System;

namespace Hobby.DTO
{
    public class UserDTO : IModel
    {
        #region IModel
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
        
    }
}
