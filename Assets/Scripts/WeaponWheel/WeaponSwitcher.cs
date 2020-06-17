using UnityEngine;

namespace WeaponWheel
{
    public class WeaponSwitcher : MonoBehaviour
    {
    
        [SerializeField] private Weapon[] Weapons = new Weapon[8];
    
        private int m_CurrentWeaponIndex = 0;
        private Weapon m_CurrentWeapon;

        public Weapon CurrentWeapon => m_CurrentWeapon;
        public static WeaponSwitcher instance;
    

        private void Start()
        {
            instance = this;
            m_CurrentWeaponIndex = 0;
            m_CurrentWeapon = Weapons[0];
            SwitchWeapon(0);
        }

        public void SwitchWeapon(int index)
        {
            //Sets our current Weapon
            if (index > Weapons.Length)
            {
                Debug.LogError("You are trying to assign the Current weapon to a Non-Existing Weapon!");
                return;
            }
            m_CurrentWeaponIndex = index;
            m_CurrentWeapon = Weapons[index];
            PlayerController.instance.SelectWeapon(index + 1);
        }
    }
}
