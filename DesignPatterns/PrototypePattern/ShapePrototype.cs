using System;

namespace DesignPatterns.PrototypePattern
{
    public abstract class ShapePrototype : ICloneable
    {
        private int id;
        protected string type;

        public abstract void Draw();

        public string GetType()
        {
            return type;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public object Clone()
        {
            object clone = null;

            try
            {
                clone = this.Clone();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }

            return clone;
        }
    }
}
