﻿using UnityEngine;
using System.Collections;

public class movimentarC: MonoBehaviour {
	
	public Transform pt;
	public Transform ct;
	// Update is called once per frame
	void Update () {
		Vector3 posicaoDaCamera = pt.position;

                if (pt.position.x >= -31.86f && pt.position.x <= 34.6f) {
                    posicaoDaCamera.x = pt.position.x;
                } else {

                    if (pt.position.x > 0) {
                        posicaoDaCamera.x = 34.6f;
                    } else { 
                        posicaoDaCamera.x = -31.86f;
                    }
                }
                if (pt.position.y >= -18.07f && pt.position.y <= 31.1f) {
                    posicaoDaCamera.y = pt.position.y;
                } else {

                    if (pt.position.y > 0) {
                        posicaoDaCamera.y = 31.1f;
                    } else { 
                        posicaoDaCamera.y = -18.07f;
                    }
                }
                
        posicaoDaCamera.z = -12f;
		ct.position = posicaoDaCamera;
	}
}