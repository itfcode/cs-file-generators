using ITFCode.CSFileGenerators.Classes.Settings.Type.Base;
using System.Linq;

namespace ITFCode.CSFileGenerators.Classes.Generators.Base
{
    public abstract class ReferenceTypeGenerator<TSetting> : BaseGenerator<TSetting> where TSetting : ObjectTypeSettings
    {
        #region  Protected Properties 

        protected bool HasParent => !string.IsNullOrWhiteSpace(_settings.Parent);
        protected bool HasGenericParams => _settings.GenericParams.Any();
        protected bool HasGenericConditions => _settings.GenericConditions.Any();

        #endregion

        #region Constructros 

        public ReferenceTypeGenerator(TSetting settings) : base(settings) { }

        #endregion

        #region Protected Methods 

        protected abstract void BuildFields();

        protected abstract void BuildProperties();

        protected abstract void BuildMethods();

        protected void BuildModules()
        {
            var modules = _settings.Modules;

            if (!modules.Any()) return;

            foreach (var module in modules)
                sb.AppendLine($"using {module};");

            sb.AppendLine(string.Empty);
        }

        #endregion
    }
}