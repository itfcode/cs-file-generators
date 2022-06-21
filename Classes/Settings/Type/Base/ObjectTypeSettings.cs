using System.Collections.Generic;
using System.Linq;

namespace ITFCode.CSFileGenerators.Classes.Settings.Type.Base
{
    public class ObjectTypeSettings : TypeSettings
    {
        public string Parent { get; set; } = string.Empty;

        public string Namespace { get; set; } = "ITFCode.Project";

        public IEnumerable<string> Modules { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> GenericParams { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> GenericConditions { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> ParentGenericParams { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<FieldSettings> Fields { get; set; } = Enumerable.Empty<FieldSettings>();

        public IEnumerable<PropertySettings> Properties { get; set; } = Enumerable.Empty<PropertySettings>();

        public IEnumerable<ConstructorSettings> Constructors { get; set; } = Enumerable.Empty<ConstructorSettings>();

        public IEnumerable<MethodSettings> Methods { get; set; } = Enumerable.Empty<MethodSettings>();
    }
}