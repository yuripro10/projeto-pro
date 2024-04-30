using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //variáveis e tipos de Dados
        int pontos = 10;
        float peso = 61.8f;
        double medida = 9.99999999999;
        bool ativado = false;
        string saudacao = "olá tudo bem?";

        Debug.Log("int:"+ pontos);
        Debug.Log("float:" + peso);
        Debug.Log("double:" + medida);
        Debug.Log("booleana" + ativado);
        Debug.Log("string" + saudacao);

        //Operadores aritméticos 
        int soma = 2 + 2;
        int subtracao = 10 - 2;
        int multiplicacao = 2 * 3; 
        float divisao = 20f / 6f;
        int resto = 10 % 5;


        Debug.Log("soma" + soma);
        Debug.Log("subtracao" + subtracao);
        Debug.Log("multiplicacao" + multiplicacao);
        Debug.Log("divisao" + divisao);
        Debug.Log("resto" + resto);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
