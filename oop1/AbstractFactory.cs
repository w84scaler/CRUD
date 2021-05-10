using System.Windows.Forms;

namespace oop1
{
    abstract class Creator
    {
        public abstract Form Create(ReturnMethod method, object obj, int index);
    }

    class BaseItemCreator : Creator
    {
        public override Form Create(ReturnMethod method, object obj, int index)
        {
            return new BaseItemForm(method, obj, index);
        }
    }

    class SpeedItemCreator : Creator
    {
        public override Form Create(ReturnMethod method, object obj, int index)
        {
            return new SpeedItemForm(method, obj, index);
        }
    }

    class DamageItemCreator : Creator
    {
        public override Form Create(ReturnMethod method, object obj, int index)
        {
            return new DamageItemForm(method, obj, index);
        }
    }

    class ApItemCreator : Creator
    {
        public override Form Create(ReturnMethod method, object obj, int index)
        {
            return new ApItemForm(method, obj, index);
        }
    }

    class AdItemCreator : Creator
    {
        public override Form Create(ReturnMethod method, object obj, int index)
        {
            return new AdItemForm(method, obj, index);
        }
    }

    class TankItemCreator : Creator
    {
        public override Form Create(ReturnMethod method, object obj, int index)
        {
            return new TankItemForm(method, obj, index);
        }
    }

    class PassiveEffectCreator : Creator
    {
        public override Form Create(ReturnMethod method, object obj, int index)
        {
            return new PassiveEffectForm(method, obj, index);
        }
    }
}