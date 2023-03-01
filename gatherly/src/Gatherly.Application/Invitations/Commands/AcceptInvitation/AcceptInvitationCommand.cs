using MediatR;

namespace Gatherly.Application.Invitations.Commands.AcceptInvitation;

public sealed record AcceptInvitationCommand(Guid InvitationId) : IRequest;