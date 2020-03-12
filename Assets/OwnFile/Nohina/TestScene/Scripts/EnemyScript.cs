using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyScript : MoveActorClass
{

	[Range( 0, 1 )]
	[SerializeField] float actorSpeed;

	//自分のTextMeshPro描画
	TextMeshPro myTmp;

	private void FixedUpdate()
	{
		//動く処理
		MoveProcessor();
	}

	//動く処理
	void MoveProcessor()
	{
		float horizon = ReturnDirectFloat( "Horizontal" , 0 );
		float vertical = ReturnDirectFloat( "Vertical", KeyCode.W );

		MoveActor( horizon, vertical, actorSpeed );
	}

	void DrawInformation()
	{
		myTmp.GetComponent<TextMesh>().text = "Position = " + transform.position + "\n";
	}
}
