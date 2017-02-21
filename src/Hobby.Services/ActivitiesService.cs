using Hobby.Data.Interface;
using Hobby.DTO;
using Hobby.Services.Interfaces;
using Hobby.Services.Mappings;
using System.Collections.Generic;
using System.Linq;

namespace Hobby.Services
{
    public class ActivitiesService : IActivitiesService
    {
        private readonly IUnitOfWork _uow;
        
        public ActivitiesService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<ActivitiesDTO> GetUserActivities(long idUser)
        {
            var activities = _uow.Activities.All(x => x.IdUser == idUser)
                .Select(ActivityMappings.MapToDTO);

            return activities;
        }
    }
}
