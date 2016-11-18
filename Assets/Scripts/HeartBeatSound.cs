using UnityEngine;
using System.Collections;
using Logic.MionixQG;

public class HeartBeatSound : MonoBehaviour {

    private Monitor Mionix;

    public AudioClip HeartBeatClip;

    private AudioSource source;
    private float soundOffset;
    private float accumulator;

    private string currentStatus;

	void Start ()
    {
        Mionix = Monitor.Instance;
        Mionix.OnBioMetrics += Mionix_OnBioMetrics;

        source = GetComponent<AudioSource>();

        Mionix.Connect();
	}

    void Mionix_OnBioMetrics(object sender, BioMetricsEventArgs e)
    {
        var bioMetrics = e.BioMetrics;

        currentStatus = bioMetrics.heartRateState;

        Debug.Log(currentStatus);

        soundOffset = 1 / (bioMetrics.heartRate / 60f);
    }
	
	void Update ()
    {
        if(currentStatus == "active")
        {
            accumulator += Time.deltaTime;
            Debug.Log(soundOffset);

            if(accumulator >= soundOffset)
            {
                accumulator = 0;
                source.PlayOneShot(HeartBeatClip);
            }
        }
	}

    void OnDestroy()
    {
        Mionix.Disconnect();
    }
}
