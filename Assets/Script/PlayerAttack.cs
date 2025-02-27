using UnityEngine;
using UnityEngine.UI; 

public class PlayerAttack : MonoBehaviour
{
    Animator myAnimation;

    void Start()
    {
        myAnimation = GetComponent<Animator>();

        // Cari tombol attack dan tambahkan listener
        Button attackButton = GameObject.Find("AttackButton").GetComponent<Button>();
        attackButton.onClick.AddListener(Attack);
    }

    void Attack()
    {
        myAnimation.SetTrigger("Attack"); 
    }
}
