using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace MyScripts
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
        private bool m_Swap;
        private bool m_A1;
        private bool m_A2;
        private bool m_M1;
        private bool m_M1Up;
        private bool m_M2;
        private bool m_M2Up;

        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            m_Swap = CrossPlatformInputManager.GetButtonDown("Swap");
            m_A1 = CrossPlatformInputManager.GetButtonDown("Active1");
            m_A2 = CrossPlatformInputManager.GetButtonDown("Active2");
            m_M1 = CrossPlatformInputManager.GetButtonDown("Fire1");
            m_M1Up = CrossPlatformInputManager.GetButtonUp("Fire1");
            m_M2 = CrossPlatformInputManager.GetButtonDown("Fire2");
            m_M2Up = CrossPlatformInputManager.GetButtonUp("Fire2");
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(h, crouch, m_Jump, m_Swap, m_A1, m_A2, m_M1, m_M1Up, m_M2, m_M2Up);
            m_Jump = false;
            m_Swap = false;
            m_A1 = false;
            m_A2 = false;
            m_M1 = false;
            m_M1Up = false;
            m_M2 = false;
            m_M2Up = false;
        }
    }
}
