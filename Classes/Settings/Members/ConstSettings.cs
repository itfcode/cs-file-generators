using ITFCode.CSFileGenerators.Classes.Settings.Base;

namespace ITFCode.CSFileGenerators.Classes.Settings
{
    public class ConstSettings : BaseSettings
    {
        #region Public Properties 

        public string Type { get; init; }

        public string Value { get; init; }

        #endregion

        #region Constructors 

        public ConstSettings() { }

        public ConstSettings(string name, string type, string value)
        {
            Name = name;
            Type = type;
            Value = value;
        }

        #endregion
    }
}
