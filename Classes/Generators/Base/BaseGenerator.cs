using System.Text;

namespace ITFCode.CSFileGenerators.Classes.Generators.Base
{
    public abstract class BaseGenerator<TTypeSetting> where TTypeSetting : class 
    {
        #region Private & Protected 

        protected TTypeSetting _settings;
        protected StringBuilder sb = new();

        #endregion

        #region Constructros 

        public BaseGenerator(TTypeSetting settings)
        {
            _settings = settings;
        }

        #endregion

        #region Public Methods 

        public override string ToString()
        {
            Build();
            return sb.ToString();
        }

        #endregion

        #region Protected Methods 

        protected abstract void Build();

        #endregion
    }
}