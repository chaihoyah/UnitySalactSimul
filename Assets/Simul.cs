using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Simul : MonoBehaviour
{
    public GameObject japangi;
    public GameObject front_pan;
    public GameObject below_pan;
    public GameObject phone;
    public GameObject salad_dish;
    public GameObject moving_container;
    public GameObject StartButton;
    public GameObject front_whole_pan;
    public GameObject[] tong = new GameObject[6];
    public GameObject[] tong_rotate = new GameObject[6];
    public GameObject rotatePos;
    public GameObject rotatePos_tong;
    public GameObject[] topping = new GameObject[2];
    public GameObject dressing;
    public GameObject[] salad = new GameObject[6];

    Vector3 mainpos;
    Vector3 rotatepos;
    Vector3 rotatepos_tong;

    // Start is called before the first frame update
    void Start()
    {
        mainpos = japangi.transform.position;
        rotatepos_tong = rotatePos_tong.transform.position;
        rotatepos = new Vector3(1.785f, 3.749f, 2.902f);
        StartCoroutine(Simul_start());
    }

    // Update is called once per frame


    IEnumerator Simul_start()
    {
        yield return new WaitForSeconds(0.5f);
        phone.gameObject.SetActive(true);

        while (phone.transform.position.z < 0.8)
        {
            phone.transform.position += new Vector3(0, 0, 0.05f);
            yield return new WaitForEndOfFrame();
        }
        int i = 0;
        while(i<90)
        {
            front_pan.transform.Rotate(0, 0, 1);
            i++;
            yield return new WaitForEndOfFrame();
        }
        phone.gameObject.SetActive(false);

        while (moving_container.transform.localPosition.x > 0.53)
        {
            moving_container.transform.localPosition -= new Vector3(0.02f,0,0);
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(0.5f);
        salad_dish.gameObject.SetActive(true);
        while (salad_dish.transform.localPosition.y > 0.01)
        {
            salad_dish.transform.localPosition -= new Vector3(0, 0.01f, 0);
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(0.3f);
        StartButton.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        StartButton.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        StartButton.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        StartButton.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        front_whole_pan.gameObject.SetActive(false);

        while (moving_container.transform.localPosition.x < 0.83)
        {
            moving_container.transform.localPosition += new Vector3(0.03f, 0, 0);
            yield return new WaitForEndOfFrame();
        }

        i = 0;
        while(i<50)
        {
            tong[0].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[1].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[2].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[3].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[4].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[5].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            i++;
            yield return new WaitForEndOfFrame();
        }

        i = 0;
        while (i < 90)
        {
            tong_rotate[0].transform.RotateAround(rotatepos_tong, new Vector3(0, 0, 1), 2f);
            i++;
            yield return new WaitForEndOfFrame();
        }
        salad[0].transform.SetParent(moving_container.transform);
        i = 0;
        while (i < 100)
        {
            tong[0].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[1].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[2].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[3].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[4].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[5].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            i++;
            yield return new WaitForEndOfFrame();
        }

        i = 0;
        while (i < 100)
        {
            tong[0].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[1].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[2].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[3].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[4].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[5].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            i++;
            yield return new WaitForEndOfFrame();
        }

        i = 0;
        while (i < 90)
        {
            tong_rotate[2].transform.RotateAround(rotatepos_tong, new Vector3(0, 0, 1), 2f);
            i++;
            yield return new WaitForEndOfFrame();
        }
        salad[2].transform.SetParent(moving_container.transform);
        i = 0;
        while (i < 100)
        {
            tong[0].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[1].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[2].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[3].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[4].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[5].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            i++;
            yield return new WaitForEndOfFrame();
        }

        i = 0;
        while (i < 100)
        {
            tong[0].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[1].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[2].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[3].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[4].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            tong[5].transform.RotateAround(rotatepos, Vector3.up, -0.6f);
            i++;
            yield return new WaitForEndOfFrame();
        }

        i = 0;
        while (i < 90)
        {
            tong_rotate[4].transform.RotateAround(rotatepos_tong, new Vector3(0, 0, 1), 2f);
            i++;
            yield return new WaitForEndOfFrame();
        }
        salad[4].transform.SetParent(moving_container.transform);
        while (topping[0].transform.position.z>1.41)
        {
            topping[0].transform.position -= new Vector3(0, 0, 0.01f);
            topping[1].transform.position -= new Vector3(0, 0, 0.01f);
            dressing.transform.position -= new Vector3(0, 0, 0.01f);
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(0.5f);
        front_whole_pan.gameObject.SetActive(true);

        i = 0;
        while (i < 60)
        {
            if(moving_container.transform.localPosition.x > 0.53)
            {
                moving_container.transform.localPosition -= new Vector3(0.02f, 0, 0);
            }

            below_pan.transform.Rotate(0, 0, 1);
            i++;
            yield return new WaitForEndOfFrame();
        }

        while (moving_container.transform.localPosition.x > 0.53)
        {
            moving_container.transform.localPosition -= new Vector3(0.02f, 0, 0);
            yield return new WaitForEndOfFrame();
        }
    }

}
