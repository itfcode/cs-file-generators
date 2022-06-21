using ITFCode.CSFileGenerators.Classes.Settings.Base;

namespace ITFCode.CSFileGenerators.Classes.Settings
{
    public class FieldSettings : BaseSettings
    {
        public bool IsProtected { get; set; } = false;

        public string Type { get; set; } = string.Empty;

        public string Initiator { get; set; } = string.Empty;
    }
}
