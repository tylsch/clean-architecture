using Gatherly.Domain.Entities;

namespace Gatherly.Domain.Repositories;

public interface IAttendeeRepository
{
    void Add(Attendee attendee);
}