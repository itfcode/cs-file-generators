using ITFCode.CSFileGenerators.Classes.Settings.Base;

namespace ITFCode.CSFileGenerators.Classes.Settings
{
    public class ConstructorSettings : BaseSettings
    {
        public string Params { get; set; } = string.Empty;

        public bool IsInternal { get; set; } = false;

        public string Context { get; set; } = string.Empty;
    }
}