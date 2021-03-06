﻿using UnityEngine;
using System.Collections;

namespace ICode.Actions.UnityNavMeshAgent{
	[Category(Category.NavMeshAgent)]
	[Tooltip("The desired velocity of the agent including any potential contribution from avoidance.")]
	[HelpUrl("http://docs.unity3d.com/Documentation/ScriptReference/NavMeshAgent-desiredVelocity.html")]
	[System.Serializable]
	public class GetDesiredVelocity : NavMeshAgentAction {
		[Shared]
		[Tooltip("Result to store.")]
		public FsmVector3 store;
		[Tooltip("Execute the action every frame.")]
		public bool everyFrame;

		public override void OnEnter ()
		{
			base.OnEnter ();
			store.Value = agent.desiredVelocity;
			if (!everyFrame) {
				Finish ();
			}
		}

		public override void OnUpdate ()
		{
			store.Value = agent.desiredVelocity;
		}
	}
}