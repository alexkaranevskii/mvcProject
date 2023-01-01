using UnityEngine;

namespace TestMVC
{
    public class Controller
    {
        private View _playerView;
        private View _triggerView;
        private Transform _playerT;

        public Controller(View playerView, View triggerView)
        {
            _playerView = playerView;
            _triggerView = triggerView;
            _playerT = playerView._Transform;

            _triggerView.OnLevelObjectContact += ControllerRecievAction;
        }

        private void ControllerRecievAction(Collider col, int val, Transform ObjT)
        {
            Debug.Log("Обработчик события : Имя объекта в триггере -" + col.name);
            GameObject.Destroy(col.gameObject); 
        }


    }
}
