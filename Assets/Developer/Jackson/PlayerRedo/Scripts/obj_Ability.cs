using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Developer.Jackson.PlayerRedo.Scripts
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Ability", order = 1)]
    public class obj_Ability : ScriptableObject
    {
        public string name;
        public Sprite icon;

        public Ability ability;
    }
}