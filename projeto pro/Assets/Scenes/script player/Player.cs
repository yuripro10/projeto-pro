using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade = 5f;
    public float manaInicial = 100f;
    public float TaxaDeDecrementoMana = 1f;
    public float TaxadeRecuperaMana = 1f;
    public float manaAtual;
    private Rigidbody2D rb;
    public Slider sliderMana;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        manaAtual = manaInicial;
    }


    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;
        float eixoY = Input.GetAxisRaw("Vertical") * velocidade;

        rb.velocity = new Vector2(eixoX, eixoY);
       // Debug.Log($"Horizontal: {eixoX}, Vertical: {eixoY}");

        if (eixoX != 0 || eixoY != 0)
        {
            manaAtual -= TaxaDeDecrementoMana * Time.deltaTime;
            if (manaAtual <= 0)
            {
                manaAtual = 0;
                SceneManager.LoadScene(1);
            }
            AtualizarSliderMana();

        }

        void AtualizarSliderMana()
        {
            sliderMana.value = manaAtual / manaInicial;
        }
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Recover"))
        {
            Debug.Log("conseguiu colidir...");
            StartCoroutine(RecuperaMana());
        }
    }

    IEnumerator RecuperaMana()
    {
        while (manaAtual < manaInicial)
        {
            manaAtual += TaxadeRecuperaMana * Time.deltaTime;
            AtualizarSliderMana();
            yield return null;
        }
    }

    private void AtualizarSliderMana()
    {

    }
}
