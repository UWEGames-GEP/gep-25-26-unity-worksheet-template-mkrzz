using UnityEditor;
using UnityEngine;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
    

    public interface IGameState
    {
        void Enter (GameManager gm);
        void Update (GameManager gm);
        void Exit (GameManager gm);

    }

    private IGameState currentState;

    private class GameplayState : IGameState
    {
        public void Enter(GameManager gm)
        {

            Debug.Log("Gameplay");
            Time.timeScale = 1f;

        }


        public void Update(GameManager gm)
        {

            if (Input.GetKeyDown(KeyCode.Escape))
                gm.ChangeState(new PauseState());

        }

        public void Exit(GameManager gm)
        {

            Debug.Log("Exciting Gameplay");

        }
    }

    private class PauseState : IGameState
    {
        public void Enter(GameManager gm)
        {

            Debug.Log("paused");
            Time.timeScale = 0f;

        }

        public void Update(GameManager gm)
        {

            if (Input.GetKeyDown(KeyCode.Escape))
                gm.ChangeState(new GameplayState());

        }

        public void Exit(GameManager gm)
        {

            Debug.Log("Exiting pause");

        }

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

