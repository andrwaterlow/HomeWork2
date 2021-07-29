using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    sealed internal class DictionaryToInspecktor
    {
        public int[] keys { get; set; }
        public GameObject[] values { get; set; }

        public Dictionary<int, GameObject> dic = new Dictionary<int, GameObject>();

        public DictionaryToInspecktor()
        {
            Set();
            Create();
        }

        private void Set()
        {
            GameObject number0 = new GameObject();
            GameObject number1 = new GameObject();
            dic.Add(0, number0);
            dic.Add(1, number1);
        }

        private void Create()
        {
            int maxcount = dic.Count;
            keys = new int[maxcount];
            values = new GameObject[maxcount];
        }

        public void get()
        {
            for (int i = 0; i <dic.Count; i++)
            {
                keys[i] = i;
                values[i] = dic[i];
            }
        }

    }
}
