using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lookAtSlender : MonoBehaviour
{
    [SerializeField] private RawImage staticImage;
    [SerializeField] private Color color;
    [SerializeField] private float drainRate, rechargeRate, health, healthDamage, healthRechargeRate, maxStaticAmount;
    private bool looking, canRecharge;
    [SerializeField] private AudioSource audio;
    [SerializeField] private float audioIncreaseRate, audioDecreaseRate;
    [SerializeField] private string deathScene;
    private void Start()
    {
        color.a = 0f;
        health = 100f;
    }

    private void OnBecameVisible()
    {
        looking = true;
    }

    private void OnBecameInvisible()
    {
        looking = false;
    }

    private void FixedUpdate()
    {
        if (color.a > maxStaticAmount)
        {

        }
        else if (color.a < maxStaticAmount)
        {
            staticImage.color = color;
        }

        if (looking == true)
        {
            color.a = color.a + drainRate * Time.deltaTime;
            audio.volume = audio.volume + audioIncreaseRate * Time.deltaTime;
            health = health - healthDamage * Time.deltaTime;

        }
        if (looking == false)
        {
            color.a = color.a - rechargeRate * Time.deltaTime;
            audio.volume = audio.volume - audioDecreaseRate * Time.deltaTime;

            if (canRecharge)
            {
                health = health + healthRechargeRate * Time.deltaTime;
            }
        }

        if (health < 0f)
        {
            SceneManager.LoadScene(deathScene);
        }

    }
}
