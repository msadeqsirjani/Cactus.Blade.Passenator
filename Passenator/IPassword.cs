using System.Collections.Generic;

namespace Cactus.Blade.Passenator
{
    public interface IPassword
    {
        IPassword IncludeLowercase();
        IPassword IncludeUppercase();
        IPassword IncludeNumeric();
        IPassword IncludeSpecial();
        IPassword IncludeSpecial(string specialCharactersToInclude);
        IPassword LengthRequired(int passwordLength);
        string Next();
        IEnumerable<string> NextGroup(int numberOfPasswordsToGenerate);
    }
}
