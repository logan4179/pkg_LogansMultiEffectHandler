using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace LogansMultiEffectHandler
{
    public class MultiEffectHandler : MonoBehaviour
    {
        [SerializeField] VisualEffect[] effects;
        [SerializeField] AudioClip _audioClip;

        void Start()
        {

        }

        [ContextMenu("z call FetchEffectsInHiearchy()")]
        public void FetchEffectsInHiearchy()
        {
            effects = GetComponentsInChildren<VisualEffect>();
        }

        public void PlayAll()
        {
            if (effects != null && effects.Length > 0)
            {
                foreach (VisualEffect effect in effects)
                {
                    effect.Play();
                }

                if (_audioClip != null)
                {
                    AudioSource.PlayClipAtPoint(
                        _audioClip, transform.position);
                }
            }
        }

        public void StopAll()
        {
            if (effects != null && effects.Length > 0)
            {
                foreach (VisualEffect effect in effects)
                {
                    effect.Stop();
                }
            }
        }
    }
}