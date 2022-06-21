using ITFCode.CSFileGenerators.Classes.Generators.Base;
using ITFCode.CSFileGenerators.Classes.Settings;
using System.Linq;

namespace ITFCode.CSFileGenerators.Classes.Generators
{
    public sealed class InterfaceGenerator : ReferenceTypeGenerator<InterfaceSettings>
    {
        #region MyRegion

        #endregion

        #region Constructors 

        public InterfaceGenerator(InterfaceSettings settings) : base(settings) { }

        #endregion

        #region Protected Methods 

        protected override void Build()
        {
            BuildModules();

            sb.AppendLine($"namespace {_settings.Namespace}");
            sb.AppendLine("{");

            var parentPrefix = HasParent ? $" : {_settings.Parent}" : string.Empty;
            sb.AppendLine($"\tpublic interface {_settings.Name}{parentPrefix}");
            sb.AppendLine("\t{");

            BuildFields();
            BuildProperties();
            BuildMethods();

            sb.AppendLine("\t}");
            sb.AppendLine("}");
        }

        protected override void BuildFields()
        {
            var fields = _settings.Fields;

            if (!fields.Any()) return;

            foreach (var field in fields)
            {
                sb.AppendLine($"{field.Type} {field.Name};");
            }
        }

        protected override void BuildProperties()
        {
            var props = _settings.Properties;

            if (!props.Any()) return;

            foreach (var prop in props)
            {
                sb.AppendLine($"{prop.Type} {prop.Name} {{ get; set; }} ");
            }
        }

        protected override void BuildMethods()
        {
            var methods = _settings.Methods;

            if (!methods.Any()) return;

            foreach (var method in methods)
            {
                sb.AppendLine($"{method.Type} {method.Name}();");
            }
        }

        #endregion
    }
}