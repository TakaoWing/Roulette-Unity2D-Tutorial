using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rouletteController : MonoBehaviour {

	float rotSpeed = 0; // 回転速度

	void Start () {
		
	}

	void Update () {
		
		if (Input.GetMouseButtonDown (0)) { // マウスが押されたら回転速度を設定する
			this.rotSpeed = 10;
		}

		transform.Rotate (0, 0, this.rotSpeed); // 回転速度分、ルーレットを回転させる
	}
}
