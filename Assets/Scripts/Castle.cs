using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Castle : MonoBehaviour
{
    private float maxHp;
    private float damage;
    private Image guageBar;

    void Start()
    {
        maxHp = 10;
        damage = 1;
        guageBar = GameObject.Find("HpGuage").GetComponent<Image>();
        guageBar.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (guageBar.fillAmount <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        guageBar.fillAmount -= damage / maxHp;
        Destroy(collision.gameObject);
    }
}
