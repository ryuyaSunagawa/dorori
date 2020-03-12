using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TmpLookAt : MonoBehaviour
{

	//プレイヤーカメラ取得
	[SerializeField] Transform playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		transform.position = transform.parent.position;
		Quaternion qua = Quaternion.LookRotation( playerCamera.forward );
		transform.rotation = qua;
    }
}
