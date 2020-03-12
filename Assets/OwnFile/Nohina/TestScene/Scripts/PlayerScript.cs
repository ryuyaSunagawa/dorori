using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

	//プレイヤーのスピード
	[Range( 0, 10 )]
	[SerializeField] float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

		if( GameManager.Instance.padMode )
		{
			//パッド移動
			float horizontal = Input.GetAxis( "Horizontal" );
			float vertical = Input.GetAxis( "Vertical" );
		}
		else
		{

		}

    }
}
