using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    #region Public Variables
    [Header("Audio Clips")]
    public AudioClip LaserAudioClip;

    [Header("Prefabs")]
    public GameObject BulletPrefab;
    #endregion

    #region Private Member Variables
    private Rigidbody2D _Rigidbody = null;
    #endregion

    #region Unity Methods
    private void Start () 
    {
        _Rigidbody = GetComponent<Rigidbody2D>();
	    // TO-DO: code this class
	}
		
	private void Update () 
    {
        // TO-DO: code this class
    }
    private void FixedUpdate()
    {
        // TO-DO: code this class
    }
    #endregion
}
