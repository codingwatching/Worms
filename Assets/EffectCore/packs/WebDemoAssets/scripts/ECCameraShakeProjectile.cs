﻿using UnityEngine;

namespace EffectCore.packs.WebDemoAssets.scripts
{
	public class ECCameraShakeProjectile : MonoBehaviour {

		//public bool cameraShakeBool = true;
		public Animator CamerShakeAnimator;

		// Use this for initialization
		void Start () {
		
		}
	
		// Update is called once per frame
		void Update () {
		
		}

		public void ShakeCamera()
		{
			CamerShakeAnimator.SetTrigger("CameraShakeTrigger");
		}
	}
}
