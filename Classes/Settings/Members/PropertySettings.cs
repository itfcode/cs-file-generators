using ITFCode.CSFileGenerators.Classes.Settings.Base;

namespace ITFCode.CSFileGenerators.Classes.Settings
{
    public class PropertySettings : BaseSettings
    {
        public bool IsProtected { get; set; } = false;

        public bool IsVirtual { get; set; } = false;

        public string Type { get; set; } = "object";

        public string Getter { get; set; } = string.Empty;

        public string Setter { get; set; } = string.Empty;
    }
}