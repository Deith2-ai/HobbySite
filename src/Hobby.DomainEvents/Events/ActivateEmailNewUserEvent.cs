namespace Hobby.DomainEvents.Events
{
    public class ActivateEmailNewUserEvent : IDomainEvent
    {
        //Create properties to raise event
        public decimal idUser { get; set; }

        public string Email { get; set; }
    }
}
