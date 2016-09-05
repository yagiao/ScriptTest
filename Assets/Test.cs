using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
		void Start (){
		//要素の個数が5の、int型の配列arrayを宣言
		int[] array = new int[5];
		//好きな値
		array [0] = 5;
		array [1] = 4;
		array [2] = 3;
		array [3] = 2;
		array [4] = 1;
		//配列の各要素の値を順番に表示
		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}
		for (int j = 4; j >= 0; j--) {
			Debug.Log (array [j]); 
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}