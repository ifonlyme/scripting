using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Draw : MonoBehaviour
{
    //private Camera Cam;
    //[SerializeField] LineRenderer trailPrefab;

    //private LineRenderer currentTrail;
    //private List<Vector3> points;
    //public void LineUpdate(Vector3 pos)
    //{
    //    if (points==null)
    //    {
    //        points = new List<Vector3>();
    //        SetPoints(pos);
    //        return;
    //    }
    //    if (Vector3.Distance(points.Last(), pos)>=0.0001f)
    //    {
    //        SetPoints(pos);
    //    }
    //}

    //void SetPoints (Vector3 point)
    //{
    //    points.Add(point);
    //    trailPrefab.positionCount = points.Count;
    //    trailPrefab.SetPosition(points.Count - 1, point);
    //}

    //void Start()
    //{
    //        Cam = Camera.main;
    //}//Start() eend

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Debug.Log(111);
    //        CreateNewLine();
    //    }//if end

    //    if (Input.GetMouseButton(0))
    //    {
    //        AddPoint();
    //    }//if end

    //    if (Input.GetKeyDown(KeyCode.R))
    //    {
    //        if (transform.childCount != 0)
    //        {
    //            foreach (Transform R in transform)
    //            {
    //                Destroy(R.gameObject);
    //            }//loop end
    //        }//if end
    //    }//if end
    //     //UpdateLinePoints();
    //}//Update() end

    //private void CreateNewLine()
    //{
    //    currentTrail = Instantiate(trailPrefab);
    //    currentTrail.transform.SetParent(transform, true);
    //    points.Clear();
    //}//CreateCurrentTrail() end

    //private void UpdateLinePoints()
    //{
    //    if (currentTrail != null && points.Count > 1)
    //    {
    //        currentTrail.positionCount = points.Count;
    //        currentTrail.SetPositions(points.ToArray());
    //    }//if end
    //}//UpdateTrailPoints() end

    //private void AddPoint()
    //{
    //    var Ray = Cam.ScreenPointToRay(Input.mousePosition);
    //    RaycastHit hit;
    //    if (Physics.Raycast(Ray, out hit))
    //    {
    //        if (hit.collider.CompareTag("Writeable"))
    //        {
    //            // points.Add(new Vector3(hit.point.x, 0f, hit.point.z));
    //            points.Add(hit.point);
    //            UpdateLinePoints();
    //            return;
    //        }//if end
    //        else
    //            return;
    //    }//if end
    //}//AddPoint() end
}
