using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss{
	private int hp = 100;
	private int power = 25;
	private int mp=53;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence(int damage){
		Debug.Log (damage+"のダメージを受けた");
		this.hp -= damage;
	}

	public void Magic(){
		if (this.mp >= 5) {
			
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}

}


public class Test : MonoBehaviour {


	// Use this for initialization
	void Start () {

		int[] array ={1,2,3,4,5};

		Debug.Log ("■配列の表示");
		for (int i=0; i<array.Length; i++){
			Debug.Log (array[i]);
		}

		Debug.Log ("■配列の表示（逆順）");
		for (int i=0; i<array.Length; i++){
			Debug.Log (array[array.Length-1-i]);
		}

		Debug.Log ("■ボスの魔法攻撃");
		Boss lastboss = new Boss();

		//lastboss.Attack();
		//lastboss.Defence(3);

		for (int i = 1; i <= 11; i++) {
			Debug.Log (i+"回目の攻撃：");
			lastboss.Magic();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
