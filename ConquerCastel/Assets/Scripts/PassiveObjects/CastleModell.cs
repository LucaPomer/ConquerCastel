using UnityEngine;

namespace PassiveObjects
{
    public class CastleModell : PassiveObjectModell
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public override void ReductHealth(float hitPoints)
        {
            base.ReductHealth(hitPoints);
            if (health<=0)
            {
                Debug.Log("You Won");
            }
        }
    }
}
