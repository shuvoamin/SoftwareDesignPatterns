namespace DesignPatterns.BridgePattern
{
    public class BridgePatternDemo
    {
        public ShapeBridge ShapeBridge
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public GreenCircle GreenCircle
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public RedCircle RedCircle
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            ShapeBridge redCircle = new CircleBridge(100, 100, 10, new RedCircle());
            ShapeBridge greenCircle = new CircleBridge(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();
        }
    }
}
