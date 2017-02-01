using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.DTO
{
    public class ActivitiesDTO : IModel
    {
        #region IModel
        public virtual long Id { get; set; }

        public virtual DateTime? CreateDate { get; set; }

        public virtual byte[] RowVersion { get; set; }
        #endregion

        public virtual string ActivityName { get; set; }
    }
}
