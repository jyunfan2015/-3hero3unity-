﻿using UnityEngine;
using System.Collections;

namespace ICode.Actions.UnityAnimator{
	[Category(Category.Animator)]
	[Tooltip("Gets the pivot weight.")]
	[HelpUrl("http://docs.unity3d.com/ScriptReference/Animator-pivotWeight.html")]
	[System.Serializable]
	public class GetPivotWeight : AnimatorAction {
		[Shared]
		[Tooltip("Store the value.")]
		public FsmFloat store;
		[Tooltip("Execute the action every frame.")]
		public bool everyFrame;
		
		public override void OnEnter ()
		{
			base.OnEnter ();
			DoGetInfo ();
			if (!everyFrame) {
				Finish ();
			}
		}
		
		public override void OnUpdate ()
		{
			DoGetInfo ();
		}
		
		private void DoGetInfo(){
			store.Value = animator.pivotWeight;
		}
	}
}