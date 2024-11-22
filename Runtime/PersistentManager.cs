using UnityEngine;

namespace RedShoreGames.Manager
{
    public abstract class PersistentManager<T, A> : Manager<T, A> where T : PersistentManager<T, A> where A : MonoBehaviour
    {
        protected override void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);
            base.Awake();
        }
    }
}