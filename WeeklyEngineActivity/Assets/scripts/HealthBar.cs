using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{

    public List<Image> bar = new List<Image>();
    float hp = 0;
    float maxHP = 1000;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hp = maxHP;
    }

    // Update is called once per frame
    void Update()
    {


        for (int i = 0; i < bar.Count; i++)
        {
            bar[i].rectTransform.localScale = new Vector3(hp / maxHP, 1, 1);
        }



        if (Input.GetMouseButton(0))
        {
            TakeDamage(1);
        }
        if(Input.GetMouseButton(1))
        {
            Heal(1);
        }



    }

    void TakeDamage(float dmg)
    {
        if (hp > 0)
        {
            hp -= dmg;
        }
    }

    void Heal(float heal)
    {
        if(hp<maxHP)
        {
            hp += heal;

        }
    }
}
