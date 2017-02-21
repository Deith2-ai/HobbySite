using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.Entities
{
    public class Activities : IEntity
    {
        #region IEntity
        public virtual long Id { get; set; }

        public virtual DateTime? CreateDate { get; set; }

        public virtual byte[] RowVersion { get; set; }
        #endregion

        public virtual long IdUser { get; set; }

        public virtual string ActivityName { get; set; }

        public virtual User User { get; set; }        
    }
}
