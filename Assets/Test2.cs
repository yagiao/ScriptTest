﻿using UnityEngine;
using System.Collections;

public class Boss {
	private int hp = 100;    // 体力
	private int power = 25; // 攻撃力
	private int mp = 53; //MP
	private int down = 5; //消費MP

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage + "のダメージを受けた");
		// 残りhpを減らす
		this.hp -= damage;
	}
	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}
	//魔法攻撃用の関数
	public void Magic( int a) { 
		for ( int b = 0; b <= a ; b++){
			if (mp >= 5) {
				this.mp -= this.down;
				Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);

			} else { 
				Debug.Log ("MPが足りないため魔法が使えない。");
			}
		}
	}
}
public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();
		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);
		// 魔法用の関数を呼び出す
		lastboss.Magic(10);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
