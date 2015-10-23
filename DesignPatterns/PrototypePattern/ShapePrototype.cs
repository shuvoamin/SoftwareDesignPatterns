using System;

namespace DesignPatterns.PrototypePattern
{
    public abstract class ShapePrototype : ICloneable
    {
        private int _id;
        protected string Type;

        public abstract void Draw();

        public new string GetType()
        {
            return Type;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public object Clone()
        {
            object clone;

            try
            {
                clone = Clone();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }

            return clone;
        }
    }
}
