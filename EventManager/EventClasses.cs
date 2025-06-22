// Outdated. Need to be replaced with an Interface-based system. I don't remember what I was doing here.
namespace Laserbean.EventManager
{
    public class SingleItemEvent
    {
        public object value;

        public SingleItemEvent(object _value)
        {
            this.value = _value;
        }
    }


    public class DoubleItemEvent
    {
        public object value;
        public object value2;

        public DoubleItemEvent(object _value, object _value2)
        {
            this.value = _value;
            this.value2 = _value2;
        }
    }
}
