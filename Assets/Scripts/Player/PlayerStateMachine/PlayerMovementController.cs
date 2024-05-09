using System;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private PlayerInput _playerInput;
    
    #region State
    public PlayerMovementStateMachine PlayerMovementStateMachine;
    public PlayerRunState PlayerRunState; 
    #endregion

    #region variables

    private Rigidbody2D  rigidbody;
    [SerializeField] private float speed;
    

    #endregion
    private void Awake()
    {
        _playerInput = new PlayerInput();
    }

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        PlayerMovementStateMachine = new PlayerMovementStateMachine();
        PlayerRunState = new PlayerRunState(PlayerMovementStateMachine,this,_playerInput,rigidbody,speed);
        PlayerMovementStateMachine.StartState(PlayerRunState);
        PlayerMovementStateMachine.CurrentPlayerMovementState.OnEnter();
    }
    private void Update()
    {
        PlayerMovementStateMachine.CurrentPlayerMovementState.OnUpdate();
    }
    private void FixedUpdate()
    {
        PlayerMovementStateMachine.CurrentPlayerMovementState.OnFixedUpdate();
    }
    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }
}