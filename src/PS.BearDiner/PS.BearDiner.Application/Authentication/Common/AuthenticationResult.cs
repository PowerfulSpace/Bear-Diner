﻿using PS.BearDiner.Domain.Users;

namespace PS.BearDiner.Application.Authentication.Common
{
    public record AuthenticationResult(User User, string Token);
}
