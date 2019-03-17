using UnityEditor;

[RequireComponent((CharacterController))]
[AddComponent("Intro PRG/RPG/Player/Movement")]
public class Movenent : MonoBehaviour 
{
    #region Variables
    [Header("PLAYER MOVEMENT")]
    [Space(10)]
    [Header("Characters Move Direction")]
    public Vector2 moveDirection;
    private CharacterController _charC;
    [Header("Character Variables")]
    public float jumpSpeed = 8.0;
    public float speed = 5;
    public float gravity = 20;
    [Header("")]
    #endregion
    #region Start
    private void Start()
    {
        charC = GetComponent<CharacterController>();
    }
    #endregion
    #region Update
    private void update()
    {
        if(_charC.isGrounded)
        {
            movementDirection = new Vector3(Input.GetAxis("Horisontal"), 0, Input.GetAxis("Vertical")));
            moveDirection = transform.TransformDirection(moveDirection)
            moveDirection *= speed;

            if(Input.GetButton("jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        
        moveDirection.y -= gravity * Time.DeltaTime;
        _charC.Move(moveDirection * Time.Deltatime);
    }

}
//16 errors