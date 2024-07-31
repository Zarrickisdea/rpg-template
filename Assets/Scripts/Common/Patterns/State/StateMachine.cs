using System.Collections.Generic;

public abstract class StateMachine
{
    protected Dictionary<string, BaseState> _states = new Dictionary<string, BaseState>();
    protected BaseState _currentState;

    public void AddState(string name, BaseState state)
    {
        _states.Add(name, state);
    }

    public void SetState(string name)
    {
        if (_currentState != null)
        {
            _currentState.Exit();
        }
        _currentState = _states[name];
        _currentState.Enter();
    }

    public abstract void InitStateMachine();
}
