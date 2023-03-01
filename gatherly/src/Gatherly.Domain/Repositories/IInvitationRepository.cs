using Gatherly.Domain.Entities;

namespace Gatherly.Domain.Repositories;

public interface IInvitationRepository
{
    Task<Invitation?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    void Add(Invitation invitation);
}