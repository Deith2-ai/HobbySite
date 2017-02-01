using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.Entities
{
    public class Activity : IEntity
    {
        #region IEntity
        public virtual long Id { get; set; }

        public virtual DateTime? CreateDate { get; set; }

        public virtual byte[] RowVersion { get; set; }
        #endregion

        public virtual string ActivityName { get; set; }

        public virtual User User { get; set; }
    }
}
