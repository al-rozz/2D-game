using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new file", menuName = "Actions/Movement")]
public class Movement : ScriptableObject
{
    public GameObject character { get; set;}

    public float speed;
    public float jumpHeight;

    public AnimationCurve jumpCurve;
    public void MoveLeft()
    {
        character.transform.position -= new Vector3(speed * Time.deltaTime, 0);
    }

    public void MoveRight()
    {
        character.transform.position += new Vector3(speed * Time.deltaTime, 0);
    }

    public void Jump()
    {
        character.GetComponent<Rigidbody2D>().AddForce(character.transform.up * jumpHeight);
    }

    private IEnumerator AnimationByTime(Transform jumper, float duration)
    {
        float progress = 0;
        float expiredSeconds = 0;

        while (progress < 1)
        {
            expiredSeconds += Time.deltaTime;
            progress = expiredSeconds / duration;

            yield return null;
        }
    }
}
