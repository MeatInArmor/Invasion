using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheKiwiCoder {

    // This is the blackboard container shared between all nodes.
    // Use this to store temporary data that multiple nodes need read and write access to.
    // Add other properties here that make sense for your specific use case.
    [System.Serializable]
	public class Blackboard
	{
        [Header("Target")]
		public Transform currentTarget;
		public Vector3 moveToPosition;

        [Header("Characters near")]
        public Transform[] self_monstersNear;
        public Transform[] self_mainsNear;

        [Header("Self characteristics")]
        public float self_health;
        public float self_stamina;
        public float self_mana;
        public bool self_isDefeated;
        public int[] magicStone_type;

        [Header("Target's characteristics")]
        public float target_health;
        public bool target_isDefeated;
        public GameObject[] enemy_bufs;
        public GameObject[] teammate_bufs;

    }
}