﻿using Microsoft.AspNetCore.Builder;
using Ocelot.Library.Infrastructure.Responses;

namespace Ocelot.Library.Infrastructure.Authentication
{
    public interface IAuthenticationProviderFactory
    {
        Response<AuthenticationHandler> Get(string provider, IApplicationBuilder app);
    }
}