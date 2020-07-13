/*==============================================================================
Copyright (c) 2019 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using UnityEngine.Events;
using Vuforia;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
///
/// Changes made to this file could be overwritten when upgrading the Vuforia version.
/// When implementing custom event handler behavior, consider inheriting from this class instead.
/// </summary>
public class Personalize : MonoBehaviour
{
    // Each fish model needs to create a new GameObject 
    public GameObject fishPiranha;
    public GameObject fishPurplefish;
    public GameObject fishRainbow;
    public GameObject fishRed_rock;
    public GameObject fishRedear;
    public GameObject fishRockfish;
    public GameObject fishSardine;
    public GameObject fishShaud;
    public GameObject fishSpermwhale;
    public GameObject fishStingray; //10
    public GameObject fishSunfish;
    public GameObject fishSynodontis;
    public GameObject fishTitan;
    public GameObject fishTrewavas;
    public GameObject fishTrumpefish;//15

    //public static 'ARGame' instance
    public static bool isPiranha;
    public static bool isPurplefish;
    public static bool isRainbow;
    public static bool isRed_rock;
    public static bool isRedear;//5
    public static bool isRockfish;
    public static bool isSardine;
    public static bool isShaud;
    public static bool isSpermwhale;
    public static bool isStingray;//10
    public static bool isSunfish;
    public static bool isSynodontis;
    public static bool isTitan;
    public static bool isTrewavas;
    public static bool isTrumpefish;//15








    public enum TrackingStatusFilter
    {
        Tracked,
        Tracked_ExtendedTracked,
        Tracked_ExtendedTracked_Limited
    }

    /// <summary>
    /// A filter that can be set to either:
    /// - Only consider a target if it's in view (TRACKED)
    /// - Also consider the target if's outside of the view, but the environment is tracked (EXTENDED_TRACKED)
    /// - Even consider the target if tracking is in LIMITED mode, e.g. the environment is just 3dof tracked.
    /// </summary>
    public TrackingStatusFilter StatusFilter = TrackingStatusFilter.Tracked_ExtendedTracked_Limited;
    public UnityEvent OnTargetFound;
    public UnityEvent OnTargetLost;


    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;
    protected bool m_CallbackReceivedOnce = false;

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();

        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterOnTrackableStatusChanged(OnTrackableStatusChanged);
        }
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.UnregisterOnTrackableStatusChanged(OnTrackableStatusChanged);
        }
    }

    void OnTrackableStatusChanged(TrackableBehaviour.StatusChangeResult statusChangeResult)
    {
        m_PreviousStatus = statusChangeResult.PreviousStatus;
        m_NewStatus = statusChangeResult.NewStatus;

        Debug.LogFormat("Trackable {0} {1} -- {2}",
            mTrackableBehaviour.TrackableName,
            mTrackableBehaviour.CurrentStatus,
            mTrackableBehaviour.CurrentStatusInfo);

        HandleTrackableStatusChanged();
    }

    protected virtual void HandleTrackableStatusChanged()
    {
        if (!ShouldBeRendered(m_PreviousStatus) &&
            ShouldBeRendered(m_NewStatus))
        {
            OnTrackingFound();
        }
        else if (ShouldBeRendered(m_PreviousStatus) &&
                 !ShouldBeRendered(m_NewStatus))
        {
            OnTrackingLost();
        }
        else
        {
            if (!m_CallbackReceivedOnce && !ShouldBeRendered(m_NewStatus))
            {
                // This is the first time we are receiving this callback, and the target is not visible yet.
                // --> Hide the augmentation.
                OnTrackingLost();
            }
        }

        m_CallbackReceivedOnce = true;
    }

    protected bool ShouldBeRendered(TrackableBehaviour.Status status)
    {
        if (status == TrackableBehaviour.Status.DETECTED ||
            status == TrackableBehaviour.Status.TRACKED)
        {
            // always render the augmentation when status is DETECTED or TRACKED, regardless of filter
            return true;
        }

        if (StatusFilter == TrackingStatusFilter.Tracked_ExtendedTracked)
        {
            if (status == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                // also return true if the target is extended tracked
                return true;
            }
        }

        if (StatusFilter == TrackingStatusFilter.Tracked_ExtendedTracked_Limited)
        {
            if (status == TrackableBehaviour.Status.EXTENDED_TRACKED ||
                status == TrackableBehaviour.Status.LIMITED)
            {
                // in this mode, render the augmentation even if the target's tracking status is LIMITED.
                // this is mainly recommended for Anchors.
                return true;
            }
        }

        return false;
    }

    protected virtual void OnTrackingFound()
    {
        if (mTrackableBehaviour)
        {
            int num = Random.Range(0, 15); // Generate a random int from 1 to 3(the range will be changed according to the number of GameObject)
            print(num);
            if (num == 0) // if random num is 0, generate piranha fish at the target
            {
                GameObject fish = GameObject.Instantiate(fishPiranha);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(50, 0, 5);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;
                isPiranha = true;
            }
            if (num == 1) // if random num is 1, generate purplefish at the target
            {
                GameObject fish = GameObject.Instantiate(fishPurplefish);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;

                isPurplefish = true;
            }
            if (num == 2) // if random num is 2, generate yellow box fish at the target
            {
                GameObject fish = GameObject.Instantiate(fishSpermwhale);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;

                isSpermwhale = true;
            }
            if (num == 3) // if random num is 3, generate stingray fish at the target
            {
                GameObject fish = GameObject.Instantiate(fishStingray);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;

                isStingray = true;
            }
            if (num == 4) // if random num is 4, generate rainbow fish at the target
            {
                GameObject fish = GameObject.Instantiate(fishRainbow);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(50, 0, 50);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
               

                fish.transform.parent = this.transform;

                isRainbow = true;
            }
            if (num == 5) // if random num is 5, generate red_roch fish at the target
            {
                GameObject fish = GameObject.Instantiate(fishRed_rock);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;
                isRed_rock = true;


            }
            if (num == 6) // if random num is 6, generate redear_sunfish at the target
            {
                GameObject fish = GameObject.Instantiate(fishRedear);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;

                isRedear = true;
            }
            if (num == 7) // if random num is 7, generate rockfish at the target
            {
                GameObject fish = GameObject.Instantiate(fishRockfish);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;

                isRockfish = true;
            }
            if (num == 8) // if random num is 8, generate sardine at the target
            {
                GameObject fish = GameObject.Instantiate(fishSardine);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;

                isSardine = true;
            }
            if (num == 9) // if random num is 9, generate shaud at the target
            {
                GameObject fish = GameObject.Instantiate(fishShaud);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;


                isShaud = true;
            }
            if (num == 10) // if random num is 10, generate sunfish at the target
            {
                GameObject fish = GameObject.Instantiate(fishSunfish);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;

                isSunfish = true;
            }
            if (num == 11) // if random num is 11, generate synodontis at the target
            {
                GameObject fish = GameObject.Instantiate(fishSynodontis);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;

                isSynodontis = true;
            }
            if (num == 12) // if random num is 12, generate titan at the target
            {
                GameObject fish = GameObject.Instantiate(fishTitan);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;

                isTitan = true;
            }
            if (num == 13) // if random num is 13, generate trewavas at the target
            {
                GameObject fish = GameObject.Instantiate(fishTrewavas);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;

                isTrewavas = true;
            }
            if (num == 14) // if random num is 14, generate tumpefish at the target
            {
                GameObject fish = GameObject.Instantiate(fishTrumpefish);
                //fish.transform.position = this.transform.position;
                transform.position = new Vector3(40, 0, 40);
                fish.transform.position = this.transform.position + transform.position;
                Debug.Log(fish.transform.position.x);
                fish.transform.parent = this.transform;

                isTrumpefish = true;
            }

        }
    }

    protected virtual void OnTrackingLost()
    {
        if (mTrackableBehaviour)
        {
            // Destroy generated GameObject, the writing format is below:
            // GameObject.Find("The name of the prefab + (Clone)")
            Destroy(GameObject.Find("piranha(Clone)"));
            Destroy(GameObject.Find("purplefish(Clone)"));
            Destroy(GameObject.Find("stingray(Clone)"));
            Destroy(GameObject.Find("spermwhale(Clone)"));
            Destroy(GameObject.Find("rainbow_cichlid(Clone)"));
            Destroy(GameObject.Find("red_rockfish(Clone)"));
            Destroy(GameObject.Find("redear_sunfish(Clone)"));
            Destroy(GameObject.Find("rockfish(Clone)"));
            Destroy(GameObject.Find("sardine(Clone)"));
            Destroy(GameObject.Find("shaud(Clone)"));//10
            Destroy(GameObject.Find("sunfish(Clone)"));
            Destroy(GameObject.Find("Synodontis_eupterus(Clone)"));
            Destroy(GameObject.Find("titan_triggerfish(Clone)"));
            Destroy(GameObject.Find("trewavas_cichlid(Clone)"));
            Destroy(GameObject.Find("trumpetfish(Clone)"));//15

        }
    }

    
}
