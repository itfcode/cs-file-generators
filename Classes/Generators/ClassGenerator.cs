using ITFCode.CSFileGenerators.Classes.Generators.Base;
using ITFCode.CSFileGenerators.Classes.Settings;
using System.Linq;

namespace ITFCode.CSFileGenerators.Classes.Generators
{
    public class ClassGenerator : ReferenceTypeGenerator<ClassSettings>
    {
        #region Protected Properties 

        #endregion

        #region Constructors 

        public ClassGenerator(ClassSettings settings) : base(settings) { }

        #endregion

        #region Protected Methods 

        protected override void Build()
        {
            BuildModules();
            sb.AppendLine($"namespace {_settings.Namespace}");
            sb.AppendLine("{");

            var className = _settings.Name;

            var staticPreffix = _settings.IsStatic ? "static " : string.Empty;
            var modificatorPreffix = _settings.IsInternal ? "internal" : "public";
            var abstractPreffix = _settings.IsAbstract ? "abstract " : string.Empty;
            var parentClass = HasParent ? $" : {_settings.Parent}" : string.Empty;

            var genericParams = HasGenericParams ?
                string.Concat("<", string.Join(',', _settings.GenericParams), ">") :
                string.Empty;

            var genericConditions = HasGenericConditions ?
                string.Join("\t\t\n", _settings.GenericConditions) :
                string.Empty;

            sb.AppendLine($"\t{modificatorPreffix} {staticPreffix}{abstractPreffix}class {className}{genericParams}{parentClass}{genericConditions}");

            sb.AppendLine("\t{");
            
            BuildConsts();
            
            BuildProperties();
            
            BuildConstructors();
            
            BuildMethods();

            sb.AppendLine("\t}");
            sb.AppendLine("}");
        }

        protected void BuildConsts()
        {
            var consts = _settings.Consts;

            if (!consts.Any()) return;

            foreach (var @const in consts)
                sb.AppendLine($"\t\tpublic const {@const.Type} {@const.Name} = {@const.Value};");
        }

        protected override void BuildFields()
        {
            var fields = _settings.Fields.OrderBy(x => x.IsProtected);

            if (!fields.Any()) return;

            sb.AppendLine("#region Private & Protected Fields");
            sb.AppendLine(string.Empty);

            foreach (var field in fields)
            {
            }

            sb.AppendLine("#endregion");
        }

        protected override void BuildProperties()
        {
            var protectedProperties = _settings.Properties.Where(x => x.IsProtected);
            var publicProperties = _settings.Properties.Where(x => !x.IsProtected);

            if (!protectedProperties.Any()) return;

            sb.AppendLine("#region Protected Properties");
            sb.AppendLine(string.Empty);

            foreach (var prop in protectedProperties)
            {
                sb.AppendLine($"protected {prop.Type} {prop.Name} {{{prop.Getter}}} {{{prop.Setter}}}");
            }

            sb.AppendLine("#endregion");

            if (!publicProperties.Any()) return;

            sb.AppendLine("#region Public Properties");
            sb.AppendLine(string.Empty);

            foreach (var prop in publicProperties)
            {
                sb.AppendLine($"public {prop.Type} {prop.Name} {{{prop.Getter}}} {{{prop.Setter}}}");
            }

            sb.AppendLine("#endregion");
        }

        protected void BuildConstructors() 
        {
            var constructors = _settings.Constructors;

            if (!constructors.Any()) return;

            sb.AppendLine("\t\t#region Constructors");
            sb.AppendLine(string.Empty);

            foreach (var constructor in constructors)
            {
                var modificator = _settings.IsInternal ? "internal" : "public";
                sb.AppendLine($"\t\t{modificator} {_settings.Name}({constructor.Params})");
                sb.AppendLine("\t\t{");
                
                if (!string.IsNullOrWhiteSpace(constructor.Context))
                    sb.AppendLine(constructor.Context);

                sb.AppendLine("\t\t}");
            }

            sb.AppendLine("\t\t#endregion");
        }

        protected override void BuildMethods()
        {
        }

        #endregion
    }
}