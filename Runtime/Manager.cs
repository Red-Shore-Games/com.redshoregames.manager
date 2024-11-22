using RedShoreGames.EventSystem;
using UnityEngine;

namespace RedShoreGames.Manager
{
    public abstract class Manager<T, A> : Actor<A> where T : Manager<T, A> where A : MonoBehaviour
    {
        public static T Instance { get; private set; }

        protected virtual void Awake() => Instance = this as T;

        protected virtual void OnApplicationQuit()
        {
            Instance = null;
            Destroy(gameObject);
        }
    }
}