using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class CombatMusicControl : MonoBehaviour {

	public AudioMixerSnapshot outOfCombat;
	public AudioMixerSnapshot inCombat;
	public AudioClip[] stings;
	public AudioSource stingSource;
	public float bpm = 120;

	private float m_TransitionIn;
	private float m_TransitionOut;
	private float m_QuarterNote;

	// Use this for initialization
	void Start ()
	{
		m_QuarterNote = 60 / bpm;
		m_TransitionIn = m_QuarterNote * 3;
		m_TransitionOut = m_QuarterNote * 16;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Mystery"))
		{
			inCombat.TransitionTo (m_TransitionIn);
		}
		if (other.CompareTag ("Ping2"))
		{
			stingSource.clip = stings [0];
			stingSource.Play ();
			other.enabled = false;
		}
		if (other.CompareTag ("BGM1"))
		{
			stingSource.clip = stings [1];
			stingSource.Play ();
			other.enabled = false;
		}
		if (other.CompareTag ("Kapow"))
		{
			stingSource.clip = stings [2];
			stingSource.Play ();
			other.enabled = false;
		}

	}

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag ("Mystery"))
		{
			outOfCombat.TransitionTo (m_TransitionOut);
		}

	}
}
