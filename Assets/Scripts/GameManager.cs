
using Unity.VisualScripting;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    [SerializeField] private Inventory inventory;
    public IGameState currentState;

    
    private void Awake()
    {
        inventory = FindAnyObjectByType<Inventory>();
    }

    // any class that has a state must have these 3 functions
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

    // function is called each time the state changes
    public void ChangeState(IGameState newState)
    {

        currentState?.Exit(this);
        currentState = newState;
        currentState?.Enter(this);  

    }

    public void TogglePause()
    { 

        if (currentState is GameplayState)
        {

            ChangeState(new PauseState());

        }
        else if (currentState is PauseState)
        {

            ChangeState(new GameplayState());

        }

    }

    public void DisableInventory()
    {

        inventory.enabled = false;

    }

    public void EnableInventory()
    {

        inventory.enabled = true;

    }

}

