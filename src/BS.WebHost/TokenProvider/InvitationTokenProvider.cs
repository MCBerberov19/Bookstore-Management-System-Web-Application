using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace BS.WebHost.TokenProvider;

public class InvitationTokenProvider<TUser> : DataProtectorTokenProvider<TUser>
where TUser : class
{
    public InvitationTokenProvider(IDataProtectionProvider dataProtectionProvider, IOptions<DataProtectionTokenProviderOptions> options, ILogger<DataProtectorTokenProvider<TUser>> logger)
        : base(dataProtectionProvider, options, logger)
    {
    }

    public class InvitationTokenProviderOptions : DataProtectionTokenProviderOptions
    {
    }
}
