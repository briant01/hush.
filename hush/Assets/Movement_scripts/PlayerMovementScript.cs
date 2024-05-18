using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PlayerMovementScript : MonoBehaviour
{

    public CharacterController controller;

    public Image StaminaBar;

    public float Stamina, MaxStamina;

    public float RunCost; 

    public float speed = 12f;

    public float ChargeRate;

    private Coroutine recharge; 


   

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 16f;

            Stamina -= RunCost * Time.deltaTime;
            if(Stamina < 0) Stamina = 0;
            StaminaBar.fillAmount = Stamina / MaxStamina;
            if (Stamina == 0) speed = 10f;

            if (recharge != null) StopCoroutine(recharge);
            recharge = StartCoroutine(RechargeStamina());

        } 
        else
        {
            speed = 12f;
        }

    



        Vector3 move = transform.right * x + transform.forward * z; 

        controller.Move(move * speed * Time.deltaTime);



    }
    private IEnumerator RechargeStamina()
    {
        yield return new WaitForSeconds(1f);

        while(Stamina < MaxStamina)
        {
            Stamina += ChargeRate / 10f;
            if(Stamina > MaxStamina) Stamina = MaxStamina;
            StaminaBar.fillAmount = Stamina / MaxStamina; 
            yield return new WaitForSeconds(0.1f);
        }
    }
    
}
