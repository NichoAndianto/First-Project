using UnityEngine;

public class Attack : MonoBehaviour
{
    Animator myAnimation;

    void Start()
    {
        myAnimation = GetComponent<Animator>();
    }

    void Update()
    {
        Attack();
    }

    void Attack()
    {
        if (Input.GetButtonDown("Fire1")) // When button is pressed
        {
            myAnimation.SetBool("Attack", true);
        }

        if (Input.GetButtonUp("Fire1")) // When button is released
        {
            myAnimation.SetBool("Attack", false);
        }
    }
}
