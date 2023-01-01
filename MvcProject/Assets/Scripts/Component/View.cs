using System;
using UnityEngine;


namespace TestMVC 
{ 
    public class View : MonoBehaviour
    {
        // поля класса
        [SerializeField] private Transform _transform;
        [SerializeField] private Collider _collider;
        [SerializeField] private Rigidbody _rb;

        // свойства
        public Transform _Transform { get => _transform; set => _transform = value; }
        public Rigidbody Rb { get => _rb; set => _rb = value; }
        public Collider _Collider { get => _collider; set => _collider = value; }


        public Action<Collider, int, Transform> OnLevelObjectContact { get; set; }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.name);
            Collider LevelObjectCol = other;
            OnLevelObjectContact?.Invoke(LevelObjectCol, 13, _Transform);
        }

    }
}
