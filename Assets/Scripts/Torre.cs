using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Torre : MonoBehaviour 
{
	public GameObject projetilPrefab;
	public float tempoDeRecarga = 1f;
	private float momentoDoUltimoDisparo;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Atira ();
	}

	public void Atira(Inimigo inimigo)
	{
		float tempoAtual = Time.time;
		if (tempoAtual > momentoDoUltimoDisparo + tempoDeRecarga) 
		{
			momentoDoUltimoDisparo = tempoAtual;

			GameObject PontoDeDisparo = this.transform.Find ("Canhao/PontoDeDisparo").gameObject;
			Vector3 posicaoDoPontoDeDisparo = PontoDeDisparo.transform.position;
			Instantiate (projetilPrefab, posicaoDoPontoDeDisparo, Quaternion.identity);

		}
			
	}


}
