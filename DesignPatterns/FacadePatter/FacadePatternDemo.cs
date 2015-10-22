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
