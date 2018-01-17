using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 要素数5の配列を初期化する
		int[] array = {11,22,33,44,55};

		// 配列の要素をすべて表示する
		for(int i=0;i<5;i++){
			Debug.Log(array[i]);
		} //ここでfor文を終わらせる

			// sumを0で初期化する
			int sum = 0;
			// 10回処理を繰り返す
			for(int i=0;i<5;i++){
				// iの値をsumに足す
				sum += i;
			}
			// sumの値を表示する
		Debug.Log (sum);
			
		for(int i=4; i >= 0; i--) {
			Debug.Log(array[i]);

		}
			
	// ここでMagic関数を10回呼び出すfor文を書いてください
		Boss boss = new Boss();

		for(int i = 0; i < 10; i++)
		{
			boss.Magic();
		}
		boss.Magic();
	}
		
// Update is called once per frame
void Update()
{

	}	
	}

public class Boss
{
	// ここでmpの宣言と初期化をしてください
	int mp = 53;
	// 追加
	public void Magic()
	{
		// ここに処理を書く


			// ここはコメントです

		if (mp >= 5) {
			//    mpの値が５以上の場合、文字列を表示する
			mp -= 5;
			Debug.Log("魔法攻撃をした。残りmpは" + mp);

			} else {
				// mpが5未満だった場合
				Debug.Log("mpが足りません");
			}
		}

	}