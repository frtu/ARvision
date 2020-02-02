using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ImageFX
{
    public class RawImageFadeOut : MonoBehaviour
    {
        #region Private Variables
        [SerializeField, Tooltip("How many seconds before fade out")]
        public float _secondsToFadeOut = 1f;

        [SerializeField, Tooltip("How big is the scale out")]
        public float _scaleOutFactor = 0.5f;
        private float _elapsedSecond = 0;
        private RawImage _uiImage;
        #endregion

        #region Unity Methods
        /// <summary>
        /// Initializes MLHands API.
        /// </summary>
        void Start()
        {
            _uiImage = GetComponent<RawImage>();
            Debug.Log(String.Format("Destroy={0}", _secondsToFadeOut));
            Destroy(this.gameObject, _secondsToFadeOut);
        }

        /// <summary>
        ///  Polls the Gestures API for up to date confidence values.
        /// </summary>
        void Update()
        {
            _elapsedSecond += Time.deltaTime;

            float alpha = (_secondsToFadeOut - _elapsedSecond) / _secondsToFadeOut;
            _uiImage.color = new Color(_uiImage.color.r, _uiImage.color.g, _uiImage.color.b, alpha);

            float scale = 1 + (_elapsedSecond * _scaleOutFactor / _secondsToFadeOut);
            _uiImage.transform.localScale = new Vector3(scale, scale, scale);

            Debug.Log(String.Format("_elapsedSecond={0} alpha={1} scale={2}", _elapsedSecond, alpha, scale));
        }
        #endregion
    }
}