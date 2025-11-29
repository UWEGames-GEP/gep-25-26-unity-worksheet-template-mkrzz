using UnityEngine;
using static GameManager;

public class PauseState : IGameState
{
    public void Enter(GameManager gm)
    {

        Debug.Log("Paused");
        Time.timeScale = 0f;
        gm.DisableInventory();
        

    }

    public void Update(GameManager gm)
    {

        /*if (Input.GetKeyDown(KeyCode.Escape))
            gm.ChangeState(new GameplayState());*/

    }

    public void Exit(GameManager gm)
    {

        gm.EnableInventory();
        

    }

}
