using System;

namespace Hobby.DTO
{
    public interface IModel
    {
        long Id { get; set; }

        DateTime? CreateDate { get; set; }

        byte[] RowVersion { get; set; }
    }
}
