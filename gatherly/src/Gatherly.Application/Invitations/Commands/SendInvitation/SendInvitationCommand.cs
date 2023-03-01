using MediatR;

namespace Gatherly.Application.Invitations.Commands.SendInvitation;

public sealed record SendInvitationCommand(Guid MemberId, Guid GatheringId) : IRequest<Unit>;