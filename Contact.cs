    namespace Class2Hw
    {
        abstract class Contact
{
        public string Name {
        set;get;
        }
        public int Age {
        set;get;
        }
        public int MobileNo {
        set;get;
        }

        public abstract void View();
        public abstract void Update();
    }
    }