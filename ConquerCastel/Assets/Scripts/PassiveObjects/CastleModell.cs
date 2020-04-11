using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace PassiveObjects
{
    public class CastleModell : PassiveObjectModell
    {

        [SerializeField] private GameObject wonImage;
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
                wonImage.SetActive(true);
            }
        }
    }
}
