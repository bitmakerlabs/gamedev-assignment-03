using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour
{
    #region Public Member Variables
    [Header("Audio Clips")]
    public AudioClip[] ExplosionClips;

    [Header("Properties")]
    public float   Speed  = 1.0f;
    public int     Health = 1;
    public Vector2 Direction = Vector2.up;
    #endregion

    #region Private Member Variables
    private Rigidbody2D _Rigidbody = null;
    #endregion

    #region Unity Methods    
	private void Start () 
    {
        _Rigidbody = GetComponent<Rigidbody2D>();

        // TO-DO: complete this class
	}
		
	private void Update () 
    {
        // TO-DO: complete this class
    }

    private void FixedUpdate()
    {
        // TO-DO: complete this class
    }
    #endregion
}
