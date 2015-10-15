using DesignPatterns.StatePattern;

namespace DesignPatterns.Interfaces
{
    public interface IState
    {
        void DoAction(Context context);
    }
}
