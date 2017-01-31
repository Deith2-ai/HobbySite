using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.DTO
{
    public interface IModel
    {
        long Id { get; set; }

        DateTime? CreateDate { get; set; }

        byte[] RowVersion { get; set; }
    }
}
