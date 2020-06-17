using System.Collections;
using UnityEngine;

namespace WeaponWheel
{
    public class Weapon : MonoBehaviour
    {
        public int Index;
        public string Name;
        public int Clips;
        public int ClipSize;
        public int ammo;
        public GameObject player;
        public bool noammo = false;

        public int Ammo => ammo;
        public int AmmoInUse => ammoInUse;

        public int ammoInUse;
        public bool _isReloading = false;
        
        public Weapon(int index = 0, string name = "Pistol", int clips = 5, int clipSize = 30)
        {
            Index = index;
            Name = name;
            Clips = clips;
            ClipSize = clipSize;
        }

        private void Start()
        {
            noammo = false;
            ammo = Clips * ClipSize;
            ammoInUse = ClipSize; //The ammo in our current clip
        }

    
        public void Shoot()
        {
            if(ammo + ammoInUse <= 0)
                return;
            
            if (ammoInUse > 0)
            {
                noammo = false;
                ammoInUse--;
            }
            if (ammoInUse<1)
            {
                noammo = true;
               // StartCoroutine(Reload());
            }
        }

        public bool exec = false;
        public IEnumerator Reload()
        {
            //We need to reload!
            //Change the Clip Only Once
            if (!exec)
            {
                ammo -= ClipSize;
                Clips--;
                exec = true;
            }
            _isReloading = true;
            yield return new WaitForSeconds(1f);
            ammoInUse = ClipSize;
            exec = false;
            _isReloading = false;
        }
    
        private void Update()
        {
           
            if (ammoInUse <= 0 && ammo > 0)
            {
                //Reload Automatically
                StartCoroutine(Reload());
            }
        }
    }
}