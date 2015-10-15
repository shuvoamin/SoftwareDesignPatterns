namespace DesignPatterns.FacadePatter
{
    public class FacadePatternDemo
    {
        public ShapeMaker ShapeMaker
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
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();	
        }
    }
}
