using UnityEngine;

namespace Scripts.CameraPlayer {
    public class TrackingCameraPlayer : MonoBehaviour {
        [SerializeField] private Transform Player;

        private void Update() {
            var TransformX = Player.transform.position.x;
            var TransformY = Player.transform.position.y;

            transform.position = new Vector3(TransformX, TransformY, transform.position.z);
        }
    }
}
