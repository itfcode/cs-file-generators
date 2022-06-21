using ITFCode.CSFileGenerators.Classes.Settings.Base;
using System.Collections.Generic;
using System.Linq;

namespace ITFCode.CSFileGenerators.Classes.Settings
{
    public class MethodSettings : BaseSettings
    {
        public string Params { get; set; } = string.Empty;

        public string Type { get; set; } = "void";

        public bool IsVirtual { get; set; } = false;

        public bool IsOverride { get; set; } = false;

        public bool IsPrivate { get; set; } = false;

        public bool IsProtected { get; set; } = false;

        public IEnumerable<string> GenericParams { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> GenericConditions { get; set; } = Enumerable.Empty<string>();
    }
}