using System.Linq;
using System.Security.Claims;
using InvaMeetings.Web.Model;

namespace InvaMeetings.Web.Shared
{
    public static class ClaimsPrincipalExtensions
    {
        public static UserModel AsApplicationUser(this ClaimsPrincipal user)
        {
            var id = user.Claims.SingleOrDefault(x => x.Type == "sub")?.Value;
            var email = user.Claims.SingleOrDefault(x => x.Type == "email")?.Value;
            var name = user.Claims.SingleOrDefault(x => x.Type == "name")?.Value;
            var givenName = user.Claims.SingleOrDefault(x => x.Type == "givenName")?.Value;
            var familyName = user.Claims.SingleOrDefault(x => x.Type == "familyName")?.Value;

            return new UserModel
            {
                UserId = id,
                Email = email,
                Name = name,
                GivenName = givenName,
                FamilyName = familyName,

            };
        }
    }
}