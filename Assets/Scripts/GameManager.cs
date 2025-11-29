
using Unity.VisualScripting;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    IGameState currentState;

    public interface IGameState
    {
        public void Enter (GameManager gm);
        public void Update (GameManager gm);
        public void Exit (GameManager gm);

    }
           

    private void Start()
    {

        ChangeState(new GameplayState());

    }

    private void Update()
    {

        currentState?.Update(this);

    }

    public void ChangeState(IGameState newState)
    {

        currentState?.Exit(this);
        currentState = newState;
        currentState?.Enter(this);  

    }

    

}

