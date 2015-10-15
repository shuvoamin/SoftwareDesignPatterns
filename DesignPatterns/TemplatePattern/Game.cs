namespace DesignPatterns.TemplatePattern
{
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        //template method
        public void Play()
        {
            //initialize the game
            Initialize();

            //start the game
            StartPlay();

            //end game
            EndPlay();
        }
    }
}
