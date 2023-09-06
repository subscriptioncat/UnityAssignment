using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator _animWalk;
    private TopDownCharacterController _controller;
    
    
    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _animWalk = GetComponentInChildren<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnMoveEvent += isMove;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void isMove(Vector2 direction)
    {
        if(direction.x != 0 || direction.y != 0)
        {
            _animWalk.SetBool("isWalk", true);
        }
        else
        {
            _animWalk.SetBool("isWalk", false);
        }
        
    }
}
