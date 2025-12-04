using UnityEngine;
using static GameManager;

public class PauseState : IGameState
{
    public void Enter(GameManager gm)
    {

        Debug.Log("Paused");
        Time.timeScale = 0f;

        // disables inventory script when entering pause state
        gm.DisableInventory();
        

    }

    public void Update(GameManager gm)
    {

        /*if (Input.GetKeyDown(KeyCode.Escape))
            gm.ChangeState(new GameplayState());*/

    }

    public void Exit(GameManager gm)
    {

        // enables inventory script when resuming gameplay
        gm.EnableInventory();
        

    }

}
