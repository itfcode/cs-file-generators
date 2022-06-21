using ITFCode.CSFileGenerators.Classes.Generators.Base;
using ITFCode.CSFileGenerators.Classes.Settings;

namespace ITFCode.CSFileGenerators.Classes.Generators
{
    public sealed class EnumGenerator : BaseGenerator<EnumSettings>
    {
        #region Constructors 

        public EnumGenerator(EnumSettings settings) : base(settings) { }

        #endregion

        #region Protected Methods 

        protected override void Build()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}