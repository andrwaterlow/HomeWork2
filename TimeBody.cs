using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts
{
    class TimeBody : MonoBehaviour
    {
        [SerializeField] private float _recordTime = 5f;
        private List<PointInTime> _pointsInTime;
        private Rigidbody _rigidbody;
        private bool _isRewinding;

        private void Start()
        {
            _pointsInTime = new List<PointInTime>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        public  void chooseRewindOrRecord()
        {
            if (_isRewinding)
            {
                Rewind();
            }
            else
            {
                Record();
            }
        }

        private void Rewind ()
        {
            if (_pointsInTime.Count > 1)
            {
                PointInTime pointInTime = _pointsInTime[0];
                transform.position = pointInTime.Position;
                transform.rotation = pointInTime.Rotation;
                _pointsInTime.RemoveAt(0);
            }
            else
            {
                PointInTime pointInTime = _pointsInTime[0];
                transform.position = pointInTime.Position;
                transform.rotation = pointInTime.Rotation;
                StopRewind();
            }
        }
        private void Record()
        {
            if (_pointsInTime.Count > Mathf.Round(_recordTime /
                Time.fixedDeltaTime))
            {
                _pointsInTime.RemoveAt(_pointsInTime.Count - 1);
            }

            _pointsInTime.Insert(0, new PointInTime(transform.position,
                transform.rotation, _rigidbody.velocity, _rigidbody.angularVelocity));
        }
        public void StarRewind()
        {
            _isRewinding = true;
            _rigidbody.isKinematic = true;
        }

        public  void StopRewind()
        {
            _isRewinding = false;
            _rigidbody.isKinematic = false;
            _rigidbody.velocity = _pointsInTime[0].Velocity;
            _rigidbody.angularVelocity = _pointsInTime[0].AngularVelocity;
        }
    }
}
