using Hobby.DTO;
using System.Collections.Generic;

namespace Hobby.Services.Interfaces
{
    public interface IActivitiesService
    {
        IEnumerable<ActivitiesDTO> GetUserActivities(long id);
    }
}
