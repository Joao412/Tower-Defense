using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour 
{

	[SerializeField] private GameObject inimigo;
	private float momentoDoUltimoRespawn;

	[Range (0,3)]
	[SerializeField] private float tempoDeRespawn = 2f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		pontoDeRespawn ();
	}

	public void pontoDeRespawn()
	{
		float tempoAtual = Time.time;
		if (tempoAtual > momentoDoUltimoRespawn + tempoDeRespawn) 
		{
			momentoDoUltimoRespawn = tempoAtual;

			Vector3 posicaoDoPontoDeRespawn = this.transform.position;
			Instantiate (inimigo, posicaoDoPontoDeRespawn, Quaternion.identity);

		}

	}

}
