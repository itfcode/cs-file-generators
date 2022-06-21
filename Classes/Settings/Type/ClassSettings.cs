using ITFCode.CSFileGenerators.Classes.Settings.Type.Base;
using System.Collections.Generic;
using System.Linq;

namespace ITFCode.CSFileGenerators.Classes.Settings
{
    public class ClassSettings : ObjectTypeSettings
    {
        public bool IsInternal { get; set; } = false;

        public bool IsAbstract { get; set; } = false;

        public bool IsStatic { get; set; } = false;

        public IEnumerable<ConstSettings> Consts { get; set; } = Enumerable.Empty<ConstSettings>();
    }
}