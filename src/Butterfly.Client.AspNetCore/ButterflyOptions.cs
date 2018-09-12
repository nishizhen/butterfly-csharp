using Microsoft.Extensions.Options;

namespace Housecool.Butterfly.Client.AspNetCore
{
    public class ButterflyOptions : ButterflyConfig , IOptions<ButterflyOptions>
    {
        public ButterflyOptions Value => this;
    }
}