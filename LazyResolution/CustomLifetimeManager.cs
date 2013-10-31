using Microsoft.Practices.Unity;

namespace LazyResolution
{
    public class CustomLifetimeManager : LifetimeManager
    {
        private object m_value;

        public override object GetValue()
        {
            return m_value;
        }

        public override void SetValue(object newValue)
        {
            m_value = newValue;
        }

        public override void RemoveValue()
        {
            m_value = null;
        }
    }
}
