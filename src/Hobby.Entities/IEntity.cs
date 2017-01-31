using System;

namespace Hobby.Entities
{
    public interface IEntity
    {
        long Id { get; set; }

        DateTime? CreateDate { get; set; }

        byte[] RowVersion { get; set; }
    }
}
